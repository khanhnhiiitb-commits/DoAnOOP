using System;
using QuanLySieuThi.Models.Products;
namespace QuanLySieuThi.Models.Products
{
    public class HangHoaFactory
    {
        public static HangHoa TaoHangHoa(string loaiHang)
        {
            switch (loaiHang.ToLower())
            {
                case "thucpham":
                    return new HangThucPham();

                case "dientu":
                    return new HangDienTu();

                default:
                    throw new ArgumentException("Loại hàng hóa không hợp lệ!");
            }
        }
    }
}