namespace QuanLySieuThi.Models.Systems
{
    public class TaiKhoan
    {
       public string TenDangNhap { get; set; }    // Username
        public string MatKhau { get; set; }        // Password
        public string MaNV { get; set; }           // Liên kết với mã nhân viên
        public string LoaiTaiKhoan { get; set; }    // Ví dụ: "Admin", "NhanVien"
        public bool TinhTrang { get; set; }        // True: Hoạt động, False: Bị khóa

        public TaiKhoan() { }

        public TaiKhoan(string user, string pass, string maNV, string loai, bool status = true)
        {
            TenDangNhap = user;
            MatKhau = pass;
            MaNV = maNV;
            LoaiTaiKhoan = loai;
            TinhTrang = status;
        }

        // Phương thức kiểm tra đăng nhập cơ bản
        public bool KiemTraDangNhap(string user, string pass)
        {
            return (TenDangNhap == user && MatKhau == pass && TinhTrang == true);
        }
    }
}