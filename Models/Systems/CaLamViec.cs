namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
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

        public CaLamViec() { }

        public CaLamViec(string maCa, string tenCa, string batDau, string ketThuc)
        {
            MaCa = maCa;
            TenCa = tenCa;
            GioBatDau = batDau;
            GioKetThuc = ketThuc;
        }
    }
}