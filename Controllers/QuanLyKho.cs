using System;
using System.Collections.Generic;
using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Data;
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
            DongBoSoLuongKeHang();
        }

        public void DongBoSoLuongKeHang()
        {
            if (this.danhSachKe == null || this.danhSachKe.Count == 0) return;

            for (int i = 0; i < this.danhSachKe.Count; i++)
            {
                this.danhSachKe[i].SoLuongHienTai = 0;
            }
            if (this.danhSachHang == null) return;

            for (int i = 0; i < this.danhSachHang.Count; i++)
            {
                HangHoa hh = this.danhSachHang[i];

                if (!string.IsNullOrEmpty(hh.MaKeHang))
                {
                    for (int j = 0; j < this.danhSachKe.Count; j++)
                    {
                        if (this.danhSachKe[j].MaKe == hh.MaKeHang)
                        {
                            this.danhSachKe[j].SoLuongHienTai += hh.SoLuongTon;
                            break; 
                        }
                    }
                }
            }
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
                    DongBoSoLuongKeHang();
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

        // --- CÁC HÀM QUẢN LÝ KỆ HÀNG ---

        public bool ThemKeHang(KeHang keMoi)
        {
            // Kiểm tra trùng mã
            foreach (KeHang k in this.danhSachKe)
            {
                if (k.MaKe == keMoi.MaKe) return false;
            }
            this.danhSachKe.Add(keMoi);
            return true;
        }

        public bool XoaKeHang(string maKeXoa)
        {
            for (int i = 0; i < this.danhSachKe.Count; i++)
            {
                if (this.danhSachKe[i].MaKe == maKeXoa)
                {
                    this.danhSachKe.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool CapNhatKeHang(string maKeCu, KeHang keUpdate)
        {
            for (int i = 0; i < this.danhSachKe.Count; i++)
            {
                if (this.danhSachKe[i].MaKe == maKeCu)
                {
                    this.danhSachKe[i].ViTri = keUpdate.ViTri;
                    this.danhSachKe[i].LoaiHang = keUpdate.LoaiHang;
                    this.danhSachKe[i].SucChua = keUpdate.SucChua;
                    return true;
                }
            }
            return false;
        }
        public void LapThongKeTonKho(out int tongSKU, out int sapHetKho, out double tongGiaTri)
        {
            tongSKU = this.danhSachHang.Count;
            sapHetKho = 0;
            tongGiaTri = 0;

            foreach (HangHoa hh in this.danhSachHang)
            {
                if (hh.SoLuongTon < 10)
                {
                    sapHetKho++;
                }
                tongGiaTri += (hh.DonGia * hh.SoLuongTon);
            }
        }
        public void LuuDuLieuKeHang()
        {
            KeHangRepository repo = new KeHangRepository();
            repo.Save(this.danhSachKe);
        }
        public void LuuDuLieuKho()
        {
            InventoryRepository inventoryRepo = new InventoryRepository();
            inventoryRepo.Save(this.danhSachHang);
        }
    }
}