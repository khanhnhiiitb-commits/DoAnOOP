
namespace QuanLySieuThi.Models.People
{
    public class KhachHang : Nguoi
    {
        private string maKH;
        private string loaiKhachHang;
        private int diemTichLuy;
        private string maTheTV;

        public string MaKH 
        { 
            get { return maKH; } 
            set { maKH = value; } 
        }

        public string LoaiKhachHang 
        { 
            get { return loaiKhachHang; } 
            set { loaiKhachHang = value; } 
        }

        public int DiemTichLuy 
        { 
            get { return diemTichLuy; } 
            set { diemTichLuy = value; } 
        }

        public string MaTheTV 
        { 
            get { return maTheTV; } 
            set { maTheTV = value; } 
        }
    }
}