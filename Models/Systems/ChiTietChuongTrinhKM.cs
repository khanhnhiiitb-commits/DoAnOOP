namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietChuongTrinhKM
    {
       public string MaCTKM { get; set; }        
        public string MaMH { get; set; }          
        public double PhanTramGiam { get; set; }  
        public string GhiChu { get; set; }         

        public ChiTietChuongTrinhKM() { }

        public ChiTietChuongTrinhKM(string maCT, string maMH, double giamGia)
        {
            MaCTKM = maCT;
            MaMH = maMH;
            PhanTramGiam = giamGia;
        }

        // Phương thức tính giá sau khi giảm
        public double TinhGiaSauGiam(double giaGoc)
        {
            return giaGoc * (1 - PhanTramGiam);
        }
    }
}