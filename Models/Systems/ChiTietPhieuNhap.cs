namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietPhieuNhap
    {
   private string maPN;
        private string maMH;
        private int soLuong;
        private double donGia;

        // Properties
        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
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
        public ChiTietPhieuNhap(string maPN, string maMH, int sl, double dg)
        {
            this.maPN = maPN;
            this.maMH = maMH;
            this.soLuong = sl;
            this.donGia = dg;
        }
    }
}