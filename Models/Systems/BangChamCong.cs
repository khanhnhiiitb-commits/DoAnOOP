using System;

namespace QuanLySieuThi.Models.Systems
{//sua
    public class BangChamCong
    {
       
   
    {
        
        private string maNhanVien;
        private int thang;
        private int nam;
        private int soNgayLamViec;
        private int soNgayNghi;
        private double phuCap;
        private string ghiChu;

       
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public int Thang
        {
            get { return thang; }
            set { if (value >= 1 && value <= 12) thang = value; }
        }

        public int Nam
        {
            get { return nam; }
            set { if (value > 0) nam = value; }
        }

        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set { if (value >= 0) soNgayLamViec = value; }
        }

        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set { if (value >= 0) soNgayNghi = value; }
        }

        public double PhuCap
        {
            get { return phuCap; }
            set { if (value >= 0) phuCap = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        // Constructor 
        public BangChamCong(string maNV, int t, int n, int lam, int nghi, double pc, string note)
        {
            this.maNhanVien = maNV;
            this.thang = t;
            this.nam = n;
            this.soNgayLamViec = lam;
            this.soNgayNghi = nghi;
            this.phuCap = pc;
            this.ghiChu = note;
        }


        public int TinhTongCong()
        {
            return soNgayLamViec + soNgayNghi;
        }
    }
}
    }
}