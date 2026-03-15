namespace QuanLySieuThi.Models.Systems
{
    public class TaiKhoan
    {
     
        private string tenDangNhap;
        private string matKhau;
        private string vaiTro;
        private bool trangThai;

    
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

        public string VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        // Constructor mặc định
        public TaiKhoan() { }

        public TaiKhoan(string tenDN, string matKhau, string vaiTro, bool trangThai)
        {
            this.tenDangNhap = tenDN;
            this.matKhau = matKhau;
            this.vaiTro = vaiTro;
            this.trangThai = trangThai;
        }
    }
}