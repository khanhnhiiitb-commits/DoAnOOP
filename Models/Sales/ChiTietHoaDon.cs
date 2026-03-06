using System;

namespace QuanLySieuThi.Models.Sales
{
    public class ChiTietHoaDon
    {
        private string maCTHD;
        private int soLuongMua;
        private double giaBan;
        private double thanhTien;

        public string MaCTHD
        {
            get { return maCTHD; }
            set { maCTHD = value; }
        }

        public int SoLuongMua
        {
            get { return soLuongMua; }
            set
            {
                soLuongMua = value;
                TinhThanhTien();
            }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                giaBan = value;
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
            thanhTien = soLuongMua * giaBan;
        }
    }
}