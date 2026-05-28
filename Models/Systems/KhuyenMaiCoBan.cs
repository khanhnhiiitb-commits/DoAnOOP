using QuanLySieuThi.Models.Sales;
using System;

namespace QuanLySieuThi.Models.Systems
{
    public class KhuyenMaiCoBan : ChuongTrinhKhuyenMai
    {
        // Bổ sung 2 trường dữ liệu thực tế cho một chương trình khuyến mãi
        private double giaTriHoaDonToiThieu;
        private double phanTramGiamGia;

        // Đóng gói dữ liệu khắt khe
        public double GiaTriHoaDonToiThieu
        {
            get { return giaTriHoaDonToiThieu; }
            set
            {
                if (value >= 0) giaTriHoaDonToiThieu = value;
                else giaTriHoaDonToiThieu = 0;
            }
        }

        public double PhanTramGiamGia
        {
            get { return phanTramGiamGia; }
            set
            {
                if (value >= 0 && value <= 100) phanTramGiamGia = value;
                else phanTramGiamGia = 0;
            }
        }

        public KhuyenMaiCoBan() : base() { }

        // Constructor đầy đủ
        public KhuyenMaiCoBan(string maKM, string ten, DateTime bd, DateTime kt, string nd, double dkToiThieu, double phanTram)
            : base(maKM, ten, bd, kt, nd)
        {
            this.GiaTriHoaDonToiThieu = dkToiThieu;
            this.PhanTramGiamGia = phanTram;
        }

        // TÍNH ĐA HÌNH ĐƯỢC THỂ HIỆN RÕ RÀNG:
        // Hóa đơn chỉ đạt điều kiện nếu tổng tiền hiện tại vượt mức yêu cầu
        public override bool KiemTraDieuKien(HoaDon hd)
        {
            if (hd != null && hd.TongTien >= giaTriHoaDonToiThieu)
            {
                return true;
            }
            return false;
        }

        // Tính tiền giảm dựa trên phần trăm, không còn trả về 0 vô nghĩa
        public override double TinhSoTienGiam(double tongTienHD)
        {
            if (tongTienHD >= giaTriHoaDonToiThieu)
            {
                return tongTienHD * (phanTramGiamGia / 100);
            }
            return 0;
        }
    }
}