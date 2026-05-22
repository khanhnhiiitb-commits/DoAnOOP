namespace QuanLySieuThi.Models.Systems
{//sua
    public class TaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;
        private bool trangThai;
        private Role userRole;
        public string TenDangNhap {  get { return tenDangNhap; } set { tenDangNhap = value; }  }
        public string MatKhau  {  get { return matKhau; } set { matKhau = value; } }
        public Role UserRole     { get { return userRole; } set { userRole = value; }  }
        public bool TrangThai {  get { return trangThai; }  set { trangThai = value; } }
        public string TenTrangThai
        {
            get
            {
                if (trangThai == true)
                    return "Hoạt động";
                else
                    return "Bị khóa";
            }
        }
        public TaiKhoan() { }
        public TaiKhoan(string tenDN, string matKhau, Role role, bool trangThai = true)
        {
            this.TenDangNhap = tenDN;
            this.MatKhau = matKhau;
            this.UserRole = role;
            this.TrangThai = trangThai;
        }
        public bool KiemTraMatKhau(string mk)  { return this.matKhau == mk;}
    }
}