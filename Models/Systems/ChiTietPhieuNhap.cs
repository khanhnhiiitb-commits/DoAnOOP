namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietPhieuNhap
    {
   private string maPN;
        private string maHH;
        private int soLuong;
        private double donGia;

        // Properties
        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { if (value >= 0) soLuong = value; }
        }

        public double DonGia
        {
            get { return donGia; }
            set { if (value >= 0) donGia = value; }
        }

       
        public double ThanhTien 
        { 
            get 
            { 
                return soLuong * donGia; 
            } 
        }

        // Constructor mặc định
        public ChiTietPhieuNhap() { }

        // Constructor đầy đủ tham số
        public ChiTietPhieuNhap(string maPN, string maHH, int sl, double dg)
        {
            this.maPN = maPN;
            this.maHH = maHH;
            this.soLuong = sl;
            this.donGia = dg;
        }
    }
}