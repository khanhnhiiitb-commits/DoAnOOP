using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;


namespace QuanLySieuThi.Services
{
    public class QuanLyNhapHang
    {
        private List<PhieuNhap> danhSachPhieuNhap;


        public QuanLyNhapHang()
        {
            this.danhSachPhieuNhap = new List<PhieuNhap>();
        }


        public PhieuNhap LapPhieuNhap(NhaCungCap ncc)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaNCC = ncc.MaNCC;
            pn.NgayTao = System.DateTime.Now;
            this.danhSachPhieuNhap.Add(pn);
            return pn;
        }


        public void ThemChiTietPhieuNhap(PhieuNhap pn, HangHoa hh, int soLuong, int giaNhap)
        {
            ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
            ct.MaHH = hh.MaHH;
            ct.SoLuongNhap = soLuong;
            ct.DonGiaNhap = giaNhap;
           
            pn.DanhSachChiTiet.Add(ct);
            pn.TongTien = TinhTongTien(pn);
        }


        public double TinhTongTien(PhieuNhap pn)
        {
            double tong = 0;
            foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
            {
                tong += (ct.SoLuongNhap * ct.DonGiaNhap);
            }
            return tong;
        }


        public void XacNhanNhapKho(PhieuNhap pn)
        {
            pn.TrangThai = "DaNhapKho";
            QuanLyKho.CapNhatSoLuong(ct.MaHang, ct.SoLuongNhap);
        }


        public void CapNhatGiaNhap(string maHH, double giaMoi)
        {
            foreach (PhieuNhap pn in danhSachPhieuNhap)
            {
                foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
                {
                    if (ct.MaHang == maHH)
                    {
                        ct.DonGiaNhap = (int)giaMoi;
                    }
                }
            }
        }


        public void HuyPhieuNhap(string maPN)
        {
            for (int i = 0; i < danhSachPhieuNhap.Count; i++)
            {
                if (danhSachPhieuNhap[i].MaPN == maPN)
                {
                    danhSachPhieuNhap.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

