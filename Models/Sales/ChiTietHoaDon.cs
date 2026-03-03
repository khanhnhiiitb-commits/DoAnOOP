namespace QuanLySieuThi.Models
{
    public class ChiTietHoaDon
    {
        private string maChiTiet;
        private string maHoaDon;
        private string maHang;
        private int soLuong;
        private double donGia;
        private double thanhTien;

        public string MaChiTiet
        {
            get { return maChiTiet; }
            set { maChiTiet = value; }
        }

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                soLuong = value;
                TinhThanhTien();
            }
        }

        public double DonGia
        {
            get { return donGia; }
            set
            {
                donGia = value;
                TinhThanhTien();
            }
        }

        public double ThanhTien
        {
            get { return thanhTien; }
            private set { thanhTien = value; }
        }

        public ChiTietHoaDon()
        {
            soLuong = 0;
            donGia = 0;
            thanhTien = 0;
        }

        private void TinhThanhTien()
        {
            thanhTien = soLuong * donGia;
        }
    }
}