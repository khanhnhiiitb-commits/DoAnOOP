namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietChuongTrinhKM
    {
    
        private string maCTKM;
        private string maMH;
        private double phanTramGiam;

    
        public string MaCTKM
        {
            get { return maCTKM; }
            set { maCTKM = value; }
        }

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }

        public double PhanTramGiam
        {
            get { return phanTramGiam; }
            set 
            { 
                // Logic kiểm tra: Phần trăm giảm giá không được âm
                if (value >= 0) 
                    phanTramGiam = value; 
            }
        }

        // Constructor 
        public ChiTietChuongTrinhKM() { }

     
        public ChiTietChuongTrinhKM(string maKM, string maMH, double giam)
        {
            this.maCTKM = maKM;
            this.maMH = maMH;
            this.phanTramGiam = giam;
        }
    }
}