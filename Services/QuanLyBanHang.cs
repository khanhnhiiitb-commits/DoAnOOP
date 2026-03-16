using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;


namespace QuanLySieuThi.Services
{
    public class QuanLyBanHang
    {
        private List<HoaDon> danhSachHoaDon;


        public QuanLyBanHang()
        {
            this.danhSachHoaDon = new List<HoaDon>();
        }


        public HoaDon TaoHoaDon(NhanVien nv, KhachHang kh)
        {
            HoaDon hd = new HoaDon();
            hd.MaNV = nv.MaNV;
            hd.MaKH = kh.MaKH;
            hd.NgayTao = DateTime.Now;
            hd.TrangThaiTT = "ChuaThanhToan";
           
            this.danhSachHoaDon.Add(hd);
            return hd;
        }


        public void ThemChiTietHoaDon(HoaDon hd, HangHoa hh, int soLuong)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon();
            ct.MaHH = hh.MaHH;
            ct.SoLuongMua = soLuongMua;
            ct.GiaBan = hh.DonGia;
           
            hd.DanhSachChiTiet.Add(ct);
            hd.TongTien = TinhTongTien(hd);
        }


        public void XoaChiTietHoaDon(HoaDon hd, string maHH)
        {
            for (int i = 0; i < hd.DanhSachChiTiet.Count; i++)
            {
                if (hd.DanhSachChiTiet[i].MaHH == maHH)
                {
                    hd.DanhSachChiTiet.RemoveAt(i);
                    break;
                }
            }
            hd.TongTien = TinhTongTien(hd);
        }


        public double TinhTongTien(HoaDon hd)
        {
            double tong = 0;
            foreach (ChiTietHoaDon ct in hd.DanhSachChiTiet)
            {
                tong += (ct.SoLuongMua * ct.GiaBan);
            }
            return tong;
        }


        public void ApDungVoucher(HoaDon hd, Voucher v)
        {
            if (v != null && v.TrangThai)
            {
                hd.TongTien = hd.TongTien - (hd.TongTien * v.GiaTri / 100);
            }
        }


        public void ThanhToan(HoaDon hd, double soTien, QuanLyKho kho)
        {
            if (soTien >= hd.TongTien)
            {
                hd.TrangThaiThanhToan = "DaThanhToan";
                foreach (ChiTietHoaDon ct in hd.DanhSachChiTiet)
                {
                    // Truyền số âm để hàm CapNhatSoLuong thực hiện phép trừ
                    kho.CapNhatSoLuong(ct.MaHang, -ct.SoLuong);
                }
            }
        }


        public void HuyHoaDon(string maHD)
        {
            for (int i = 0; i < danhSachHoaDon.Count; i++)
            {
                if (danhSachHoaDon[i].MaHD == maHD)
                {
                    danhSachHoaDon.RemoveAt(i);
                    break;
                }
            }
        }


        public string InHoaDon(HoaDon hd)
        {
            string log = "HOA DON: " + hd.MaHD + "\n";
            log += "Tong tien: " + hd.TongTien + "\n";
            return log;
        }
    }
}

