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

        // --- KHAI BÁO BIẾN PRIVATE (ĐÓNG GÓI) ---
        private List<HangHoa> danhSachHang;
        private List<NhanVien> danhSachNV;
        private List<HoaDon> danhSachHD;
        private List<KhachHang> danhSachKH;
        private List<NhaCungCap> danhSachNCC;
        private List<BangChamCong> danhSachBCM;
        private List<PhieuNhap> danhSachPhieuNhap;
        private List<ChuongTrinhKhuyenMai> danhSachKhuyenMai;
        private List<Voucher> danhSachVoucher;
        private List<TheThanhVien> danhSachTheTV;
        private List<TaiKhoan> danhSachTaiKhoan;
        private List<KeHang> danhSachKeHang;
        private List<CaLamViec> danhSachCaLamViec;

        private NhanVien nhanVienDangNhap;

        private DataStorage()
        {
            this.danhSachHang = new List<HangHoa>();
            this.danhSachNV = new List<NhanVien>();
            this.danhSachHD = new List<HoaDon>();
            this.danhSachKH = new List<KhachHang>();
            this.danhSachNCC = new List<NhaCungCap>();
            this.danhSachBCM = new List<BangChamCong>();
            this.danhSachPhieuNhap = new List<PhieuNhap>();
            this.danhSachKhuyenMai = new List<ChuongTrinhKhuyenMai>();
            this.danhSachVoucher = new List<Voucher>();
            this.danhSachTheTV = new List<TheThanhVien>();
            this.danhSachKeHang = new List<KeHang>();
            this.danhSachTaiKhoan = new List<TaiKhoan>();
            this.danhSachCaLamViec = new List<CaLamViec>();

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

        // --- CÁC THUỘC TÍNH PUBLIC (GIAO TIẾP) ---
        public List<HangHoa> DanhSachHang { get { return danhSachHang; } set { danhSachHang = value; } }
        public List<NhanVien> DanhSachNV { get { return danhSachNV; } set { danhSachNV = value; } }
        public List<HoaDon> DanhSachHD { get { return danhSachHD; } set { danhSachHD = value; } }
        public List<KhachHang> DanhSachKH { get { return danhSachKH; } set { danhSachKH = value; } }
        public List<NhaCungCap> DanhSachNCC { get { return danhSachNCC; } set { danhSachNCC = value; } }
        public List<BangChamCong> DanhSachBCM { get { return danhSachBCM; } set { danhSachBCM = value; } }
        public List<PhieuNhap> DanhSachPhieuNhap { get { return danhSachPhieuNhap; } set { danhSachPhieuNhap = value; } }
        public List<ChuongTrinhKhuyenMai> DanhSachKhuyenMai { get { return danhSachKhuyenMai; } set { danhSachKhuyenMai = value; } }
        public List<Voucher> DanhSachVoucher { get { return danhSachVoucher; } set { danhSachVoucher = value; } }
        public List<TheThanhVien> DanhSachTheTV { get { return danhSachTheTV; } set { danhSachTheTV = value; } }
        public List<TaiKhoan> DanhSachTaiKhoan { get { return danhSachTaiKhoan; } set { danhSachTaiKhoan = value; } }
        public List<KeHang> DanhSachKeHang { get { return danhSachKeHang; } set { danhSachKeHang = value; } }
        public List<CaLamViec> DanhSachCaLamViec { get { return danhSachCaLamViec; } set { danhSachCaLamViec = value; } }

        // Lưu vết người đang sử dụng phần mềm
        public NhanVien NhanVienDangNhap { get { return nhanVienDangNhap; } set { nhanVienDangNhap = value; } }

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

            // 4. Nạp Kệ Hàng
            KeHangRepository keHangRepo = new KeHangRepository();
            DanhSachKeHang = keHangRepo.GetAll();

            // 5. Nạp Phiếu Nhập
            PhieuNhapRepository pnRepo = new PhieuNhapRepository();
            DanhSachPhieuNhap = pnRepo.GetAll();

            // 6. Nạp Thẻ Thành Viên
            TheThanhVienRepository theRepo = new TheThanhVienRepository();
            DanhSachTheTV = theRepo.GetAll();

            // 7. Nạp Voucher
            VoucherRepository vRepo = new VoucherRepository();
            List<Voucher> dsVoucherFile = vRepo.GetAll();
            foreach (Voucher v in dsVoucherFile)
            {
                DanhSachVoucher.Add(v);
            }

            // 8. Nạp Khuyến Mãi
            KhuyenMaiRepository kmRepo = new KhuyenMaiRepository();
            List<ChuongTrinhKhuyenMai> dsKmFile = kmRepo.GetAll();
            foreach (ChuongTrinhKhuyenMai km in dsKmFile)
            {
                DanhSachKhuyenMai.Add(km);
            }

            // 9. Nạp Sales (Hóa Đơn & Voucher gộp)
            SalesRepository salesRepo = new SalesRepository();
            DanhSachHD = salesRepo.GetHoaDons();

            // ==========================================
            // THÊM ĐOẠN NÀY ĐỂ TÍNH TỔNG TIỀN NGAY LẬP TỨC
            foreach (HoaDon hd in DanhSachHD)
            {
                hd.TinhTongTien();
            }
            // ==========================================

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
