namespace QuanLySieuThi.Systems
{
    public class ChiTietPhieuNhap
    {
<<<<<<< HEAD
        private string maPN;
        private string maHH;
        private int soLuong;
        private double donGia;

        public string MaPN { get {return maPN;} set {maPN = value;} }
        public string MaHH { get {return maHH;} set {maHH = value;} }
        public int SoLuong { get {return soLuong;} set {soLuong = value;} }
        public double DonGia { get {return donGia;} set {donGia;} }
=======
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
>>>>>>> 1c50ed41b2c3072aa0c0c13d75b4afb9211f2b03

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