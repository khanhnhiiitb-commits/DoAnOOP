using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.Models.Products;

namespace ChuongtrinhQuanlybanhangsieuthi.Models.Products
{
    internal class HangHoaFactory
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
