using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Services
{
    public class QuanLyDoiTac
    {
        // Đảm bảo tính đóng gói: private fields và public properties (chỉ get)
        private List<KhachHang> danhSachKH;
        private List<NhaCungCap> danhSachNCC;

        public List<KhachHang> DanhSachKH 
        { 
            get {return danhSachKH;} 
        }
        public List<NhaCungCap> DanhSachNCC 
        { 
            get {return danhSachNCC;} 
        }

        public QuanLyDoiTac()
        {
            danhSachKH = new List<KhachHang>();
            danhSachNCC = new List<NhaCungCap>();
        }

        // 1. Thêm khách hàng mới
        public bool ThemKhachHang(KhachHang kh)
        {
            // Kiểm tra trùng mã 
            foreach (var item in danhSachKH)
            {
                if (item.MaKH == kh.MaKH) return false; 
            }
            danhSachKH.Add(kh);
            return true;
        }

        // 2. Đăng ký thành viên (Cấp thẻ)
        public string DangKyThanhVien(KhachHang kh, string maTheMoi)
        {
            if (kh.TheTV != null) return "Khách hàng này đã có thẻ thành viên rồi!";
            
            // Cấp thẻ mới
            kh.TheTV = new TheThanhVien(maTheMoi);
            return "Đăng ký thẻ thành viên thành công!";
        }

        // 3. Tích điểm (Cứ 10k được 1 điểm)
        public bool TichDiem(string maKH, double tongTien)
        {
            foreach (var kh in danhSachKH)
            {
                if (kh.MaKH == maKH)
                {
                    int diemCong = (int)(tongTien / 10000);
                    kh.DiemTichLuy += diemCong;
                    return true;
                }
            }
            return false;
        }

        // 4. Trừ điểm (Khi khách đổi quà hoặc dùng điểm thanh toán)
        public string TruDiem(string maKH, int diemDoi)
        {
            foreach (var kh in danhSachKH)
            {
                if (kh.MaKH == maKH)
                {
                    if (kh.DiemTichLuy >= diemDoi)
                    {
                        kh.DiemTichLuy -= diemDoi;
                        return "Trừ điểm thành công!";
                    }
                    return "Số điểm tích lũy không đủ!";
                }
            }
            return "Không tìm thấy khách hàng!";
        }

        // 5. Thêm nhà cung cấp
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            foreach (var item in danhSachNCC)
            {
                if (item.MaNCC == ncc.MaNCC) return false;
            }
            danhSachNCC.Add(ncc);
            return true;
        }

        // 6. Cập nhật thông tin NCC
        public bool CapNhatThongTinNCC(string maNCC, string tenMoi, string sdtMoi, string emailMoi)
        {
            foreach (var ncc in danhSachNCC)
            {
                if (ncc.MaNCC == maNCC)
                {
                    ncc.TenNCC = tenMoi;
                    ncc.SoDienThoai = sdtMoi;
                    ncc.Email = emailMoi;
                    return true;
                }
            }
            return false;
        }
    }
}