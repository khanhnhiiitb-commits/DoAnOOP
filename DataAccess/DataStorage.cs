using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Data
{
    public class DataStorage
    {
        // 1. Biến static duy nhất lưu trữ thực thể của lớp
        private static DataStorage instance;

        // 2. Constructor private: Không cho phép "new" từ bên ngoài
        private DataStorage()
        {
            DanhSachHang = new List<HangHoa>();
            DanhSachNV = new List<NhanVien>();
            DanhSachHD = new List<HoaDon>();
            //KhoiTaoDuLieuMau();
            StaffRepository staffRepo = new StaffRepository();
            // DanhSachKH = new List<KhachHang>(); 
            List<Nguoi> danhSachChung = staffRepo.GetAll();
            foreach (Nguoi ng in danhSachChung)
            {
                if (ng is NhanVien nv)
                {
                    DanhSachNV.Add(nv);
                }
            }
        }

        // 3. Property duy nhất để truy cập vào kho dữ liệu
        public static DataStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;
            }
        }

        // Các danh sách dữ liệu (Bỏ chữ static ở đây)
        public List<HangHoa> DanhSachHang { get; set; }
        public List<NhanVien> DanhSachNV { get; set; }
        public List<HoaDon> DanhSachHD { get; set; }
        public NhanVien NhanVienDangNhap { get; set; }

        public void KhoiTaoDuLieuMau()
        {
            if (DanhSachHang.Count == 0)
            {
                
                DanhSachHang.Add(new HangThucPham { MaHH = "SP01", TenHang = "Sữa tươi", DonGia = 10000, SoLuongTon = 50 });
               

            // Admin

            NhanVien admin = new NhanVien("NV01", "Huynh Thi B", new DateTime(1999, 10, 26), false, "0123456789", "HCM", "Quản trị viên");

           

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
            NhanVien warehouse = new NhanVien("NV003", "Tran Van C", new DateTime(2001, 12, 18), true, "0123355637", "HCM", "Thủ kho");
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
}