namespace QuanLySieuThi.Models
{
    public class KeHang
    {
        private string maKe;
        private string viTri;
        private int sucChua; // Vi du: Thuc pham, Gia dung

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
        public string SucChua 
        { 
            get { return sucChua; } 
            set { sucChua = value; } 
        }

        public KeHang(string ma, string ten, string loai)
        {
            this.maKe = ma;
            this.viTri = ten;
            this.sucChua = loai;
        }
    }
}