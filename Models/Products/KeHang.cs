namespace QuanLySieuThi.Models.Products
{
    public class KeHang
    {
        private string maKe;
        private string viTri;
        private int sucChua; 

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
            set { sucChua = value; } 
        }

        public KeHang(string ma, string ten, int succhua)
        {
            this.maKe = ma;
            this.viTri = ten;
            this.sucChua = succhua;
        }
    }
}