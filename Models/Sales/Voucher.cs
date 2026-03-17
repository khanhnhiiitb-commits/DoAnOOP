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
        public DateTime NgayBatDau { get { return ngayBatDau; } set { ngayBatDau = value; } }
        public DateTime NgayKetThuc { get { return ngayKetThuc; } set { ngayKetThuc = value; } }
        public string DKApDung { get { return dkApDung; } set { dkApDung = value; } }
        public bool TrangThai { get { return trangThai; } set { trangThai = value; } }

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
            this.maVoucher = ma;
            this.tenVoucher = ten;
            this.ngayBatDau = batDau;
            this.ngayKetThuc = ketThuc;
            this.trangThai = true; // Mặc định tạo ra là có thể dùng ngay
        }

         public abstract double TinhSoTienGiam(double TongTien);

    }

    public class VoucherTienMat : Voucher
    {
        private double soTienGiamCoDinh;
        public double SoTienGiamCoDinh 
        { 
            get { return soTienGiamCoDinh; } 
            set { soTienGiamCoDinh = value; } 
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
            set { phanTramGiam = value; } 
        }
        public double GiamToiDa 
        { 
            get { return giamToiDa; } 
            set { giamToiDa = value; } 
        }

        // TÍNH ĐA HÌNH: Cách tính hoàn toàn khác với Voucher tiền mặt
        public override double TinhSoTienGiam(double TongTien)
        {
            double giam = TongTien * (PhanTramGiam / 100);
            return (giam > GiamToiDa) ? GiamToiDa : giam;
        }
    }


}