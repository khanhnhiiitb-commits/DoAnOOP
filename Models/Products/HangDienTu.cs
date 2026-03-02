namespace QuanLySieuThi.Models
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

        public HangDienTu(string ma, string ten, double gia, int ton, int baoHanh, string hang) 
            : base(ma, ten, gia, ton)
        {
            this.thoiGianBH = baoHanh;
            this.hangSX = hang;
        }
    }
}