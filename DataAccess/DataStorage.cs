using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Models;
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
        private static DataStorage instance;

        private DataStorage()
        {
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

            LoadAllData();
        }

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

        // --- HÀM NẠP DỮ LIỆU CHUẨN JSON ---
        public void LoadAllData()
        {
            // BƯỚC 0: Xóa sạch danh sách cũ để tránh lỗi nhân đôi dữ liệu nếu gọi lại hàm này
            DanhSachNV.Clear();
            DanhSachKH.Clear();
            DanhSachNCC.Clear();
            DanhSachVoucher.Clear();
            DanhSachKhuyenMai.Clear();

            // 1. Nạp Nhân Viên & Khách Hàng (Từ database_nhanvien.json)
            StaffRepository staffRepo = new StaffRepository();
            List<Nguoi> dsNhanSu = staffRepo.GetAll();
            foreach (Nguoi ng in dsNhanSu)
            {
                if (ng is NhanVien nv) DanhSachNV.Add(nv);
                else if (ng is KhachHang kh) DanhSachKH.Add(kh);
            }

            // 2. Nạp Đối Tác (Từ database_partner.json)
            // 2. Nạp Đối Tác (Từ database_partner.json)
            PartnerRepository partnerRepo = new PartnerRepository();
            PartnerData pData = partnerRepo.GetAllData();

            if (pData != null)
            {
                if (pData.NhaCungCaps != null)
                {
                    foreach (NhaCungCap ncc in pData.NhaCungCaps)
                    {
                        DanhSachNCC.Add(ncc);
                    }
                }

                if (pData.KhachHangs != null)
                {
                    foreach (KhachHang kh in pData.KhachHangs)
                    {
                        DanhSachKH.Add(kh);
                    }
                }
            }

            // 3. Nạp Hàng Hóa
            InventoryRepository hangHoaRepo = new InventoryRepository();
            DanhSachHang = hangHoaRepo.GetAll();

            // 4. Nạp Kệ Hàng (Đã bổ sung)
            KeHangRepository keHangRepo = new KeHangRepository();
            DanhSachKeHang = keHangRepo.GetAll();

            // 5. Nạp Phiếu Nhập
            PhieuNhapRepository pnRepo = new PhieuNhapRepository();
            DanhSachPhieuNhap = pnRepo.GetAll();

            // 6. Nạp Thẻ Thành Viên
            TheThanhVienRepository theRepo = new TheThanhVienRepository();
            DanhSachTheTV = theRepo.GetAll();

            // 7. Nạp Voucher (Từ file voucher độc lập)
            VoucherRepository vRepo = new VoucherRepository();
            List<Voucher> dsVoucherFile = vRepo.GetAll();
            foreach (Voucher v in dsVoucherFile)
            {
                DanhSachVoucher.Add(v);
            }

            // 8. Nạp Khuyến Mãi (Từ file khuyến mãi độc lập)
            KhuyenMaiRepository kmRepo = new KhuyenMaiRepository();
            List<ChuongTrinhKhuyenMai> dsKmFile = kmRepo.GetAll();
            foreach (ChuongTrinhKhuyenMai km in dsKmFile)
            {
                DanhSachKhuyenMai.Add(km);
            }

            // 9. Nạp Sales (Hóa Đơn & Voucher gộp)
            SalesRepository salesRepo = new SalesRepository();
            DanhSachHD = salesRepo.GetHoaDons();

            // Lấy thêm Voucher từ file Sales và gộp chung vào DanhSachVoucher
            List<Voucher> vcSales = salesRepo.GetVouchers();
            foreach (Voucher v in vcSales)
            {
                DanhSachVoucher.Add(v);
            }

            // 10. Nạp System (Tài khoản & Ca làm việc)
            SystemRepository sysRepo = new SystemRepository();
            DanhSachTaiKhoan = sysRepo.GetAllTaiKhoan();
            DanhSachCaLamViec = sysRepo.GetAllCaLamViec();
        }
    }
}
