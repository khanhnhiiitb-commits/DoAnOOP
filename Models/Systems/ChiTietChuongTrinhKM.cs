namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietChuongTrinhKM
    {
        private string maCTKM;
        private string maMH;
        private double phanTramGiam;
        public string MaCTKM { get { return maCTKM; }set { maCTKM = value; }}
        public string MaMH {  get { return maMH; }set { maMH = value; } }
        public double PhanTramGiam
        { get { return phanTramGiam; }
            set 
            {
                if (value >= 0 && value <= 100) phanTramGiam = value;
                else phanTramGiam = 0; 
            }
        }
        // Constructor 
        public ChiTietChuongTrinhKM() { }    
        public ChiTietChuongTrinhKM(string maKM, string maMH, double giam)
        {
            this.MaCTKM = maKM;
            this.MaMH = maMH;
            this.PhanTramGiam = giam;
        }
    }
}