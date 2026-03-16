namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
<<<<<<< HEAD
    {//sua
        private string maCa { get; set; }
        private string tenCa { get; set; }
        private string gioBatDau { get; set; }
        private string gioKetThuc { get; set; }

        public string MaCa 
        {
            get {return maCa;}
            set { maCa = value;}
        }

        public string TenCa 
        {
            get {return TenCa;}
            set { TenCa = value;}
        }

        public string GioBatDau 
        {
            get {return GioBatDau;}
            set { GioBatDau = value;}
        }

        public string GioKetThuc 
        {
            get {return GioKetThuc;}
            set { GioKetThuc = value;}
        }
=======
    {
        // Private Fields (Trường dữ liệu riêng tư)
        private string maCa;
        private string tenCa;
        private string gioBatDau;
        private string gioKetThuc;
>>>>>>> 1c50ed41b2c3072aa0c0c13d75b4afb9211f2b03

        // Properties 
        public string MaCa
        {
            get { return maCa; }
            set { maCa = value; }
        }

        public string TenCa
        {
            get { return tenCa; }
            set { tenCa = value; }
        }

        public string GioBatDau
        {
            get { return gioBatDau; }
            set { gioBatDau = value; }
        }

        public string GioKetThuc
        {
            get { return gioKetThuc; }
            set { gioKetThuc = value; }
        }

        // Constructor 
        public CaLamViec() { }

        public CaLamViec(string maCa, string tenCa, string batDau, string ketThuc)
        {
            this.maCa = maCa;
            this.tenCa = tenCa;
            this.gioBatDau = batDau;
            this.gioKetThuc = ketThuc;
        }
    
    }
}