using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Products; 
using QuanLySieuThi.Models.Sales; 
using QuanLySieuThi.Models.Systems;
using ChuongtrinhQuanlybanhangsieuthi.DataAccess;

namespace QuanLySieuThi.Services
{
    public class QuanLyNhapHang
    {
        private List<PhieuNhap> danhSachPhieuNhap;
        public List<PhieuNhap> DanhSachPhieuNhap  {  get { return danhSachPhieuNhap; }  }

        public QuanLyNhapHang(List<PhieuNhap> dsPN)
        {
            this.danhSachPhieuNhap = dsPN;
        }
        public PhieuNhap LapPhieuNhap(NhaCungCap ncc)
        {
            if (ncc == null) return null;
            string maMoi = "PN" + (danhSachPhieuNhap.Count + 1).ToString("D3");
            PhieuNhap pn = new PhieuNhap(maMoi, ncc, DateTime.Now, 0);
            danhSachPhieuNhap.Add(pn);
            return pn;
        }
        public void ThemChiTietPhieuNhap(PhieuNhap pn, HangHoa hh, int soLuong, double giaNhap)
        {
            if (pn != null && hh != null)
            {
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap(pn.MaPN, hh.MaHH, soLuong, giaNhap);
                pn.ThemChiTiet(ct);
            }
        }
        public void XacNhanNhapKho(PhieuNhap pn, QuanLyKho serviceKho)
        {
            if (pn != null && pn.TrangThai == "ChoXacNhan")
            {
                foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
                {
                    serviceKho.CapNhatSoLuong(ct.MaHH, ct.SoLuong);
                    CapNhatGiaNhap(ct.MaHH, ct.DonGia, serviceKho);
                }
                pn.XacNhanNhapKho();
            }
        }
        public void CapNhatGiaNhap(string maHH, double giaMoi, QuanLyKho serviceKho)
        {
            List<HangHoa> ketQua = serviceKho.TimKiemHangHoa(maHH);
            foreach (HangHoa hh in ketQua)
            {
                if (hh.MaHH == maHH)
                {
                    hh.DonGia = giaMoi; // Cập nhật giá vốn mới
                    break;
                }
            }
        }
        public bool HuyPhieuNhap(string maPN)
        {
            for (int i = 0; i < danhSachPhieuNhap.Count; i++)
            {
                if (danhSachPhieuNhap[i].MaPN == maPN)
                {
                    if (danhSachPhieuNhap[i].TrangThai == "ChoXacNhan")
                    {
                        danhSachPhieuNhap[i].HuyDonPhieu();
                        return true;
                    }
                }
            }
            return false;
        }

        public void LuuDuLieuPhieuNhap()
        {
            PhieuNhapRepository repo = new PhieuNhapRepository();
            repo.Save(this.danhSachPhieuNhap);
        }
    }
}