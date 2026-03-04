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

        public ChuongTrinhKhuyenMai() { }

        public ChuongTrinhKhuyenMai(string maKM, string ten, DateTime bd, DateTime kt, string nd)
        {
            MaCTKM = maKM;
            TenCT = ten;
            NgayBatDau = bd;
            NgayKetThuc = kt;
            NoiDung = nd;
        }
    }
}