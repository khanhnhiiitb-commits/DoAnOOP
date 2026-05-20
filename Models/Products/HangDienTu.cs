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
            set
            {
                if (value >= 0) thoiGianBH = value;
                else thoiGianBH = 0;
            } 
        }
        public string HangSX { get { return hangSX; } set { hangSX = value; } }
        public HangDienTu() : base() { }
        public HangDienTu(string ma, string ten, double gia, int ton, string make, string donvi, int baoHanh, string hang) 
            : base(ma, ten, gia, ton, make, donvi)
        {
            this.ThoiGianBH = baoHanh;
            this.HangSX = hang;
        }
        public override bool KiemTraChatLuong()
        {
            return thoiGianBH > 0;
        }
    }
}