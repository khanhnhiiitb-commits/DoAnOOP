namespace QuanLySieuThi.Models.Products
{
    public class KeHang
    {
        private string maKe;

        private string viTri;

        private int sucChua;

        private string loaiHang;

        private string trangThai;

        private List<HangHoa> danhSachHang =
            new List<HangHoa>();

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
            }
        }

        public string LoaiHang
        {
            get { return loaiHang; }
            set { loaiHang = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public List<HangHoa> DanhSachHang
        {
            get { return danhSachHang; }
            set { danhSachHang = value; }
        }

        public KeHang() { }

        public KeHang
        (
            string ma,
            string vitri,
            int succhua,
            string loai,
            string trangthai
        )
        {
            this.maKe = ma;

            this.viTri = vitri;

            this.sucChua = succhua;

            this.loaiHang = loai;

            this.trangThai = trangthai;
        }
    }
}