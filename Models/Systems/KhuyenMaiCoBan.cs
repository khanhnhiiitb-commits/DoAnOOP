using QuanLySieuThi.Models.Sales;
using System;

namespace QuanLySieuThi.Models.Systems
{
    // Kế thừa lớp cha để hợp thức hóa tính Đa hình
    public class KhuyenMaiCoBan : ChuongTrinhKhuyenMai
    {
        // Bắt buộc có constructor rỗng cho JSON
        public KhuyenMaiCoBan() { }

        public KhuyenMaiCoBan(string maKM, string ten, DateTime bd, DateTime kt, string nd)
            : base(maKM, ten, bd, kt, nd)
        {
        }

        // Viết code "cho có" để thỏa mãn quy tắc abstract của lớp cha
        public override bool KiemTraDieuKien(HoaDon hd)
        {
            return true;
        }

        public override double TinhSoTienGiam(double tongTienHD)
        {
            return 0;
        }
    }
}