namespace QuanLySieuThi.Models
{
    public class TheThanhVien
    {
         private string maThe;
        private DateTime ngayDangKy;
        private string loaiThe;
        private int diemTichLuy;
        private bool trangThai;

        public string MaThe
        {
            get { return maThe; }
            set { maThe = value; }
        }

        public DateTime NgayDangKy
        {
            get { return ngayDangKy; }
            set { ngayDangKy = value; }
        }

        public string LoaiThe
        {
            get { return loaiThe; }
            set { loaiThe = value; }
        }

        public int DiemTichLuy
        {
            get { return diemTichLuy; }
            private set { diemTichLuy = value; }
        }

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public TheThanhVien()
        {
            diemTichLuy = 0;
            trangThai = true;
        }

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

        public override string ToString()
        {
            return "Mã thẻ: " + maThe +
                   " | Loại: " + loaiThe +
                   " | Điểm: " + diemTichLuy;
        }
    }
}