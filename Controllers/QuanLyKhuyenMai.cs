using System;
using System.Collections.Generic;
using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Services
{
    public class QuanLyKhuyenMai
    {
        private List<ChuongTrinhKhuyenMai> danhSachCTKM;
        private List<Voucher> danhSachVoucher;
        public List<ChuongTrinhKhuyenMai> DanhSachCTKM {  get { return danhSachCTKM; }  }
        public List<Voucher> DanhSachVoucher  { get { return danhSachVoucher; } }
        public QuanLyKhuyenMai(List<ChuongTrinhKhuyenMai> dsKM, List<Voucher> dsVC)
        {
            this.danhSachCTKM = dsKM;
            this.danhSachVoucher = dsVC;
        }
        public void ThemChuongTrinh(ChuongTrinhKhuyenMai km)
        {
            if (km != null)  { danhSachCTKM.Add(km);  }
        }
        public bool CapNhatChuongTrinh(string maCTrinh, ChuongTrinhKhuyenMai kmMoi)
        {
            for (int i = 0; i < danhSachCTKM.Count; i++)
            {
                if (danhSachCTKM[i].MaCTKM == maCTrinh)
                {
                    danhSachCTKM[i] = kmMoi;
                    return true;
                }
            }
            return false;
        }
        public Voucher KiemTraVoucher(string maVoucher)
        {
            foreach (Voucher v in danhSachVoucher)
            {
                if (v.MaVoucher == maVoucher && v.KiemTraHieuLuc())
                {
                    return v;
                }
            }
            return null;
        }
        public double TinhTienGiam(HoaDon hd)
        {
            if (hd == null) return 0; 
            double tongGiam = 0;
            foreach(ChuongTrinhKhuyenMai km in danhSachCTKM)
            {
                if (km.KiemTraDieuKien(hd)) {   tongGiam += km.TinhSoTienGiam(hd.TongTien);  }
            }
            return tongGiam;
        }
        public void ApDungKhuyenMai(HoaDon hd)
        {
            if (KiemTraDieuKienApDung(hd))
            {
                double soTienGiam = TinhTienGiam(hd);
                hd.ApDungGiamGia(soTienGiam);
            }
        }
        public bool KiemTraDieuKienApDung(HoaDon hd) { return hd != null && hd.TongTien > 0;  }
        public void ThemVoucher(Voucher v)
        {
            if (v != null)  {   danhSachVoucher.Add(v); }
        }
        public bool CapNhatVoucher(string maVoucher, Voucher voucherMoi)
        {
            for (int i = 0; i < danhSachVoucher.Count; i++)
            {
                if (danhSachVoucher[i].MaVoucher == maVoucher)
                {
                    danhSachVoucher[i] = voucherMoi;
                    return true;
                }
            }
            return false;
        }
        public bool DoiTrangThaiVoucher(string maVoucher)
        {
            for (int i = 0; i < danhSachVoucher.Count; i++)
            {
                if (danhSachVoucher[i].MaVoucher == maVoucher)
                {
                    danhSachVoucher[i].ThayDoiTrangThai();
                    return true;
                }
            }
            return false; 
        }
        public List<Voucher> LayDanhSachVoucher()  {  return danhSachVoucher;  }
        public void LuuDuLieuVoucher()
        {
            VoucherRepository voucherRepo = new VoucherRepository();
            voucherRepo.Save(this.danhSachVoucher);
        }

        public void LuuDuLieuKhuyenMai()
        {
            KhuyenMaiRepository kmRepo = new KhuyenMaiRepository();
            kmRepo.Save(this.danhSachCTKM);
        }
    }
}

        
        
   
