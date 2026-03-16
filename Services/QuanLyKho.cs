using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;
namespace QuanLySieuThi.Services
{
    public class QuanLyKho
    {
        private List<HangHoa> danhSachHang = new List<HangHoa>();
        private List<KeHang> DanhSachKe = new List<KeHang>();


        public QuanLyKho()
        {
            this.danhSachHang = new List<HangHoa>();
            this.danhSachKe = new List<KeHang>();
        }




        public void ThemHangHoa(HangHoa hh)
        {
            if (hh != null)
            {
                this.danhSachHang.Add(hh);
            }
        }


        public void CapNhatThongTin(string MaHH, HangHoa hhMoi)
        {
            for (int i = 0; i < danhSachHang.Count; i++)
            {
                if (danhSachHang[i].MaHang == maHH)
                {
                    danhSachHang[i] = hhMoi;
                    break;
                }
            }
        }


        public void XuatHangHoa(string maHH)
        {
            for (int i = 0; i < danhSachHang.Count; i++)
            {
                if (danhSachHang[i].MaHang == maHH)
                {
                    danhSachHang.RemoveAt(i);
                    break;
                }
            }
        }


        public HangHoa TimKiemHangHoa(string maHH)
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH.Contains(keyword) || hh.TenHang.Contains(keyword))
                {
                    ketQua.Add(hh);
                }
            }
            return ketQua;
        }


        public int KiemTraTonKho(string maHH)
        {
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH)
                {
                    return hh.SoLuongTon;
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy
        }


        public void CapNhatSoLuong(string maHH, int slThayDoi)
        {
           foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH)
                {
                    hh.SoLuongTon += soLuongThayDoi;
                    break;
                }
            }
        }


        public void SapXepKeHang(string maHH, string maKe)
        {
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH)
                {
                    hh.maKe = maKe;
                    break;
                }
            }
        }


        public List<HangHoa> LayDSHangSapHet()
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.SoLuongTon < 10)
                {
                    ketQua.Add(hh);
                }
            }
            return ketQua;
        }
    }
}

