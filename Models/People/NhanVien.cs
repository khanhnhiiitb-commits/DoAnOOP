using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Models.People
{
    public class NhanVien : Nguoi
    {
    
        private string chucVu;
        private double luongCB;
        private DateTime ngayVaoLam;
        private string maCa;
        private TaiKhoan taikhoan;
        public TaiKhoan Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public string ChucVu 
        { 
            get { return chucVu; } 
            set { chucVu = value; } 
        }
        public double LuongCB 
        { 
            get { return luongCB; } 
            set {
                if (value >= 0)
                {
                    luongCB = value;
                }
                else
                {
                    luongCB = 0;
                }
            } 
        }
        public DateTime NgayVaoLam 
        { 
            get { return ngayVaoLam; } 
            set { ngayVaoLam = value; } 
        }
        public string MaCa
        { 
            get { return maCa; } 
            set { maCa = value; } 
        }

        public NhanVien() : base() { }
        public NhanVien(string ma, string ten, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi, string chucVu) 
        : base(ma, ten, ngaySinh, gioiTinh, soDienThoai, diaChi) 
        {
            this.ChucVu = chucVu;
            this.NgayVaoLam = DateTime.Now; 
            this.LuongCB = 0; 
        }
    }
}                                           