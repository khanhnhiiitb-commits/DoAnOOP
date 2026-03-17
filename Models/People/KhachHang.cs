
using QuanLySieuThi.Models.Sales;
namespace QuanLySieuThi.Models.People
{
    public class KhachHang : Nguoi
    {
    
        private string maKH;
        private string loaiKhachHang;
        private int diemTichLuy;
        private TheThanhVien theTV; // Có thể là null
        
        public TheThanhVien TheTV 
        { 
            get { return theTV; } 
            set { theTV = value; } 
        }

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


        public KhachHang(){}

        public KhachHang(string ma, string hoTen, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi,
                 string loaiKH, int diem, TheThanhVien the) 
                 : base(ma, hoTen, ngaySinh, gioiTinh, soDienThoai, diaChi)
            {
            this.maKH = ma;
            this.loaiKhachHang = loaiKH;
            this.diemTichLuy = diem;
            this.theTV = the;
            }

            // Constructor này không cần truyền tham số thẻ
        public KhachHang(string ma, string hoTen) : base()
        {
            this.maKH = ma;
            this.theTV = null; // Xác nhận khách này chưa có thẻ
            this.diemTichLuy = 0;
        }
    }
}
