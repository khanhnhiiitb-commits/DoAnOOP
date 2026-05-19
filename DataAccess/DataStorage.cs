using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;

namespace QuanLySieuThi.Data
{
    public class DataStorage
    {
        // 1. Biến static duy nhất lưu trữ thực thể của lớp
        private static DataStorage instance;
        
        // 2. Constructor private: Không cho phép "new" từ bên ngoài
        private DataStorage()
        {
            // Khởi tạo TẤT CẢ các danh sách trống để tránh lỗi NullReferenceException
            DanhSachHang = new List<HangHoa>();
            DanhSachNV = new List<NhanVien>();
            DanhSachHD = new List<HoaDon>();
            DanhSachKH = new List<KhachHang>();
            DanhSachNCC = new List<NhaCungCap>();
            DanhSachBCM = new List<BangChamCong>();
            DanhSachPhieuNhap = new List<PhieuNhap>();
            DanhSachKhuyenMai = new List<ChuongTrinhKhuyenMai>();
            DanhSachVoucher = new List<Voucher>();
            DanhSachTheTV = new List<TheThanhVien>();
            DanhSachKeHang = new List<KeHang>();
            DanhSachTaiKhoan = new List<TaiKhoan>();
            DanhSachCaLamViec = new List<CaLamViec>();

            // Nạp toàn bộ dữ liệu từ txt lên RAM khi hệ thống bắt đầu
            LoadAllData();
        }

        // 3. Property duy nhất để truy cập vào kho dữ liệu
        public static DataStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;
            }
        }

        // --- CÁC DANH SÁCH DỮ LIỆU ---
        public List<HangHoa> DanhSachHang { get; set; }
        public List<NhanVien> DanhSachNV { get; set; }
        public List<HoaDon> DanhSachHD { get; set; }
        public List<KhachHang> DanhSachKH { get; set; }
        public List<NhaCungCap> DanhSachNCC { get; set; }
        public List<BangChamCong> DanhSachBCM { get; set; }
        public List<PhieuNhap> DanhSachPhieuNhap { get; set; }
        public List<ChuongTrinhKhuyenMai> DanhSachKhuyenMai { get; set; }
        public List<Voucher> DanhSachVoucher { get; set; }
        public List<TheThanhVien> DanhSachTheTV { get; set; }
        public List<TaiKhoan> DanhSachTaiKhoan { get; set; }
        public List<KeHang> DanhSachKeHang { get; set; }
        public List<CaLamViec> DanhSachCaLamViec { get; set; } 

        // Lưu vết người đang sử dụng phần mềm
        public NhanVien NhanVienDangNhap { get; set; }
      
        // --- HÀM NẠP DỮ LIỆU TỪ TẤT CẢ REPOSITORY ---
        public void LoadAllData()
        {
            // 1. Nạp Nhân Viên & Khách Hàng (Từ StaffRepository)
            StaffRepository staffRepo = new StaffRepository();
            List<Nguoi> danhSachChung = staffRepo.GetAll();
            foreach (Nguoi ng in danhSachChung)
            {
                if (ng is NhanVien nv) DanhSachNV.Add(nv);
                else if (ng is KhachHang kh) DanhSachKH.Add(kh);
            }

            // 2. Nạp Hàng Hóa
            InventoryRepository invRepo = new InventoryRepository();
            DanhSachHang = invRepo.GetAll();

            // 3. Nạp Đối Tác (Nhà cung cấp)
            PartnerRepository partnerRepo = new PartnerRepository();
            DanhSachNCC = partnerRepo.GetAll();

            // 4. Nạp Dữ liệu Bán Hàng (Hóa Đơn, Voucher, Thẻ)
            SalesRepository salesRepo = new SalesRepository();
            DanhSachHD = salesRepo.GetHoaDons();
            DanhSachVoucher = salesRepo.GetVouchers();
            DanhSachTheTV = salesRepo.GetTheThanhViens();

            // 5. Nạp Phiếu Nhập
            PhieuNhapRepository pnRepo = new PhieuNhapRepository();
            DanhSachPhieuNhap = pnRepo.GetAll();

            // 6. Nạp Khuyến Mãi
            KhuyenMaiRepository kmRepo = new KhuyenMaiRepository();
            DanhSachKhuyenMai = kmRepo.GetAll();

            // 7. Nạp Voucher
            VoucherRepository vRepo = new VoucherRepository();
            DanhSachVoucher = vRepo.GetAll();

            // 8. Nạp Thẻ thành viên
            TheThanhVienRepository theRepo = new TheThanhVienRepository();
            DanhSachTheTV = theRepo.GetAll();

            SystemRepository sysRepo = new SystemRepository();
            DanhSachTaiKhoan = sysRepo.GetAllTaiKhoan();
            DanhSachCaLamViec = sysRepo.GetAllCaLamViec();
            
        }
    }
}
