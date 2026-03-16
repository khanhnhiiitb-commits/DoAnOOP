namespace QuanLySieuThi.Models.Systems
{
    public class ChiTietChuongTrinhKM
<<<<<<< HEAD
    {//sua
       public string MaCTKM { get; set; }
        public string MaMH { get; set; }
        public double PhanTramGiam { get; set; } // Ví dụ: 0.1 tương ứng 10%
=======
    {
    
        private string maCTKM;
        private string maMH;
        private double phanTramGiam;
>>>>>>> 1c50ed41b2c3072aa0c0c13d75b4afb9211f2b03

    
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