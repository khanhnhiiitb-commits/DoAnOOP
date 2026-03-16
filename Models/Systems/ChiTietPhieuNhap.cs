namespace QuanLySieuThi.Systems
{
    public class ChiTietPhieuNhap
    {
        private string maPN;
        private string maMH;
        private int soLuong;
        private double donGia;

        public string MaPN { get {return maPN;} set {maPN = value;} }
        public string MaHH { get {return maHH;} set {maHH = value;} }
        public string SoLuong { get {return soLuong;} set {soLuong = value;} }
        public string DonGia { get {return donGia;} set {donGia} }

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(string maPN, string maMH, int sl, double dg)
        {
            this.maPN = maPN;
            this.maMH = maMH;
            this.soLuong = sl;
            this.donGia = dg;
        }
    }
}