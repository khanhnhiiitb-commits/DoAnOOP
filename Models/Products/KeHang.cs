namespace QuanLySieuThi.Models.Products
{
    public class KeHang
    {
        private string maKe;
        private string viTri;
        private int sucChua;
        private string loaiHang;

        private List<HangHoa> danhSachHang = new List<HangHoa>();

        public string MaKe
        {
            get { return maKe; }
            set { maKe = value; }
        }

        public string ViTri
        {
            get { return viTri; }
            set { viTri = value; }
        }

        public int SucChua
        {
            get { return sucChua; }
            set
            {
                if (value >= 0)
                {
                    sucChua = value;
                }
                else
                {
                    sucChua = 0;
                }
            }
        }
        public string TrangThai
        {
            get
            {
                if (danhSachHang.Count == 0)
                    return "Trống";
                else if (danhSachHang.Count >= sucChua)
                    return "Đầy";
                else
                    return "Còn chỗ";
            }
        }

        public string LoaiHang
        {
            get { return loaiHang; }
            set { loaiHang = value; }
        }

        public List<HangHoa> DanhSachHang
        {
            get { return danhSachHang; }
        }

        public KeHang() { }

        public KeHang(string ma,string vitri,int succhua,string loai,string trangthai)
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