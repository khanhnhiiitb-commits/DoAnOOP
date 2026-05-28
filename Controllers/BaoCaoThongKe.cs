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
        public double TinhDoanhThuTheoNgay(DateTime ngay)
        {
            double tong = 0;
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                if (hd.NgayTao.Date == ngay.Date && hd.TrangThaiTT == true) { tong += hd.TongTien; }
            }
            return tong;
        }
        public double TinhDoanhThuTheoThang(int thang, int nam)
        {
            double tong = 0;
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                if (hd.NgayTao.Month == thang && hd.NgayTao.Year == nam && hd.TrangThaiTT == true) { tong += hd.TongTien; }
            }
            return tong;
        }
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
                if (hd.NgayTao.Date >= tuNgay.Date && hd.NgayTao.Date <= denNgay.Date) { ketQua.Add(hd); }
            }
            return ketQua;
        }
        public int TinhTongSoDonHang() { return _danhSachHoaDon.Count; }
        public double TinhTongChiPhiNhap(List<PhieuNhap> danhSachPhieuNhap)
        {
            double tong = 0;
            foreach (PhieuNhap pn in danhSachPhieuNhap) { tong += pn.TongTien; }
            return tong;
        }
        public void LayThongSoDashboard(List<PhieuNhap> danhSachPhieuNhap, out double doanhThu, out int donHang, out double chiPhi)
        {
            doanhThu = 0;
            donHang = _danhSachHoaDon.Count;
            chiPhi = 0;
            int thangNay = DateTime.Now.Month;
            int namNay = DateTime.Now.Year;
            foreach (HoaDon hd in _danhSachHoaDon)
            {
                if (hd.NgayTao.Month == thangNay && hd.NgayTao.Year == namNay && hd.TrangThaiTT) { doanhThu += hd.TongTien; }
            }
            foreach (PhieuNhap pn in danhSachPhieuNhap)
            {
                if (pn.NgayNhap.Month == thangNay && pn.NgayNhap.Year == namNay) { chiPhi += pn.TongTien; }
            }
        }
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
                            if (ct.MaHH == hang.MaHH) { tongDoanhThuSP += ct.ThanhTien; }
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
            if (dsKetQua.Count > top) { return dsKetQua.GetRange(0, top); }
            return dsKetQua;
        }
        public class HangHoaDoanhThu
        {
            public string TenHang { get; set; }
            public double DoanhThu { get; set; }
        }
        public List<HangHoa> LayDanhSachTonKho() { return _danhSachHangHoa; }
        public List<HangHoa> DanhSachHangSapHet()
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            foreach (HangHoa h in _danhSachHangHoa)
            {
                if (h.SoLuongTon < 10) { ketQua.Add(h); }
            }
            return ketQua;
        }

        public void LapBaoCaoChiTiet(DateTime tuNgay, DateTime denNgay,
            out int tongSoHoaDon, out double tongDoanhThu, out string tenMatHangBanChay, out List<HoaDon> dsHoaDonTrongKy)
        {
            tongSoHoaDon = 0;
            tongDoanhThu = 0;
            dsHoaDonTrongKy = new List<HoaDon>();
            Dictionary<string, int> boDemSanPham = new Dictionary<string, int>();

            foreach (HoaDon hd in _danhSachHoaDon)
            {
                hd.TinhTongTien(); // Cập nhật lại tiền

                if (hd.NgayTao >= tuNgay && hd.NgayTao <= denNgay && hd.TrangThaiTT == true)
                {
                    tongSoHoaDon++;
                    tongDoanhThu += hd.TongTien;
                    dsHoaDonTrongKy.Add(hd);

                    foreach (ChiTietHoaDon ct in hd.DanhSachChiTiet)
                    {
                        if (boDemSanPham.ContainsKey(ct.MaHH))
                        {
                            boDemSanPham[ct.MaHH] += ct.SoLuongMua;
                        }
                        else
                        {
                            boDemSanPham.Add(ct.MaHH, ct.SoLuongMua);
                        }
                    }
                }
            }

            string maBanChayNhat = "";
            int maxSoLuong = 0;

            foreach (KeyValuePair<string, int> item in boDemSanPham)
            {
                if (item.Value > maxSoLuong)
                {
                    maxSoLuong = item.Value;
                    maBanChayNhat = item.Key;
                }
            }

            tenMatHangBanChay = "Chưa có dữ liệu";
            if (maxSoLuong > 0)
            {
                foreach (HangHoa hh in _danhSachHangHoa)
                {
                    if (hh.MaHH == maBanChayNhat)
                    {
                        tenMatHangBanChay = hh.TenHang;
                        break;
                    }
                }
            }
        }
    }
}