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
            set { ngayBatDau = value; }
        }

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set 
            { 
                // Logic: Ngày kết thúc phải sau hoặc bằng ngày bắt đầu
                if (value >= ngayBatDau)
                    ngayKetThuc = value; 
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
            set { danhSachChiTiet = value; } 
        }

        // Constructor mặc định
        public ChuongTrinhKhuyenMai() { }

        // Constructor đầy đủ tham số
        public ChuongTrinhKhuyenMai(string maKM, string ten, DateTime bd, DateTime kt, string nd)
        {
            this.maCTKM = maKM;
            this.tenCT = ten;
            this.ngayBatDau = bd;
            this.ngayKetThuc = kt;
            this.noiDung = nd;
        }

        public bool DangDienRa()
        {
            DateTime hienTai = DateTime.Now;
            return hienTai >= ngayBatDau && hienTai <= ngayKetThuc;
        }

        public abstract bool KiemTraDieuKien(HoaDon hd);
        public abstract double TinhSoTienGiam(double tongTienHD);
    }
}