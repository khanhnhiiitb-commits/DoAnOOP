using System;

namespace QuanLySieuThi.Models.Sales
{
    public class Voucher
    {
        private string maVoucher;
        private string tenVoucher;
        private string loaiVoucher;
        private double giaTri;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string dkApDung;
        private bool trangThai;

        public string MaVoucher { get { return maVoucher; } set { maVoucher = value; } }
        public string TenVoucher { get { return tenVoucher; } set { tenVoucher = value; } }
        public string LoaiVoucher { get { return loaiVoucher; } set { loaiVoucher = value; } }
        public double GiaTri { get { return giaTri; } set { giaTri = value; } }
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

        public Voucher(string ma, string ten, double gt, DateTime batDau, DateTime ketThuc)
        {
            this.maVoucher = ma;
            this.tenVoucher = ten;
            this.giaTri = gt;
            this.ngayBatDau = batDau;
            this.ngayKetThuc = ketThuc;
            this.trangThai = true; // Mặc định tạo ra là có thể dùng ngay
        }

        public double TinhSoTienGiam(double tongTienHoaDon)
        {
            if (!KiemTraHieuLuc()) return 0;

            if (loaiVoucher == "PhanTram")
            {
            // Ví dụ giaTri = 10 (tức là 10%)
            return tongTienHoaDon * (giaTri / 100);
            }
            else // Giam theo so tien co dinh
            {
                return giaTri;
            }
        }
    }
}