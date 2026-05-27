using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System.Collections.Generic;

namespace QuanLySieuThi.Models
{
    // Bọc dữ liệu cho file database_sales.json
    public class SalesData
    {
        public List<Voucher> Vouchers { get; set; }
        public List<HoaDon> HoaDons { get; set; }

        public SalesData()
        {
            Vouchers = new List<Voucher>();
            HoaDons = new List<HoaDon>();
        }
    }

    // Bọc dữ liệu cho file database_system.json
    public class SystemData
    {
        public List<TaiKhoan> TaiKhoans { get; set; }
        public List<CaLamViec> CaLamViecs { get; set; }
        public List<ChuongTrinhKhuyenMai> KhuyenMais { get; set; }

        public SystemData()
        {
            TaiKhoans = new List<TaiKhoan>();
            CaLamViecs = new List<CaLamViec>();
            KhuyenMais = new List<ChuongTrinhKhuyenMai>();
        }
    }
    // Bọc dữ liệu cho file database_partner.json
    public class PartnerData
    {
        public List<NhaCungCap> NhaCungCaps { get; set; }
        public List<KhachHang> KhachHangs { get; set; }

        public PartnerData()
        {
            NhaCungCaps = new List<NhaCungCap>();
            KhachHangs = new List<KhachHang>();
        }
    }
}