using System.Collections.Generic;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Data
{
    public static class DataStorage
    {
        // Danh sách dùng chung cho toàn ứng dụng (Dữ liệu tạm trên RAM)
        public static List<HangHoa> DanhSachHang = new List<HangHoa>();
        public static List<NhanVien> DanhSachNV = new List<NhanVien>();
        public static List<HoaDon> DanhSachHD = new List<HoaDon>();

        // Hàm này để nạp sẵn vài dữ liệu mẫu cho Giao diện đẹp khi vừa mở lên
        public static void KhoiTaoDuLieuMau()
        {
            if (DanhSachHang.Count == 0)
            {
                DanhSachHang.Add(new HangThucPham { MaHH = "SP01", TenHang = "Sữa tươi", DonGia = 10000, SoLuongTon = 50 });
                DanhSachHang.Add(new HangThucPham { MaHH = "SP02", TenHang = "Bánh mì", DonGia = 5000, SoLuongTon = 20 });
            }
        }
    }
}