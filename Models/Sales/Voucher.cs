using System;
using QuanLySieuThi.Models;

namespace QuanLySieuThi.Models.Sales
{
    public abstract class Voucher
    {
        private string maVoucher;
        private string tenVoucher;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string dkApDung;
        private bool trangThai;

        public string MaVoucher { get { return maVoucher; } set { maVoucher = value; } }
        public string TenVoucher { get { return tenVoucher; } set { tenVoucher = value; } }
        public DateTime NgayBatDau 
        { 
            get { return ngayBatDau; } 
            set 
            {
                ngayBatDau = value;
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
                if (value >= ngayBatDau)
                    ngayKetThuc = value;
                else
                    ngayKetThuc = ngayBatDau;
            } 
        }
        public string DKApDung { get { return dkApDung; } set { dkApDung = value; } }
        public bool TrangThai { get { return trangThai; } set { trangThai = value; } }
        public void ThayDoiTrangThai()
        {
            this.trangThai = !this.trangThai;
        }
        public bool KiemTraHieuLuc()
        {
            DateTime hienTai = DateTime.Now;

            if (trangThai == true &&
                hienTai >= ngayBatDau &&
                hienTai <= ngayKetThuc)
            {
                return true;
            }

            return false;
        }

        public Voucher() { }

        public Voucher(string ma, string ten, DateTime batDau, DateTime ketThuc, bool trangThai)
        {
            this.MaVoucher = ma;
            this.TenVoucher = ten;
            this.NgayBatDau = batDau;
            this.NgayKetThuc = ketThuc;
            this.TrangThai = true; 
        }

         public abstract double TinhSoTienGiam(double TongTien);

    }

    public class VoucherTienMat : Voucher
    {
        private double soTienGiamCoDinh;
        public VoucherTienMat() : base() { }
        public double SoTienGiamCoDinh 
        { 
            get { return soTienGiamCoDinh; } 
            set 
            {
                if (value >= 0)
                    soTienGiamCoDinh = value;
                else
                    soTienGiamCoDinh = 0;
            }
        }
        //Constructor hỗ trợ khởi tạo nhanh
        public VoucherTienMat(string ma, string ten, DateTime batDau, DateTime ketThuc, bool trangThai, double soTienGiam)
            : base(ma, ten, batDau, ketThuc, trangThai)
        {
            this.SoTienGiamCoDinh = soTienGiam;
        }
        public override double TinhSoTienGiam(double TongTien)
        {
            return SoTienGiamCoDinh;
        }
    }

    public class VoucherPhanTram : Voucher
    {
        private float phanTramGiam;
        private double giamToiDa;
        public float PhanTramGiam 
        { 
            get { return phanTramGiam; } 
            set 
            {
                if (value >= 0 && value <= 100)
                    phanTramGiam = value;
                else
                    phanTramGiam = 0;
            } 
        }
        public double GiamToiDa 
        { 
            get { return giamToiDa; } 
            set 
            {
                if (value >= 0)
                    giamToiDa = value;
                else
                    giamToiDa = 0;
            } 
        }
        public VoucherPhanTram() : base() { }

        //Constructor hỗ trợ khởi tạo nhanh
        public VoucherPhanTram(string ma, string ten, DateTime batDau, DateTime ketThuc, bool trangThai, float phanTram, double toiDa)
            : base(ma, ten, batDau, ketThuc, trangThai)
        {
            this.PhanTramGiam = phanTram;
            this.GiamToiDa = toiDa;
        }

        // TÍNH ĐA HÌNH: Cách tính hoàn toàn khác với Voucher tiền mặt
        public override double TinhSoTienGiam(double TongTien)
        {
            double giam = TongTien * (PhanTramGiam / 100);
            return (giam > GiamToiDa) ? GiamToiDa : giam;
        }
    }


}