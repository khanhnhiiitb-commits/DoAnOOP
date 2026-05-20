using System;
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
            set{   ngaySX = value;
                if (hSD != DateTime.MinValue && ngaySX > hSD)
                    hSD = ngaySX;
            } 
        }
        public DateTime HSD 
        { 
            get { return hSD; } 
            set 
            {
                hSD = value;
                if (value >= ngaySX) hSD = value;
                else hSD = ngaySX;// Nếu nhập sai, gán mặc định bằng ngày sản xuất
            } 
        }
        public HangThucPham() : base() { }
        public HangThucPham(string ma, string ten, double gia, int ton, string make, string donvi, DateTime nsx, DateTime hsd)
            : base(ma, ten, gia, ton, make, donvi)
        {
            this.NgaySX = nsx;
            this.HSD = hsd;
        }
        public override bool KiemTraChatLuong()
        {
            return DateTime.Now <= HSD;
        }

        public bool KiemTraHetHan()
        {
            return DateTime.Now > HSD;
        }
    }
}