namespace QuanLySieuThi.Models.Products
{
    public class KeHang
    {
        private string maKe;
        private string viTri;
        private int sucChua; 
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
            set { if (value >= 0) sucChua = value; } 
        }       

        public List<HangHoa> DanhSachHang 
        { 
            get { return danhSachHang; } 
            set { danhSachHang = value; } 
        }

        public KeHang() { }

        public KeHang(string ma, string ten, int succhua)
        {
            this.maKe = ma;
            this.viTri = ten;
            this.sucChua = succhua;
        }
    }
}