namespace QuanLySieuThi.Models.Products
{
    public abstract class HangHoa 
    {
       private string maHH;
        private string tenHang;
        private double donGia;
        private int soLuongTon;
        private string maKeHang;
        private string donViTinh;

        // Properties 
        public string MaHH 
        { 
            get { return maHH; } 
            set { maHH = value; } 
        }
        public string TenHang 
        { 
            get { return tenHang; } 
            set { tenHang = value; } 
        }
        public double DonGia 
        { 
            get { return donGia; } 
            set { if (value >= 0) donGia = value; } 
        }
        public int SoLuongTon 
        { 
            get { return soLuongTon; } 
            set { if (value >= 0) soLuongTon = value; } 
        }
        public string MaKeHang 
        { 
            get { return maKeHang; } 
            set { maKeHang = value; } 
        }
        public string DonViTinh
        { 
            get { return donViTinh; } 
            set { donViTinh = value; } 
        }

        // Constructor 

        public HangHoa(){}

        public HangHoa(string ma, string ten, double gia, int ton, string make, string donvi)
        {
            this.maHH = ma;
            this.tenHang = ten;
            this.donGia = gia;
            this.soLuongTon = ton;
            this.maKeHang = make;
            this.donViTinh = donvi;
        }

        public abstract bool KiemTraChatLuong();
    }
}
