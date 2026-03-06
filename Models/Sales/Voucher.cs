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
    }
}