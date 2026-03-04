namespace QuanLySieuThi.Systems
{
    public class ChiTietPhieuNhap
    {
   public string MaPN { get; set; }
        public string MaMH { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public double ThanhTien 
        { 
            get 
            { 
                return SoLuong * DonGia; 
            } 
        }

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(string maPN, string maMH, int sl, double dg)
        {
            MaPN = maPN;
            MaMH = maMH;
            SoLuong = sl;
            DonGia = dg;
        }
    }
}