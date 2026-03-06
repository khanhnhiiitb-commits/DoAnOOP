namespace QuanLySieuThi.Models.People
{
    public abstract class Nguoi
    {
        private string ma;
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string soDienThoai;
        private string diaChi;

        public string GetMa()
        {
            return ma;
        }

        public void SetMa(string ma)
        {
            this.ma = ma;
        }

        public string GetHoTen()
        {
            return hoTen;
        }

        public void SetHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }

        public DateTime GetNgaySinh()
        {
            return ngaySinh;
        }

        public void SetNgaySinh(DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }

        public bool GetGioiTinh()
        {
            return gioiTinh;
        }

        public void SetGioiTinh(bool gioiTinh)
        {
            this.gioiTinh = gioiTinh;
        }

        public string GetSoDienThoai()
        {
            return soDienThoai;
        }

        public void SetSoDienThoai(string soDienThoai)
        {
            this.soDienThoai = soDienThoai;
        }

        public string GetDiaChi()
        {
            return diaChi;
        }

        public void SetDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
    }
}