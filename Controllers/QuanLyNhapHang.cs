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
        public List<PhieuNhap> DanhSachPhieuNhap
        {
            get { return danhSachPhieuNhap; }
        }

       
        public QuanLyNhapHang(List<PhieuNhap> dsPN)
        {
            this.danhSachPhieuNhap = dsPN;
        }

        // Khởi tạo một phiếu nhập mới
        public PhieuNhap LapPhieuNhap(NhaCungCap ncc)
        {
            if (ncc == null) return null;
            string maMoi = "PN" + (danhSachPhieuNhap.Count + 1).ToString("D3");

            PhieuNhap pn = new PhieuNhap(maMoi, ncc, DateTime.Now, 0);

            danhSachPhieuNhap.Add(pn);
            return pn;
        }

        // Thêm từng món hàng vào phiếu nhập
        public void ThemChiTietPhieuNhap(PhieuNhap pn, HangHoa hh, int soLuong, double giaNhap)
        {
            if (pn != null && hh != null)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap(pn.MaPN, hh.MaHH, soLuong, giaNhap);
                pn.ThemChiTiet(ct);
            }
        }

        

        // Xác nhận nhập kho: Lúc này hàng mới thực sự cộng vào tồn kho
        public void XacNhanNhapKho(PhieuNhap pn, QuanLyKho serviceKho)
        {
            if (pn != null && pn.TrangThai == "ChoXacNhan")
            {
                foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
                {
                    // Gọi sang QuanLyKho để tăng số lượng tồn kho thực tế
                    serviceKho.CapNhatSoLuong(ct.MaHH, ct.SoLuong);

                    // Cập nhật giá vốn mới nhất cho hàng hóa trong kho
                    CapNhatGiaNhap(ct.MaHH, ct.DonGia, serviceKho);
                }

                // Khắc phục: Sử dụng phương thức hành vi đóng gói của Model để đổi trạng thái văn minh
                pn.XacNhanXuatKho();
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
                        danhSachPhieuNhap[i].HuyDonPhieu();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}