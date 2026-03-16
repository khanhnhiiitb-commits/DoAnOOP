using System;

namespace QuanLySieuThi.Models.Sales
{
    public class TheThanhVien
    {
        private string maThe;
        private DateTime ngayDangKy;
        private int diemTichLuy;
        private bool trangThai;

        public string MaThe { get { return maThe; } set { maThe = value; } }
        public DateTime NgayDangKy { get { return ngayDangKy; } set { ngayDangKy = value; } }

        public int DiemTichLuy
        {
            get { return diemTichLuy; }
            private set { diemTichLuy = value; }
        }

        public bool TrangThai { get { return trangThai; } set { trangThai = value; } }

        public void CongDiem(int diem)
        {
            if (diem > 0)
            {
                diemTichLuy = diemTichLuy + diem;
            }
        }

        public void TruDiem(int diem)
        {
            if (diem > 0 && diem <= diemTichLuy)
            {
                diemTichLuy = diemTichLuy - diem;
            }
        }

        public TheThanhVien() { }

        public TheThanhVien(string ma)
        {
            this.maThe = ma;
            this.ngayDangKy = DateTime.Now;
            this.diemTichLuy = 0;
            this.trangThai = true; // Thẻ mới mặc định là đang hoạt động
        }
    }
}