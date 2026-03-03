using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Models.Systems
{
    public class PhieuNhap
    {
       public string MaPN { get; set; }           // Mã phiếu nhập
        public DateTime NgayNhap { get; set; }      // Ngày nhập hàng
        public string MaNCC { get; set; }          // Mã nhà cung cấp (từ Infrastructures)
        public string MaNV { get; set; }           // Người lập phiếu
        public double TongTien { get; set; }       // Tổng giá trị đơn hàng

        public PhieuNhap() { }

        public PhieuNhap(string maPN, DateTime ngayNhap, string maNCC, string maNV, double tongTien = 0)
        {
            MaPN = maPN;
            NgayNhap = ngayNhap;
            MaNCC = maNCC;
            MaNV = maNV;
            TongTien = tongTien;
        }
    }
}