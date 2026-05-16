using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;


namespace QuanLySieuThi.Models.Sales
{
    public class HoaDon
    {
        private string maHD;
        private NhanVien nv;
        private KhachHang kh;
        private DateTime ngayTao;
        private double tongTien;
        private bool trangThaiTT;
        private List<ChiTietHoaDon> danhSachChiTiet;
        private bool daApDungVoucher = false;

        public bool DaApDungVoucher 
        { 
            get {return daApDungVoucher;}
            set  {daApDungVoucher = value;}
        }
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public DateTime NgayTao
        {
            get { return ngayTao; }
            set { ngayTao = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            private set { tongTien = value; }
        }

        public bool TrangThaiTT
        {
            get { return trangThaiTT; }
        }

        public List<ChiTietHoaDon> DanhSachChiTiet
        {
            get { return danhSachChiTiet; }
        }
        public string MaNV
        {
            get { return nv.Ma != null ? nv.Ma : string.Empty; }
        }

        public string MaKH
        {
            get { return kh.Ma != null ? kh.Ma : string.Empty; }
        }
        public HoaDon()
        {
            danhSachChiTiet = new List<ChiTietHoaDon>();
            TongTien = 0;
            trangThaiTT = false;
        }
        
        public HoaDon(string ma, NhanVien nv, KhachHang kh)
        {
            this.MaHD = ma;
            this.nv = nv;   
            this.kh = kh;
            this.NgayTao = DateTime.Now; 
            this.danhSachChiTiet = new List<ChiTietHoaDon>();
            this.TongTien = 0;
            this.trangThaiTT = false;
        }

        public void ThemChiTiet(ChiTietHoaDon ct)
        {
            danhSachChiTiet.Add(ct);
            TinhTongTien();
        }

        public void TinhTongTien()
        {
            double thanhTienGoc = 0;
            int i;
            for (i = 0; i < danhSachChiTiet.Count; i++)
            {
                thanhTienGoc = thanhTienGoc + danhSachChiTiet[i].ThanhTien;
            }
            double ketQua = thanhTienGoc - soTienGiam;

            if (ketQua >= 0)
                this.TongTien = ketQua;
            else
                this.TongTien = 0; 
        }
        private double soTienGiam = 0;
        public void ApDungGiamGia(double tienGiam)
        {
            this.soTienGiam = tienGiam;
            TinhTongTien(); 
        }
        public void ThanhToan()
        {
            trangThaiTT = true;
        }
    }
}
