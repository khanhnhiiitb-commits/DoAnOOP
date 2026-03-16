using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models.Systems
{//sua
    public class PhieuNhap
    {
<<<<<<< HEAD
       public string MaPN { get; set; } 
        public string MaNCC {get; set;}          
        public DateTime NgayNhap { get; set; }      
        public string TongTien { get; set; }        
        public string SoDienThoai { get; set; }     
        public string Email { get; set; }          
=======
       // Private Fields
        private string maPN;
        private DateTime ngayNhap;
        private double tongTien; 
        private string soDienThoai;
        private string email;
>>>>>>> 1c50ed41b2c3072aa0c0c13d75b4afb9211f2b03

        // Properties
        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
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

        // Constructor mặc định
        public PhieuNhap() { }

        // Constructor đầy đủ tham số
        public PhieuNhap(string maPN, DateTime ngayNhap, double tongTien, string soDienThoai, string email)
        {
            this.maPN = maPN;
            this.ngayNhap = ngayNhap;
            this.tongTien = tongTien;
            this.soDienThoai = soDienThoai;
            this.email = email;
        }
    }
}