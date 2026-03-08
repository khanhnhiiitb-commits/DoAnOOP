namespace QuanLySieuThi.Models.Products
{
    // Kế thừa từ HangHoa
    public class HangDienTu : HangHoa
    {
       private int thoiGianBH; // Tinh theo thang
        private string hangSX;

        public int ThoiGianBH 
        { 
            get { return thoiGianBH; } 
            set { thoiGianBH = value; } 
        }
        public string HangSX 
        { 
            get { return hangSX; } 
            set { hangSX = value; } 
        }

        public HangDienTu(string ma, string ten, double gia, int ton, string make, string donvi, int baoHanh, string hang) 
            : base(ma, ten, gia, ton, make, donvi)
        {
            this.thoiGianBH = baoHanh;
            this.hangSX = hang;
        }
    }
}