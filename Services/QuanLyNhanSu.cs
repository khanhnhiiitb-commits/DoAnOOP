using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;


namespace QuanLySieuThi.Services
{
    public class QuanLyNhanSu
    {
        private List<NhanVien> DanhNV;
        private List<BangChamCong> DanhSachChamCong;
        private List<TaiKhoan> DanhSachTaiKhoan;


        public QuanLyNhanSu()
        {
            this.DanhNV = new List<NhanVien>();
            this.DanhSachChamCong = new List<BangChamCong>();
            this.DanhSachTaiKhoan = new List<TaiKhoan>();
        }


        public void ThemNhanVien(NhanVien nv)
        {
            if (nv != null)
            {
                this.DanhNV.Add(nv);
            }
        }


        public void CapNhatThongTinNhanVien(string MaNV, NhanVien nvMoi)
        {
            for (int i = 0; i < DanhNV.Count; i++)
            {
                if (DanhNV[i].MaNV == MaNV)
                {
                    DanhNV[i] = nvMoi;
                    break;
                }
            }
        }


        public bool DangNhap(string TenDangNhap, string MatKhau)
        {
            foreach (TaiKhoan tk in DanhSachTaiKhoan)
            {
                // Kiểm tra tên, mật khẩu và trạng thái tài khoản không bị khóa
                if (tk.TenDangNhap == TenDangNhap && tk.MatKhau == MatKhau && tk.TrangThai == "HoatDong")
                {
                    return true;
                }
            }
            return false;
        }


        public void ChamCongVao(string MaNV)
        {
            BangChamCong cc = new BangChamCong();
            cc.MaNV = MaNV;
            cc.NgayLamViec = DateTime.Now;
            cc.GioVao = DateTime.Now;
            this.DanhSachChamCong.Add(cc);
        }


        public void ChamCongRa(string MaNV)
        {
            foreach (BangChamCong cc in DanhSachChamCong)
            {
                // Tìm bản ghi chấm công của nhân viên trong ngày hôm nay chưa có giờ ra
                if (cc.MaNV == MaNV && cc.NgayLamViec.Date == DateTime.Now.Date)
                {
                    cc.GioRa = DateTime.Now;
                    break;
                }
            }
        }


        public double TinhLuong(string MaNV, int Thang, int Nam)
        {
            double tongLuong = 0;
            double luongMoiGio = 30000; // Giả định mức lương cơ bản


            foreach (BangChamCong cc in DanhSachChamCong)
            {
                if (cc.MaNV == MaNV && cc.NgayLamViec.Month == Thang && cc.NgayLamViec.Year == Nam)
                {
                    TimeSpan thoiGianLam = cc.GioRa - cc.GioVao;
                    tongLuong += thoiGianLam.TotalHours * luongMoiGio;
                }
            }
            return tongLuong;
        }


        public void KhoaTaiKhoan(string TenDangNhap)
        {
            foreach (TaiKhoan tk in DanhSachTaiKhoan)
            {
                if (tk.TenDangNhap == TenDangNhap)
                {
                    tk.TrangThai = "BiKhoa";
                    break;
                }
            }
        }
    }
}

