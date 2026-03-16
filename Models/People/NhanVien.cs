namespace QuanLySieuThi.Models.People
{
    public class NhanVien : Nguoi
    {
        private string maNV;
        private string chucVu;
        private double luongCB;
        private DateTime ngayVaoLam;
        private string maCaLV;

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

        public string MaCaLV 
        { 
            get { return maCaLV; } 
            set { maCaLV = value; } 
        }
    }
}