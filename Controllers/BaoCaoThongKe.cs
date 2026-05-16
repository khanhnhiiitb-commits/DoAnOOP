using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;

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
            if (tuNgay.Date > denNgay.Date)
            {
                DateTime tempDate = tuNgay;
                tuNgay = denNgay;
                denNgay = tempDate;
            }

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
        public int TinhTongSoDonHang()
        {
            return _danhSachHoaDon.Count;
        }
        public double TinhTongChiPhiNhap(List<PhieuNhap> danhSachPhieuNhap)
        {
            double tong = 0;
            foreach (PhieuNhap pn in danhSachPhieuNhap)
            {
                tong += pn.TongTien;
            }
            return tong;
        }
        public void LayThongSoDashboard(List<PhieuNhap> danhSachPhieuNhap, out double doanhThu, out int donHang, out double chiPhi)
        {
            doanhThu = 0;
            donHang = _danhSachHoaDon.Count;
            chiPhi = 0;

            int thangNay = DateTime.Now.Month;
            int namNay = DateTime.Now.Year;

            // Tính doanh thu tháng hiện tại
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                if (hd.NgayTao.Month == thangNay && hd.NgayTao.Year == namNay && hd.TrangThaiTT)
                {
                    doanhThu += hd.TongTien;
                }
            }

            //Hoàn thành tính toán chi phí thực tế cho tháng hiện tại
            foreach (PhieuNhap pn in danhSachPhieuNhap)
            {
                if (pn.NgayNhap.Month == thangNay && pn.NgayNhap.Year == namNay)
                {
                    chiPhi += pn.TongTien;
                }
            }
        }
        // 9. Lấy Top sản phẩm có doanh thu cao nhất (Duyệt thủ công)
        public List<HangHoaDoanhThu> LayTopSanPhamBanChay(int top)
        {
            List<HangHoaDoanhThu> dsKetQua = new List<HangHoaDoanhThu>();
            foreach (HangHoa hang in _danhSachHangHoa)
            {
                double tongDoanhThuSP = 0;

                foreach (HoaDon hd in _danhSachHoaDon)
                {
                    if (hd.TrangThaiTT)
                    {
                        foreach (ChiTietHoaDon ct in hd.DanhSachChiTiet)
                        {
                            if (ct.MaHH == hang.MaHH)
                            {
                                tongDoanhThuSP += ct.ThanhTien;
                            }
                        }
                    }
                }

                if (tongDoanhThuSP > 0)
                {
                    HangHoaDoanhThu item = new HangHoaDoanhThu();
                    item.TenHang = hang.TenHang;
                    item.DoanhThu = tongDoanhThuSP;
                    dsKetQua.Add(item);
                }
            }
            for (int i = 0; i < dsKetQua.Count - 1; i++)
            {
                for (int j = i + 1; j < dsKetQua.Count; j++)
                {
                    if (dsKetQua[i].DoanhThu < dsKetQua[j].DoanhThu)
                    {
                        HangHoaDoanhThu temp = dsKetQua[i];
                        dsKetQua[i] = dsKetQua[j];
                        dsKetQua[j] = temp;
                    }
                }
            }

            if (dsKetQua.Count > top)
            {
                return dsKetQua.GetRange(0, top);
            }
            return dsKetQua;
        }

        // Lớp phụ để chứa dữ liệu tạm
        public class HangHoaDoanhThu
        {
            public string TenHang { get; set; }
            public double DoanhThu { get; set; }
        }
        // 4. Thống kê tồn kho
        public List<HangHoa> LayDanhSachTonKho()
        {
            return _danhSachHangHoa; 
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