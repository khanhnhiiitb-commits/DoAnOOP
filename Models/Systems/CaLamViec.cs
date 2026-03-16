namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
    {//sua
        private string MaCa { get; set; }
        private string TenCa { get; set; }
        private string GioBatDau { get; set; }
        private string GioKetThuc { get; set; }

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