
using QuanLySieuThi.Models.Sales;
namespace QuanLySieuThi.Models.People
{
    public class KhachHang : Nguoi
    {
        private string loaiKhachHang;
        private int diemTichLuy;
        private TheThanhVien theTV; // Có thể là null
        public TheThanhVien TheTV 
        { 
            get { return theTV; } 
            set { theTV = value; } 
        }
        public string LoaiKhachHang 
        { 
            get { return loaiKhachHang; } 
            set { loaiKhachHang = value; } 
        }
        public int DiemTichLuy 
        { 
            get { return diemTichLuy; } 
            set {
                if (value >= 0)
                {
                    diemTichLuy = value;
                }
                else
                {
                    diemTichLuy = 0;
                }
            } 
        }
        public KhachHang(){}
        public KhachHang(string ma, string hoTen, DateTime ngaySinh, bool gioiTinh, string soDienThoai, string diaChi,
                 string loaiKH, int diem, TheThanhVien the) 
                 : base(ma, hoTen, ngaySinh, gioiTinh, soDienThoai, diaChi)
            {
            this.LoaiKhachHang = loaiKH;
            this.DiemTichLuy = diem;
            this.TheTV = the;
            }
            // Constructor này không cần truyền tham số thẻ
        public KhachHang(string ma, string hoTen) : base(ma, hoTen)
        {

            this.TheTV = null; // Xác nhận khách này chưa có thẻ
            this.DiemTichLuy = 0;
            this.LoaiKhachHang = "Thường"; // Gán giá trị mặc định tránh null
        }
    }
}
