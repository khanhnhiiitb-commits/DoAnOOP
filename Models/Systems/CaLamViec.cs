namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
    {
        // Private Fields (Trường dữ liệu riêng tư)
        private string maCa;
        private string tenCa;
        private string gioBatDau;
        private string gioKetThuc;

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