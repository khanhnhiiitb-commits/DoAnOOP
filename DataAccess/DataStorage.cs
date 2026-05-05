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


            }
        }
    }
}
