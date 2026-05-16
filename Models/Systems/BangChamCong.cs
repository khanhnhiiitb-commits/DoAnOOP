using System;

namespace QuanLySieuThi.Models.Systems
{//sua
    public class BangChamCong
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
            set 
            {
                if (value >= 1 && value <= 12)
                    thang = value;
                else
                    thang = 1;
            }
        }

        public int Nam
        {
            get { return nam; }
            set 
            {
                if (value > 0)
                    nam = value;
                else
                    nam = DateTime.Now.Year;
            }
        }

        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set 
            {
                if (value >= 0 && value <= 31) // Chặn nhập quá 31 ngày/tháng
                    soNgayLamViec = value;
                else
                    soNgayLamViec = 0;
            }
        }

        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set 
            {
                if (value >= 0 && value <= 31)
                    soNgayNghi = value;
                else
                    soNgayNghi = 0;
            }
        }

        public double PhuCap
        {
            get { return phuCap; }
            set
            {
                if (value >= 0)
                    phuCap = value;
                else
                    phuCap = 0;
            }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        // Constructor 

        public BangChamCong() { }

        public BangChamCong(string maNV, int t, int n, int lam, int nghi, double pc, string note)
        {
            this.MaNhanVien = maNV;
            this.Thang = t;
            this.Nam = n;
            this.SoNgayLamViec = lam;
            this.SoNgayNghi = nghi;
            this.PhuCap = pc;
            this.GhiChu = note;
        }


        public int TinhTongCong()
        {
            return soNgayLamViec + soNgayNghi;
        }

        public double TinhLuongThucNhan(double luongCB)
        {
        // Giả sử: Lương = (Lương cơ bản / 26 ngày công) * số ngày làm + Phụ cấp
        double luongMotNgay = luongCB / 26;
        return (luongMotNgay * soNgayLamViec) + phuCap;
        }
    }
}