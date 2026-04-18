using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Products;

namespace QuanLySieuThi.Services
{
    public class BaoCaoThongKe
    {
        private List<HoaDon> _danhSachHoaDon;
        private List<HangHoa> _danhSachHangHoa;

        public BaoCaoThongKe(List<HoaDon> hoaDons, List<HangHoa> hangHoas)
        {
            _danhSachHoaDon = hoaDons;
            _danhSachHangHoa = hangHoas;
        }

        // 1. Tính doanh thu theo ngày
        public double TinhDoanhThuTheoNgay(DateTime ngay)
        {
            double tong = 0;
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                // Kiểm tra cùng ngày, tháng, năm và đã thanh toán
                if (hd.NgayTao.Date == ngay.Date && hd.TrangThaiTT == true)
                {
                    tong += hd.TongTien;
                }
            }
            return tong;
        }

        // 2. Tính doanh thu theo tháng
        public double TinhDoanhThuTheoThang(int thang, int nam)
        {
            double tong = 0;
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                if (hd.NgayTao.Month == thang && hd.NgayTao.Year == nam && hd.TrangThaiTT == true)
                {
                    tong += hd.TongTien;
                }
            }
            return tong;
        }

        // 3. Thống kê hóa đơn theo khoảng thời gian
        public List<HoaDon> ThongKeHoaDonTheoKhoang(DateTime tuNgay, DateTime denNgay)
        {
            List<HoaDon> ketQua = new List<HoaDon>();
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                if (hd.NgayTao.Date >= tuNgay.Date && hd.NgayTao.Date <= denNgay.Date)
                {
                    ketQua.Add(hd);
                }
            }
            return ketQua;
        }

        // 4. Thống kê tồn kho
        public List<HangHoa> LayDanhSachTonKho()
        {
            return _danhSachHangHoa; // Trả về nguyên list để WinForms tự hiển thị
        }

        // 5. Danh sách hàng sắp hết (Ví dụ: dưới 10 sản phẩm)
        public List<HangHoa> DanhSachHangSapHet()
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            foreach (HangHoa h in _danhSachHangHoa)
            {
                if (h.SoLuongTon < 10)
                {
                    ketQua.Add(h);
                }
            }
            return ketQua;
        }
    }
}