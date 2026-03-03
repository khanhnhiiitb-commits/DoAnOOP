namespace QuanLySieuThi.Systems
{
    public class ChiTietPhieuNhap
    {
   public string MaPN { get; set; }       
        public string MaMH { get; set; }       
        public int SoLuong { get; set; }       
        public double DonGia { get; set; }     
        
        // Thành tiền = Số lượng * Đơn giá
        public double ThanhTien 
        { 
            get { return SoLuong * DonGia; } 
        }

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(string maPN, string maMH, int soLuong, double donGia)
        {
            MaPN = maPN;
            MaMH = maMH;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}