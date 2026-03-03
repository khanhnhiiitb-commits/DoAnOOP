using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models.Systems
{
    public class ChuongTrinhKhuyenMai
    {
       public string MaCTKM { get; set; }
        public string TenCT { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string NoiDung { get; set; }
        public double MucGiamGia { get; set; } // Ví dụ: 0.1 cho 10%

        public ChuongTrinhKhuyenMai() { }

        // Kiểm tra xem khuyến mãi còn hiệu lực hay không
        public bool ConHieuLuc()
        {
            DateTime hienTai = DateTime.Now;
            return (hienTai >= NgayBatDau && hienTai <= NgayKetThuc);
        }
    }
}