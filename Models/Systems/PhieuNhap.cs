using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models.Systems
{
  public class PhieuNhap
 {
    
       // Private Fields
        private string maPN;
        private string maNCC;
        private DateTime ngayNhap;
        private double tongTien; 
        private string soDienThoai;
        private string email;
        private List<ChiTietPhieuNhap> danhSachChiTiet = new List<ChiTietPhieuNhap>();

        // Properties
        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { if (value >= 0) tongTien = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<ChiTietPhieuNhap> DanhSachChiTiet 
        { 
            get { return danhSachChiTiet; } 
        }

        // Phương thức để tính lại tổng tiền dựa trên các chi tiết
        public void TinhTongTien()
        {
            double tong = 0;
            foreach (var ct in danhSachChiTiet)
            {
                tong += ct.ThanhTien;
            }
            this.tongTien = tong;
        }

        // Constructor mặc định
        public PhieuNhap() { }

        // Constructor đầy đủ tham số
        public PhieuNhap(string maPN,string maNCC, DateTime ngayNhap, double tongTien, string soDienThoai, string email)
        {
            this.maPN = maPN;
            this.maNCC = maNCC;
            this.ngayNhap = ngayNhap;
            this.tongTien = tongTien;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.danhSachChiTiet = new List<ChiTietPhieuNhap>();
        }
   }
}