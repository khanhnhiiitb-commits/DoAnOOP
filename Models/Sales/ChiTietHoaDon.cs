using System;
using QuanLySieuThi.Models.Products;

namespace QuanLySieuThi.Models.Sales
{
    public class ChiTietHoaDon
    {
        private string maCTHD;
        private string maHH;
        private int soLuongMua;
        private double giaBan;
        private double thanhTien;

        public string MaCTHD
        {
            get { return maCTHD; }
            set { maCTHD = value; }
        }

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public int SoLuongMua
        {
            get { return soLuongMua; }
            set
            {
                if (value >= 0)
                    soLuongMua = value;
                else
                    soLuongMua = 0;
                TinhThanhTien();
            }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (value >= 0)
                    giaBan = value;
                else
                    giaBan = 0;
                TinhThanhTien();
            }
        }

        public double ThanhTien
        {
            get { return thanhTien; }
            private set { thanhTien = value; }
        }

        private void TinhThanhTien()
        {
            ThanhTien = soLuongMua * giaBan;
        }

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(string maCT, string maH, int sl, double gia)
        {
         this.MaCTHD = maCT;
         this.MaHH = maH;
         this.SoLuongMua = sl;
         this.GiaBan = gia;
        }
    }
}