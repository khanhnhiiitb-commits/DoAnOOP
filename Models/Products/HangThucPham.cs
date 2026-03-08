namespace QuanLySieuThi.Models.Products
{
    // Kế thừa từ HangHoa
    public class HangThucPham : HangHoa
    {
        private DateTime ngaySX;
        private DateTime hSD;

        public DateTime NgaySX
        { 
            get { return ngaySX; } 
            set { ngaySX = value; } 
        }
        public DateTime HSD 
        { 
            get { return hSD; } 
            set { hSD = value; } 
        }

        public HangThucPham(string ma, string ten, double gia, int ton, string make, string donvi, DateTime nsx, DateTime hsd) : base(ma, ten, gia, ton, make, donvi)
        {
            this.ngaySX = nsx;
            this.hSD = hsd;
        }
    }
}