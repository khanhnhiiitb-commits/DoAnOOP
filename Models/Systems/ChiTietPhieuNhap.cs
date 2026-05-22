namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietPhieuNhap
    {
        private string maPN;
        private string maHH;
        private int soLuong;
        private double donGia;

        // Properties
        public string MaPN { get { return maPN; } set { maPN = value; } }
        public string MaHH { get { return maHH; }  set { maHH = value; }   }
        public int SoLuong
        {
            get { return soLuong; }
            set 
            {
                if (value >= 0) soLuong = value;
                else soLuong = 0;
            }
        }
        public double DonGia
        {
            get { return donGia; }
            set
            { 
                if (value >= 0) donGia = value;
                else donGia = 0;
            }
        }
        public double ThanhTien 
        { 
            get   {    return SoLuong * DonGia;   } 
        }
        public ChiTietPhieuNhap() { }
        public ChiTietPhieuNhap(string maPN, string maHH, int sl, double dg)
        {
            this.MaPN = maPN;
            this.MaHH = maHH;
            this.SoLuong = sl;
            this.DonGia = dg;
        }
    }
}