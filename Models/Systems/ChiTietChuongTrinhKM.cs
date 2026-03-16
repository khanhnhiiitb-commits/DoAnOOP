namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietChuongTrinhKM
    {//sua
       public string MaCTKM { get; set; }
        public string MaMH { get; set; }
        public double PhanTramGiam { get; set; } // Ví dụ: 0.1 tương ứng 10%

        public ChiTietChuongTrinhKM() { }

        public ChiTietChuongTrinhKM(string maKM, string maMH, double giam)
        {
            MaCTKM = maKM;
            MaMH = maMH;
            PhanTramGiam = giam;
        }
    }
}