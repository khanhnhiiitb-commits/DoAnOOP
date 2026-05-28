using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace QuanLySieuThi.Models.Systems
{//sua
    [JsonDerivedType(typeof(KhuyenMaiCoBan), typeDiscriminator: "KhuyenMaiCoBan")]
    public abstract class ChuongTrinhKhuyenMai
    {
       private string maCTKM;
        private string tenCT;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string noiDung;
        private List<ChiTietChuongTrinhKM> danhSachChiTiet = new List<ChiTietChuongTrinhKM>();
        public string MaCTKM { get { return maCTKM; }  set { maCTKM = value; } }
        public string TenCT { get { return tenCT; } set { tenCT = value; }  }
        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set 
            {
                ngayBatDau = value;
                if (ngayKetThuc != DateTime.MinValue && ngayBatDau > ngayKetThuc) 
                    ngayKetThuc = ngayBatDau;
            }
        }

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set 
            {
                if (value >= ngayBatDau) ngayKetThuc = value;
                else ngayKetThuc = ngayBatDau;
            }
        }
        public string NoiDung { get { return noiDung; }  set { noiDung = value; } }

        [JsonInclude]
        public List<ChiTietChuongTrinhKM> DanhSachChiTiet
        {
            get { return danhSachChiTiet; }
            private set { danhSachChiTiet = value; } // Thêm set để JSON có thể đổ dữ liệu vào
        }

        public ChuongTrinhKhuyenMai() { }
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
            if (ct != null)  this.DanhSachChiTiet.Add(ct);
        }
        public abstract bool KiemTraDieuKien(HoaDon hd);
        public abstract double TinhSoTienGiam(double tongTienHD);
    }
}