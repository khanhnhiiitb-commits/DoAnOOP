using System;
using System.Text.Json.Serialization;

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

        [JsonInclude]
        public int DiemTichLuy
        {
            get { return diemTichLuy; }
            private set { diemTichLuy = value; }
        }
        [JsonInclude]
        public bool TrangThai 
        { 
            get { return trangThai; } 
            private set { trangThai = value; } 
        }

        public void CongDiem(int diem)
        {
            if (diem > 0)
            {
                DiemTichLuy = DiemTichLuy + diem;
            }
        }

        public bool TruDiem(int diemDoi)
        {
         
            if (this.diemTichLuy >= diemDoi)
            {
                this.diemTichLuy -= diemDoi;
                return true;
            }

            return false; 
        }
        public void NapDiemTuFile(int diem)
        {
            if (diem >= 0)
            {
                DiemTichLuy = diem;
            }
        }
        public void KhoaThe()
        {
            TrangThai = false;
        }

        public void KichHoatThe()
        {
            TrangThai = true;
        }
        public TheThanhVien() { }

        public TheThanhVien(string ma)
        {
            this.MaThe = ma;
            this.NgayDangKy = DateTime.Now;
            this.DiemTichLuy = 0;
            this.TrangThai = true;
        }
    }
}