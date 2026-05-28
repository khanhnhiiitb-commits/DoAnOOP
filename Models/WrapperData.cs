using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System.Collections.Generic;

namespace QuanLySieuThi.Models
{
    // Bọc dữ liệu cho file database_sales.json
    public class SalesData
    {
        // Khai báo biến private
        private List<Voucher> vouchers;
        private List<HoaDon> hoaDons;

        // Thuộc tính public có get, set tường minh
        public List<Voucher> Vouchers { get { return vouchers; } set { vouchers = value; } }
        public List<HoaDon> HoaDons { get { return hoaDons; } set { hoaDons = value; } }

        public SalesData()
        {
            this.vouchers = new List<Voucher>();
            this.hoaDons = new List<HoaDon>();
        }
    }

    // Bọc dữ liệu cho file database_system.json
    public class SystemData
    {
        // Khai báo biến private
        private List<TaiKhoan> taiKhoans;
        private List<CaLamViec> caLamViecs;
        private List<ChuongTrinhKhuyenMai> khuyenMais;

        // Thuộc tính public có get, set tường minh
        public List<TaiKhoan> TaiKhoans { get { return taiKhoans; } set { taiKhoans = value; } }
        public List<CaLamViec> CaLamViecs { get { return caLamViecs; } set { caLamViecs = value; } }
        public List<ChuongTrinhKhuyenMai> KhuyenMais { get { return khuyenMais; } set { khuyenMais = value; } }

        public SystemData()
        {
            this.taiKhoans = new List<TaiKhoan>();
            this.caLamViecs = new List<CaLamViec>();
            this.khuyenMais = new List<ChuongTrinhKhuyenMai>();
        }
    }
    // Bọc dữ liệu cho file database_partner.json
    public class PartnerData
    {
        // Khai báo biến private
        private List<NhaCungCap> nhaCungCaps;
        private List<KhachHang> khachHangs;

        // Thuộc tính public có get, set tường minh
        public List<NhaCungCap> NhaCungCaps { get { return nhaCungCaps; } set { nhaCungCaps = value; } }
        public List<KhachHang> KhachHangs { get { return khachHangs; } set { khachHangs = value; } }

        public PartnerData()
        {
            this.nhaCungCaps = new List<NhaCungCap>();
            this.khachHangs = new List<KhachHang>();
        }
    }
}