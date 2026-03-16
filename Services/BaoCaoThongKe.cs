using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;


namespace QuanLySieuThi.Services
{
    public class BaoCaoThongKe
    {
        public double TinhDoanhThuTheoNgay(DateTime ngay, List<HoaDon> dsHoaDon)
        {
            double tongDoanhThu = 0;
            foreach (HoaDon hd in dsHoaDon)
            {
                if (hd.NgayTao.Date == ngay.Date)
                {
                    tongDoanhThu += hd.TongTien;
                }
            }
            return tongDoanhThu;
        }


        public double TinhDoanhThuTheoThang(int thang, int nam, List<HoaDon> dsHoaDon)
        {
            double tongDoanhThu = 0;
            foreach (HoaDon hd in dsHoaDon)
            {
                if (hd.NgayTao.Month == thang && hd.NgayTao.Year == nam)
                {
                    tongDoanhThu += hd.TongTien;
                }
            }
            return tongDoanhThu;
        }


        public List<HoaDon> ThongKeHoaDonTheoKhoang(DateTime tuNgay, DateTime denNgay, List<HoaDon> dsHoaDon)
        {
            List<HoaDon> ketQua = new List<HoaDon>();
            foreach (HoaDon hd in dsHoaDon)
            {
                if (hd.NgayTao.Date >= tuNgay.Date && hd.NgayTao.Date <= denNgay.Date)
                {
                    ketQua.Add(hd);
                }
            }
            return ketQua;
        }


        public List<HangHoa> ThongKeSanPhamBanChay(List<HoaDon> dsHoaDon, List<HangHoa> dsTatCaHang)
        {
            int[] mangSoLuongBan = new int[dsTatCaHang.Count];


            foreach (HoaDon hd in dsHoaDon)
             {
                foreach (ChiTietHoaDon ct in hd.DanhSachChiTiet)
                {
                    for (int i = 0; i < dsTatCaHang.Count; i++)
                    {
                         if (dsTatCaHang[i].MaHH == ct.MaHH)
                        {
                          mangSoLuongBan[i] += ct.SoLuongMua;
                          break;
                         }
                    }
                }
            }


            for (int i = 0; i < dsTatCaHang.Count - 1; i++)
            {
                for (int j = i + 1; j < dsTatCaHang.Count; j++)
                {
                    if (mangSoLuongBan[i] < mangSoLuongBan[j])
                    {
                        int tempSl = mangSoLuongBan[i];
                        mangSoLuongBan[i] = mangSoLuongBan[j];
                        mangSoLuongBan[j] = tempSl;
                        HangHoa tempHh = dsTatCaHang[i];
                        dsTatCaHang[i] = dsTatCaHang[j];
                        dsTatCaHang[j] = tempHh;
                    }
                }
            }


            return dsTatCaHang;
        }


        public double ThongKeTonKho(List<HangHoa> dsHang)
        {
            double tongGiaTri = 0;
            foreach (HangHoa hh in dsHang)
            {
                tongGiaTri += (hh.SoLuongTon * hh.DonGia);
            }
            return tongGiaTri;
        }


        public List<HangHoa> DanhSachHangSapHet(QuanLyKho kho)
        {
            return kho.LayDSHangSapHet();
        }
    }
}

