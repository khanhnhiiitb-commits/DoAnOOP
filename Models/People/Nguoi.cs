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

        public string Ma{ get{ return ma; } set {ma = value;} }

        public string HoTen{ get{ return hoTen; } set {hoTen = value;} }

        public DateTime NgaySinh{ get{ return ngaySinh; } set {ngaySinh = value;} }

        public bool GioiTinh{ get{ return gioiTinh; } set {gioiTinh = value;} }

        public string SoDienThoai{ get{ return soDienThoai; } set {soDienThoai = value;} }

        public string DiaChi{ get{ return diaChi; } set {diaChi = value;} }

        public string HienThiGioiTinh
        {
            get
            {
                if (GioiTinh == true)
                    return "Nam";
                else
                    return "Nữ";
            }
        }
        public Nguoi() { }

        public Nguoi(string ma, string hoTen, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi)
        {
            this.ma = ma;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
        }
    }
}