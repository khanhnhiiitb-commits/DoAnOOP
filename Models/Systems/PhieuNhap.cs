using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models.Systems
{//sua
    public class PhieuNhap
    {
       public string MaPN { get; set; } 
        public string MaNCC {get; set;}          
        public DateTime NgayNhap { get; set; }      
        public string TongTien { get; set; }        
        public string SoDienThoai { get; set; }     
        public string Email { get; set; }          

        public PhieuNhap() { }

        public PhieuNhap(string maPN, DateTime ngayNhap, string tongTien, string soDienThoai, string email)
        {
            MaPN = maPN;
            NgayNhap = ngayNhap;
            TongTien = tongTien;
            SoDienThoai = soDienThoai;
            Email = email;
        }
    }
}