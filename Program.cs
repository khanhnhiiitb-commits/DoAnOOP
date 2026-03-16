using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Services;


namespace QuanLySieuThi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. KHOI TAO HE THONG
            QuanLyKho kho = new QuanLyKho();
            QuanLyNhanSu nhanSu = new QuanLyNhanSu();
            QuanLyBanHang banHang = new QuanLyBanHang();
            BaoCaoThongKe baoCao = new BaoCaoThongKe();


            // 2. TAO DU LIEU NHAN VIEN & TAI KHOAN
            NhanVien nv = new NhanVien("NV001", "Nguyen Thi Nhi", "Quan Ly");
            TaiKhoan tk = new TaiKhoan("nhi_admin", "123456", "HoatDong");
            nhanSu.ThemNhanVien(nv);
            // Gia su da them tk vao danh sach cua nhanSu
           
            Console.WriteLine("--- Kiem tra Dang nhap ---");
            bool login = nhanSu.DangNhap("nhi_admin", "123456");
            Console.WriteLine("Ket qua dang nhap: " + login);


            // 3. TAO DANH SACH MAT HANG (Co mat hang sap het)
            HangThucPham h1 = new HangThucPham("TP01", "Banh Mi", 10000, 5, DateTime.Now, DateTime.Now.AddDays(3)); // Sap het
            HangDienTu h2 = new HangDienTu("DT01", "May Tinh Bang", 5000000, 20, 12, "Samsung");
            HangThucPham h3 = new HangThucPham("TP02", "Sua Tuoi", 15000, 50, DateTime.Now, DateTime.Now.AddMonths(2));


            kho.ThemHangHoa(h1);
            kho.ThemHangHoa(h2);
            kho.ThemHangHoa(h3);


            // 4. GIA LAP QUY TRINH BAN HANG
            KhachHang kh = new KhachHang("KH001", "Khach Hang Thong Thai");
            HoaDon hd1 = banHang.TaoHoaDon(nv, kh);
            banHang.ThemChiTietHoaDon(hd1, h1, 2); // Ban 2 banh mi
            banHang.ThemChiTietHoaDon(hd1, h3, 10); // Ban 10 sua tuoi
           
            // Thanh toan va cap nhat kho
            banHang.ThanhToan(hd1, 500000, kho);
            Console.WriteLine("\n--- Sau khi ban hang ---");
            Console.WriteLine("Ton kho Banh Mi: " + h1.SoLuongTon); // Con 3


            // 5. CHAY BAO CAO THONG KE
            Console.WriteLine("\n--- Bao Cao Thong Ke ---");
           
            // Thong ke san pham sap het (Ton < 10)
            List<HangHoa> dsSapHet = baoCao.DanhSachHangSapHet(kho);
            Console.WriteLine("Cac mat hang sap het hang:");
            foreach (HangHoa hh in dsSapHet)
            {
                Console.WriteLine("- " + hh.TenHang + " (Con: " + hh.SoLuongTon + ")");
            }


            // Tinh doanh thu
            List<HoaDon> tatCaHoaDon = new List<HoaDon> { hd1 };
            double dtNgay = baoCao.TinhDoanhThuTheoNgay(DateTime.Now, tatCaHoaDon);
            Console.WriteLine("Tong doanh thu trong ngay: " + dtNgay);


            Console.WriteLine("\nKiem thu hoan tat. Nhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}

