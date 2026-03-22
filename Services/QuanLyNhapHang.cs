using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales; 
using QuanLySieuThi.Models.Products; 

namespace QuanLySieuThi.Services
{
    public class QuanLyNhapHang
    {
        private List<PhieuNhap> danhSachPhieuNhap;

        public QuanLyNhapHang(List<PhieuNhap> dsPN)
        {
            this.danhSachPhieuNhap = dsPN;
        }

        // Khởi tạo một phiếu nhập mới
        public PhieuNhap LapPhieuNhap(NhaCungCap ncc)
        {
            if (ncc == null) return null;
            
            PhieuNhap pn = new PhieuNhap();
            pn.MaPN = "PN" + (danhSachPhieuNhap.Count + 1);
            pn.NgayNhap = DateTime.Now;
            pn.NhaCC = ncc; // Association với Nhà cung cấp
            pn.TrangThai = "ChoXacNhan";
            
            danhSachPhieuNhap.Add(pn);
            return pn;
        }

        // Thêm từng món hàng vào phiếu nhập
        public void ThemChiTietPhieuNhap(PhieuNhap pn, HangHoa hh, int soLuong, double giaNhap)
        {
            if (pn != null && hh != null)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap(hh.MaHH, hh.TenHang, soLuong, giaNhap);
        
                pn.DanhSachChiTiet.Add(ct);
                TinhTongTien(pn);
            }
        }

        // Tính tổng tiền cho phiếu nhập (Duyệt vòng lặp truyền thống)
        public void TinhTongTien(PhieuNhap pn)
        {
            double tong = 0;
            foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
            {
                tong += ct.SoLuong * ct.DonGia;
            }
            pn.TongTien = tong;
        }

        // Xác nhận nhập kho: Lúc này hàng mới thực sự cộng vào tồn kho
        public void XacNhanNhapKho(PhieuNhap pn, QuanLyKho serviceKho)
        {
            if (pn != null && pn.TrangThai == "ChoXacNhan")
            {
                foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
                {
                    // Gọi sang QuanLyKho để tăng số lượng tồn
                    serviceKho.CapNhatSoLuong(ct.MaHH, ct.SoLuong);
                    // Cập nhật giá nhập mới nhất cho hàng hóa
                    CapNhatGiaNhap(ct.MaHH, ct.DonGia, serviceKho);
                }
                pn.TrangThai = "DaNhapKho";
            }
        }

        public void CapNhatGiaNhap(string maHH, double giaMoi, QuanLyKho serviceKho)
        {
            List<HangHoa> ketQua = serviceKho.TimKiemHangHoa(maHH);
            foreach (HangHoa hh in ketQua)
            {
                if (hh.MaHH == maHH)
                {
                    hh.DonGia = giaMoi; // Cập nhật giá vốn mới
                    break;
                }
            }
        }

        public bool HuyPhieuNhap(string maPN)
        {
            for (int i = 0; i < danhSachPhieuNhap.Count; i++)
            {
                if (danhSachPhieuNhap[i].MaPN == maPN)
                {
                    if (danhSachPhieuNhap[i].TrangThai == "ChoXacNhan")
                    {
                        danhSachPhieuNhap[i].TrangThai = "DaHuy";
                        return true;
                    }
                }
            }
            return false;
        }
    }
}