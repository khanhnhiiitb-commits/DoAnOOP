using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Products;

namespace QuanLySieuThi.Services
{
    public class QuanLyKho
    {
        private List<HangHoa> danhSachHang;
        private List<KeHang> danhSachKe;
        public List<HangHoa> DanhSachHang  { get { return danhSachHang; }  }
        public List<KeHang> DanhSachKe  {  get { return danhSachKe; } }
        public QuanLyKho(List<HangHoa> dsHang, List<KeHang> dsKe)
        {
            this.danhSachHang = dsHang;
            this.danhSachKe = dsKe;
        }
        public void ThemHangHoa(HangHoa hh)
        {
            if (hh != null)  {  danhSachHang.Add(hh); }
        }
        public bool CapNhatThongTin(string maHH, HangHoa hhMoi)
        {
            for (int i = 0; i < danhSachHang.Count; i++)
            {
                if (danhSachHang[i].MaHH == maHH)
                {
                    danhSachHang[i].TenHang = hhMoi.TenHang;
                    danhSachHang[i].DonGia = hhMoi.DonGia;
                    danhSachHang[i].DonViTinh = hhMoi.DonViTinh;
                    return true;
                }
            }
            return false;
        }
        public bool XuatHangHoa(string maHH)
        {
            for (int i = 0; i < danhSachHang.Count; i++)
            {
                if (danhSachHang[i].MaHH == maHH)
                {
                    danhSachHang.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public List<HangHoa> TimKiemHangHoa(string keyword)
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            string tuKhoaThuong = keyword.ToLower();
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH.ToLower().Contains(tuKhoaThuong) || hh.TenHang.ToLower().Contains(tuKhoaThuong))
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
            return 0; // Không tìm thấy hàng
        }
        public bool CapNhatSoLuong(string maHH, int soLuongThayDoi)
        {
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH)
                {
                    hh.SoLuongTon += soLuongThayDoi;
                    return true;
                }
            }
            return false;
        }
        public bool SapXepKeHang(string maHH, string maKe)
        {
            HangHoa hangTimThay = null;
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH) { hangTimThay = hh; break; }
            }
            KeHang keTimThay = null;
            foreach (KeHang ke in danhSachKe)
            {
                if (ke.MaKe == maKe) { keTimThay = ke; break; }
            }

            if (hangTimThay != null && keTimThay != null)
            {
                keTimThay.ThemHangHoa(hangTimThay); // Gán mã kệ vào hàng hóa
                return true;
            }
            return false;
        }
        public List<HangHoa> LayDSHangSapHet()
        {
            List<HangHoa> dsSapHet = new List<HangHoa>();
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.SoLuongTon < 10) { dsSapHet.Add(hh);  }
            }
            return dsSapHet;
        }
    }
}