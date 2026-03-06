using System;
using System.Collections.Generic;

namespace Sales
{
    public class HoaDon
    {
        private string maHD;
        private DateTime ngayTao;
        private double tongTien;
        private bool trangThaiTT;
        private List<ChiTietHoaDon> danhSachChiTiet;

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
            set { trangThaiTT = value; }
        }

        public List<ChiTietHoaDon> DanhSachChiTiet
        {
            get { return danhSachChiTiet; }
        }

        public HoaDon()
        {
            danhSachChiTiet = new List<ChiTietHoaDon>();
            tongTien = 0;
            trangThaiTT = false;
        }

        public void ThemChiTiet(ChiTietHoaDon ct)
        {
            danhSachChiTiet.Add(ct);
            TinhTongTien();
        }

        public void TinhTongTien()
        {
            tongTien = 0;
            int i;
            for (i = 0; i < danhSachChiTiet.Count; i++)
            {
                tongTien = tongTien + danhSachChiTiet[i].ThanhTien;
            }
        }

        public void ThanhToan()
        {
            trangThaiTT = true;
        }
    }
}