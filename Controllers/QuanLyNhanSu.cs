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
        public List<NhanVien> DanhNV  {  get { return danhNV; } }
        public List<BangChamCong> DanhSachChamCong  {  get { return danhSachChamCong; }  }
        public List<TaiKhoan> DanhSachTaiKhoan { get { return danhSachTaiKhoan; }  }
        public QuanLyNhanSu(List<NhanVien> dsNV, List<BangChamCong> dsCC, List<TaiKhoan> dsTK)
        {
            this.danhNV = dsNV;
            this.danhSachChamCong = dsCC;
            this.danhSachTaiKhoan = dsTK;
        }
        public void ThemNhanVien(NhanVien nv)  {  if (nv != null) danhNV.Add(nv); }
        public bool CapNhatThongTinNhanVien(string maNV, NhanVien nvMoi)
        {
            int i;
            for (i = 0; i < danhNV.Count; i++)
            {
                if (danhNV[i].Ma == maNV)
                {
                    danhNV[i].HoTen = nvMoi.HoTen;
                    danhNV[i].SoDienThoai = nvMoi.SoDienThoai;
                    danhNV[i].DiaChi = nvMoi.DiaChi;
                    danhNV[i].ChucVu = nvMoi.ChucVu;
                    danhNV[i].LuongCB = nvMoi.LuongCB;
                    return true;
                }
            }
            return false;
        }
        public bool XoaNhanVien(string maNV)
        {
            int i;
            for (i = 0; i < danhNV.Count; i++)
            {
                if (danhNV[i].Ma == maNV)
                {
                    danhNV.RemoveAt(i);
                    return true;
                }
            }
            return false; 
        }
        public TaiKhoan DangNhap(string tenDangNhap, string matKhau)
        {
            foreach (TaiKhoan tk in danhSachTaiKhoan)
            {
                if (tk.TenDangNhap == tenDangNhap && tk.KiemTraMatKhau(matKhau))
                {
                    if (tk.TrangThai) return tk;
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
            BangChamCong moi = new BangChamCong(maNV, thangNay, namNay, 1, 0, 0, "Mới khởi tạo");
            danhSachChamCong.Add(moi);
        }
        public void ChamCongRa(string maNV)  {   Console.WriteLine("Nhân viên " + maNV + " đã ra về lúc: " + DateTime.Now); }
        public double TinhLuong(string maNV, int thang, int nam)
        {
            foreach (BangChamCong bcc in danhSachChamCong)
            {
                if (bcc.MaNhanVien == maNV && bcc.Thang == thang && bcc.Nam == nam)
                {
                    double luongCB = 0;
                    foreach (NhanVien nv in danhNV)
                    {
                        if (nv.Ma == maNV) { luongCB = nv.LuongCB; break; }
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
                    tk.TrangThai = false; 
                    return true;
                }
            }
            return false;
        }
        public List<NhanVien> TimKiemNhanVien(string tuKhoa)
        {
            List<NhanVien> ketQua = new List<NhanVien>();
            string lowerKey = tuKhoa.ToLower();
            foreach (NhanVien nv in danhNV)
            {
                if (nv.Ma.ToLower().Contains(lowerKey) ||   nv.HoTen.ToLower().Contains(lowerKey) || nv.SoDienThoai.Contains(tuKhoa))
                {
                    ketQua.Add(nv);
                }
            }
            return ketQua;
        }
    }
}