using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Models.Systems
{//sua
    public abstract class ChuongTrinhKhuyenMai
    {
       private string maCTKM;
        private string tenCT;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string noiDung;
        private List<ChiTietChuongTrinhKM> danhSachChiTiet = new List<ChiTietChuongTrinhKM>();

        // Properties
        public string MaCTKM
        {
            get { return maCTKM; }
            set { maCTKM = value; }
        }

        public string TenCT
        {
            get { return tenCT; }
            set { tenCT = value; }
        }

        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set 
            {
                ngayBatDau = value;
                // Nếu ngày bắt đầu bị dời về sau ngày kết thúc hiện tại, tự động đồng bộ ngày kết thúc
                if (ngayKetThuc != DateTime.MinValue && ngayBatDau > ngayKetThuc)
                {
                    ngayKetThuc = ngayBatDau;
                }
            }
        }

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set 
            {
                // Logic: Ngày kết thúc phải sau hoặc bằng ngày bắt đầu
                if (value >= ngayBatDau)
                    ngayKetThuc = value;
                else
                    ngayKetThuc = ngayBatDau;
            }
        }

        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }

        public List<ChiTietChuongTrinhKM> DanhSachChiTiet 
        { 
            get { return danhSachChiTiet; } 
        }

        // Constructor mặc định
        public ChuongTrinhKhuyenMai() { }

        // Constructor đầy đủ tham số
        public ChuongTrinhKhuyenMai(string maKM, string ten, DateTime bd, DateTime kt, string nd)
        {
            this.MaCTKM = maKM;
            this.TenCT = ten;
            this.NgayBatDau = bd;
            this.NgayKetThuc = kt;
            this.NoiDung = nd;
        }

        public bool DangDienRa()
        {
            DateTime hienTai = DateTime.Now;
            return hienTai >= ngayBatDau && hienTai <= ngayKetThuc;
        }
        public void ThemChiTiet(ChiTietChuongTrinhKM ct)
        {
            if (ct != null)
            {
                this.DanhSachChiTiet.Add(ct);
            }
        }
        public abstract bool KiemTraDieuKien(HoaDon hd);
        public abstract double TinhSoTienGiam(double tongTienHD);
    }
}