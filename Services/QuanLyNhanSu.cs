using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Services
{
    public class QuanLyNhanSu
    {
        private List<NhanVien> danhNV;
        private List<BangChamCong> danhSachChamCong;
        private List<TaiKhoan> danhSachTaiKhoan;

        public QuanLyNhanSu(List<NhanVien> dsNV, List<BangChamCong> dsCC, List<TaiKhoan> dsTK)
        {
            this.danhNV = dsNV;
            this.danhSachChamCong = dsCC;
            this.danhSachTaiKhoan = dsTK;
        }

        // 2. Methods (Thực thi theo sơ đồ)

        public void ThemNhanVien(NhanVien nv)
        {
            if (nv != null) danhNV.Add(nv);
        }

        public bool CapNhatThongTinNhanVien(string maNV, NhanVien nvMoi)
        {
            for (int i = 0; i < danhNV.Count; i++)
            {
                if (danhNV[i].MaNV == maNV)
                {
                    danhNV[i] = nvMoi;
                    return true;
                }
            }
            return false;
        }

        // Logic Đăng nhập (Duyệt thủ công qua danh sách tài khoản)
        public TaiKhoan DangNhap(string tenDangNhap, string matKhau)
        {
            foreach (TaiKhoan tk in danhSachTaiKhoan)
            {
                if (tk.TenDangNhap == tenDangNhap && tk.KiemTraMatKhau(matKhau))
                {
                    if (tk.TrangThai) return tk; // Tài khoản còn hoạt động
                }
            }
            return null;
        }

        public void ChamCongVao(string maNV)
        {
            int thangNay = DateTime.Now.Month;
            int namNay = DateTime.Now.Year;
    
            foreach (BangChamCong bcc in danhSachChamCong)
            {
                if (bcc.MaNhanVien == maNV && bcc.Thang == thangNay && bcc.Nam == namNay)
                {

                    bcc.SoNgayLamViec++;
                    return;
                }
            }
            // Nếu chưa có bảng công cho tháng này, tạo mới một cái
            BangChamCong moi = new BangChamCong(maNV, thangNay, namNay, 1, 0, 0, "Mới khởi tạo");
            danhSachChamCong.Add(moi);
        }
    

        public void ChamCongRa(string maNV)
        {
            Console.WriteLine("Nhân viên " + maNV + " đã ra về lúc: " + DateTime.Now);
        }

        // Tính lương dựa trên số công trong tháng
        public double TinhLuong(string maNV, int thang, int nam)
        {
            foreach (BangChamCong bcc in danhSachChamCong)
            {
                if (bcc.MaNhanVien == maNV && bcc.Thang == thang && bcc.Nam == nam)
                {
                    double luongCB = 0;
                    foreach (NhanVien nv in danhNV)
                    {
                        if (nv.MaNV == maNV) { luongCB = nv.LuongCB; break; }
                    }
            
                    return bcc.TinhLuongThucNhan(luongCB);
                }   
            }
            return 0;
        }

        public bool KhoaTaiKhoan(string tenDangNhap)
        {
            foreach (TaiKhoan tk in danhSachTaiKhoan)
            {
                if (tk.TenDangNhap == tenDangNhap)
                {
                    tk.TrangThai = false; // Vô hiệu hóa tài khoản
                    return true;
                }
            }
            return false;
        }
    }
}