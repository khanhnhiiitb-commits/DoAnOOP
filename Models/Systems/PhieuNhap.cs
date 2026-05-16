using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Models.Systems
{
  public class PhieuNhap
 {
    
        private string maPN;
        private NhaCungCap nhaCC;
        private DateTime ngayNhap;
        private double tongTien; 
        private string trangThai;
        private List<ChiTietPhieuNhap> danhSachChiTiet = new List<ChiTietPhieuNhap>();

        // Properties
        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public NhaCungCap NhaCC
        {
            get { return nhaCC; }
            set { nhaCC = value; }
        }
        public string MaNCC
        {
            get { return nhaCC != null ? nhaCC.MaNCC : string.Empty; }
        }
        public string SoDienThoai
        {
            get { return nhaCC != null ? nhaCC.SoDienThoai : string.Empty; }
        }

        public string Email
        {
            get { return nhaCC != null ? nhaCC.Email : string.Empty; }
        }
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            private set 
            { 
                if (value >= 0) 
                    tongTien = value; 
                else 
                    tongTien = 0;
            }
        }

        public List<ChiTietPhieuNhap> DanhSachChiTiet 
        { 
            get { return danhSachChiTiet; } 
        }

        // Phương thức để tính lại tổng tiền dựa trên các chi tiết
        public void TinhTongTien()
        {
            double tong = 0;
            int i;
            for (i = 0; i < danhSachChiTiet.Count; i++)
            {
                tong = tong + (danhSachChiTiet[i].SoLuong * danhSachChiTiet[i].DonGia);
            }
            this.TongTien = tong;
        }

        // Constructor mặc định
        public PhieuNhap() { }


        public PhieuNhap(string maPN, NhaCungCap ncc, DateTime ngayNhap, double tongTien)
        {
            this.MaPN = maPN;
            this.NhaCC = ncc;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
            this.TrangThai = "ChoXacNhan";
            this.danhSachChiTiet = new List<ChiTietPhieuNhap>();
        }
        public void ThemChiTiet(ChiTietPhieuNhap ct)
        {
            if (ct != null)
            {
                this.danhSachChiTiet.Add(ct);

                TinhTongTien(); 
            }
        }
        public void XacNhanXuatKho() 
        {
            this.trangThai = "DaNhapKho";
        }

        public void HuyDonPhieu()
        {
            this.trangThai = "DaHuy";
        }
    }
}