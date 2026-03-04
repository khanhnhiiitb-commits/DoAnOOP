namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
    {
        public string MaCa { get; set; }
        public string TenCa { get; set; }
        public string GioBatDau { get; set; }
        public string GioKetThuc { get; set; }

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