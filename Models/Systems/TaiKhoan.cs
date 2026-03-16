namespace QuanLySieuThi.Models.Systems
{//sua
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; } // Đúng tên trong hình
        public string MatKhau { get; set; }     // Đúng tên trong hình
        public string VaiTro { get; set; }      // Sửa từ LoaiTaiKhoan -> VaiTro
        public bool TrangThai { get; set; }     // Sửa từ TinhTrang -> TrangThai

        public TaiKhoan() { }

        public TaiKhoan(string tenDN, string matKhau, string vaiTro, bool trangThai)
        {
            TenDangNhap = tenDN;
            MatKhau = matKhau;
            VaiTro = vaiTro;
            TrangThai = trangThai;
        }
    }
}