using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Data
{
    public static class DataStorage
    {
        // Danh sách dùng chung cho toàn ứng dụng (Dữ liệu tạm trên RAM)
        public static List<HangHoa> DanhSachHang = new List<HangHoa>();
        public static List<NhanVien> DanhSachNV = new List<NhanVien>();
        public static List<HoaDon> DanhSachHD = new List<HoaDon>();
        public static NhanVien NhanVienDangNhap = null;

        // Hàm này để nạp sẵn vài dữ liệu mẫu cho Giao diện đẹp khi vừa mở lên
        public static void KhoiTaoDuLieuMau()
        {
            if (DanhSachHang.Count == 0)
            {
                DanhSachHang.Add(new HangThucPham { MaHH = "SP01", TenHang = "Sữa tươi", DonGia = 10000, SoLuongTon = 50 });
                DanhSachHang.Add(new HangThucPham { MaHH = "SP02", TenHang = "Bánh mì", DonGia = 5000, SoLuongTon = 20 });
            }

                // Admin
            NhanVien admin = new NhanVien("NV01", "Huynh Thi B", new DateTime(1999, 10, 26), false, "0123456789", "HCM", "Quản trị viên");
            // Phải tạo đối tượng tài khoản cho nhân viên này
            admin.Taikhoan = new TaiKhoan
            {
                TenDangNhap = "admin",
                MatKhau = "123",
                UserRole = new Role
                {
                    MaRole = "admin",
                    TenRole = "Quản trị viên"
                }
            };

            DanhSachNV.Add(admin);

            // cashier
            NhanVien cashier = new NhanVien("NV02", "Nguyen Thi B", new DateTime(2003, 01, 22), false, "0123355637", "HCM", "Thu ngân");
            cashier.Taikhoan = new TaiKhoan
            {
                TenDangNhap = "cashier",
                MatKhau = "456",
                UserRole = new Role
                {
                    MaRole = "cashier",
                    TenRole = "Thu ngân"
                }
            };

            DanhSachNV.Add(cashier);

            // warehouse manager
            NhanVien warehouse = new NhanVien("NV03", "Tran Van C", new DateTime(2001, 12, 18), true, "0123355637", "HCM", "Thủ kho");
            warehouse.Taikhoan = new TaiKhoan
            {
                TenDangNhap = "warehouse",
                MatKhau = "789",
                UserRole = new Role
                {
                    MaRole = "warehouse",
                    TenRole = "Thủ kho"
                }
            };

            DanhSachNV.Add(warehouse);
        }
    }
    
}