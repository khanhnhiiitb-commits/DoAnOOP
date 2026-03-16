using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;


namespace QuanLySieuThi.Services
{
    public class QuanLyKhuyenMai
    {
        private List<ChuongTrinhKhuyenMai> danhSachCTKM;
        private List<Voucher> danhSachVoucher;


        public QuanLyKhuyenMai()
        {
            this.danhSachCTKM = new List<ChuongTrinhKhuyenMai>();
            this.danhSachVoucher = new List<Voucher>();
        }


        public void ThemChuongTrinh(ChuongTrinhKhuyenMai km)
        {
            if (km != null)
            {
                this.danhSachCTKM.Add(km);
            }
        }


        public void CapNhatChuongTrinh(string maCTrinh, ChuongTrinhKhuyenMai kmMoi)
        {
            for (int i = 0; i < danhSachCTKM.Count; i++)
            {
                if (danhSachCTKM[i].MaKM == maCTrinh)
                {
                    danhSachCTKM[i] = kmMoi;
                    break;
                }
            }
        }


        public Voucher KiemTraVoucher(string maVoucher)
        {
            foreach (Voucher v in danhSachVoucher)
            {
                if (v.MaVoucher == maVoucher && v.IsActive)
                {
                    return v;
                }
            }
            return null;
        }


        public double TinhTienGiam(HoaDon hd)
        {
            double tienGiam = 0;
            // Giả sử lấy chương trình đang có hiệu lực cao nhất
            foreach (ChuongTrinhKhuyenMai km in danhSachCTKM)
            {
                if (km.IsActive && hd.TongTien >= km.DieuKienApDung)
                {
                    tienGiam = hd.TongTien * (km.PhanTramGiam / 100.0);
                }
            }
            return tienGiam;
        }


        public void ApDungKhuyenMai(HoaDon hd)
        {
            if (KiemTraDieuKienApDung(hd))
            {
                double giam = TinhTienGiam(hd);
                hd.TongTien -= giam;
            }
        }


        public bool KiemTraDieuKienApDung(HoaDon hd)
        {
            foreach (ChuongTrinhKhuyenMai km in danhSachCTKM)
            {
                if (km.IsActive && hd.TongTien >= km.DieuKienApDung)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

