using System;
using System.Collections.Generic;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Models.Sales;


namespace QuanLySieuThi.Services
{
    public class QuanLyDoiTac
    {
        private List<KhachHang> danhSachKH;
        private List<NhaCungCap> danhSachNCC;


        public QuanLyDoiTac()
        {
            this.danhSachKH = new List<KhachHang>();
            this.danhSachNCC = new List<NhaCungCap>();
        }


        public void ThemKhachHang(KhachHang kh)
        {
            if (kh != null)
            {
                this.danhSachKH.Add(kh);
            }
        }


        public void DangKyThanhVien(KhachHang kh)
        {
            kh.LoaiKhachHang = "ThanhVien";
            kh.DiemTichLuy = 0;
        }


        public void TichDiem(string maKH, double tongTien)
        {
            foreach (KhachHang kh in danhSachKH)
            {
                if (kh.MaKH == maKH)
                {
                    // Ví dụ: 10,000đ được 1 điểm
                    kh.DiemTichLuy += (int)(tongTien / 10000);
                    break;
                }
            }
        }


        public void TruDiem(string maKH, int diemDoi)
        {
            foreach (KhachHang kh in danhSachKH)
            {
                if (kh.MaKH == maKH && kh.DiemTichLuy >= diemDoi)
                {
                    kh.DiemTichLuy -= diemDoi;
                    break;
                }
            }
        }


        public void ThemNhaCungCap(NhaCungCap ncc)
        {
            if (ncc != null)
            {
                this.danhSachNCC.Add(ncc);
            }
        }


        public void CapNhatThongTinNCC(string maNCC, NhaCungCap nccMoi)
        {
            for (int i = 0; i < danhSachNCC.Count; i++)
            {
                if (danhSachNCC[i].MaNCC == maNCC)
                {
                    danhSachNCC[i] = nccMoi;
                    break;
                }
            }
        }
    }
}

