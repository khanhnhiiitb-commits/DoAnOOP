namespace QuanLySieuThi.Models
{
    public class HoaDon
    {
         private string maHoaDon;
        private DateTime ngayTao;
        private string maNhanVien;
        private string maKhachHang;
        private double tongTien;
        private List<ChiTietHoaDon> danhSachChiTiet;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        public DateTime NgayTao
        {
            get { return ngayTao; }
            set { ngayTao = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            private set { tongTien = value; }
        }

        public List<ChiTietHoaDon> DanhSachChiTiet
        {
            get { return danhSachChiTiet; }
        }

        public HoaDon()
        {
            danhSachChiTiet = new List<ChiTietHoaDon>();
            tongTien = 0;
        }

        public void ThemChiTiet(ChiTietHoaDon chiTiet)
        {
            danhSachChiTiet.Add(chiTiet);
            TinhTongTien();
        }

        public void TinhTongTien()
        {
            tongTien = 0;
            for (int i = 0; i < danhSachChiTiet.Count; i++)
            {
                tongTien = tongTien + danhSachChiTiet[i].ThanhTien;
            }
        }
    }
}