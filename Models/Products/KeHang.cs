namespace QuanLySieuThi.Models.Products
{
    public class KeHang
    {
        private string maKe;
        private string viTri;
        private int sucChua;
        private string loaiHang;
        private int soLuongHienTai;
        private List<HangHoa> danhSachHang = new List<HangHoa>();
        public string MaKe{ get { return maKe; }set { maKe = value; } }
        public string ViTri{ get { return viTri; } set { viTri = value; } }
        public int SoLuongHienTai { get { return soLuongHienTai; } set { soLuongHienTai = value; } }
        public int SucChua
        {   get { return sucChua; }
            set
            {
                if (value >= 0) sucChua = value;
                else sucChua = 0;
            }
        }
        public string TrangThai
        {
            get
            {
                if (SoLuongHienTai == 0) return "Trống";
                if (SoLuongHienTai >= SucChua) return "Đã đầy";
                return "Đang sử dụng";
            }
        }
        public string LoaiHang {get { return loaiHang; } set { loaiHang = value; } }
        public List<HangHoa> DanhSachHang{get { return danhSachHang; }}
        public KeHang() { }
        public KeHang(string ma,string vitri,int succhua,string loai)
        {
            this.MaKe = ma;
            this.ViTri = vitri;
            this.SucChua = succhua;
            this.LoaiHang = loai;
        }
        public bool ThemHangHoa(HangHoa hh)
        {
            if (danhSachHang.Count < sucChua)
            {
                danhSachHang.Add(hh);
                return true; // Thêm thành công
            }
            return false; // Kệ đã đầy
        }
    }
}