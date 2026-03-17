namespace QuanLySieuThi.Models.Systems
{//sua
    public class TaiKhoan
    {
     
        private string tenDangNhap;
        private string matKhau;
        private bool trangThai;
        private Role userRole;



    
        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public Role UserRole    
        {
            get { return userRole; }
            set { userRole = value; }
        }

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        // Constructor mặc định
        public TaiKhoan() { }

        public TaiKhoan(string tenDN, string matKhau, Role role, bool trangThai = true)
        {
            this.tenDangNhap = tenDN;
            this.matKhau = matKhau;
            this.userRole = role;
            this.trangThai = trangThai;
        }

        public bool KiemTraMatKhau(string mk)
        {
            // Kiểm tra xem mật khẩu nhập vào có khớp với mật khẩu lưu trữ không
            return this.matKhau == mk;
        }
    }
}