using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Models.People
{
    public class NhanVien : Nguoi
    {
        private string maNV;
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

        public string MaNV 
        { 
            get { return maNV; } 
            set { maNV = value; } 
        }

        public string ChucVu 
        { 
            get { return chucVu; } 
            set { chucVu = value; } 
        }

        public double LuongCB 
        { 
            get { return luongCB; } 
            set { luongCB = value; } 
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
            this.maNV = ma;
            this.chucVu = chucVu;
            this.ngayVaoLam = DateTime.Now; 
            this.luongCB = 0; 
        }
    }
}                                           