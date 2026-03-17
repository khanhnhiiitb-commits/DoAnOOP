using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Services;


namespace QuanLySieuThi.Services
{
    public class QuanLyBanHang
    {
        private List<HoaDon> danhSachHoaDon;
        private List<HangHoa> danhSachHangHoa;
        public List<HoaDon> DanhSachHoaDon { get {return danhSachHoaDon;} }

        public QuanLyBanHang(List<HangHoa> khoHang)
        {
            danhSachHoaDon = new List<HoaDon>();
            danhSachHangHoa = khoHang;
        }

        // 1. Tạo hóa đơn mới 
        public HoaDon TaoHoaDon(NhanVien nv, KhachHang kh)
        {
            string maHD = "HD" + (danhSachHoaDon.Count + 1).ToString("D3");
            HoaDon hdMoi = new HoaDon(maHD, nv.MaNV, kh.MaKH);
            danhSachHoaDon.Add(hdMoi);
            return hdMoi;
        }

        // 2. Thêm chi tiết 
        public string ThemChiTietHoaDon(HoaDon hd, HangHoa hh, int soLuong)
        {
            if (hh.SoLuongTon < soLuong)
                return "Lỗi: Số lượng tồn kho không đủ!";

            // Kiểm tra xem món hàng này đã có trong hóa đơn chưa (để cộng dồn thay vì thêm dòng mới)
            foreach (var item in hd.DanhSachChiTiet)
            {
                if (item.MaHH == hh.MaHH)
                {
                    item.SoLuongMua += soLuong;
                    hh.SoLuongTon -= soLuong;
                    hd.TinhTongTien();
                    return "Thành công: Đã cộng dồn số lượng.";
                }
            }

            string maCT = hd.MaHD + "-" + (hd.DanhSachChiTiet.Count + 1);
            ChiTietHoaDon ct = new ChiTietHoaDon(maCT, hh.MaHH, soLuong, hh.DonGia);
            
            hd.ThemChiTiet(ct);
            hh.SoLuongTon -= soLuong;
            return "Thành công: Đã thêm món hàng.";
        }

        // 3. Xóa chi tiết 
        public bool XoaChiTietHoaDon(HoaDon hd, string maHH)
        {
            for (int i = 0; i < hd.DanhSachChiTiet.Count; i++)
            {
                if (hd.DanhSachChiTiet[i].MaHH == maHH)
                {
                    int soLuongHoan = hd.DanhSachChiTiet[i].SoLuongMua;

                    foreach (HangHoa hh in danhSachHangHoa) 
                    {
                        if (hh.MaHH == maHH)
                        {
                            hh.SoLuongTon += soLuongHoan; 
                            break;
                        }
                    }
                    hd.DanhSachChiTiet.RemoveAt(i);
                    hd.TinhTongTien();
                    return true;
                }
            }
            return false;
        }

        // 4. Áp dụng Voucher (Sử dụng Đa hình)
        public string ApDungVoucher(HoaDon hd, Voucher v)
        {
            if (v == null) return "Lỗi: Voucher không tồn tại!";
            if (hd.DaApDungVoucher) return "Lỗi: Hóa đơn này đã được áp dụng voucher trước đó!";

            if (v.KiemTraHieuLuc())
            {
        
                // Đối tượng v (dù là Tiền mặt hay Phần trăm) sẽ tự biết cách tính số tiền giảm.
                double soTienGiam = v.TinhSoTienGiam(hd.TongTien);

                hd.TongTien -= soTienGiam;
                if (hd.TongTien < 0) hd.TongTien = 0;

                hd.DaApDungVoucher = true; 
                return $"Thành công: Đã giảm {soTienGiam:N0} VNĐ.";
            }
            return "Lỗi: Voucher không hiệu lực hoặc hết hạn.";
        }

        // 5. Thanh toán và Tích điểm
        public string ThanhToan(HoaDon hd, double soTienKhachDua, KhachHang kh, QuanLyDoiTac doiTacService)
        {
            if (soTienKhachDua < hd.TongTien)
                return "Không đủ tiền";

            hd.ThanhToan(); 
            double tienThua = soTienKhachDua - hd.TongTien;

            //gọi lệnh sang bên QuanLyDoiTac
            if (kh != null)
            {
                doiTacService.TichDiem(kh.MaKH, hd.TongTien);
            }

            return tienThua.ToString(); 
        }

        // 6. Hủy hóa đơn
        public bool HuyHoaDon(string maHD)
        {
            for (int i = 0; i < danhSachHoaDon.Count; i++)
            {
                if (danhSachHoaDon[i].MaHD == maHD)
                {
                    danhSachHoaDon.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public string LayNoiDungHoaDon(HoaDon hd)
        {
            string content = "---------- HÓA ĐƠN ----------\n";
            content += $"Mã HD: {hd.MaHD}\nNgày: {hd.NgayTao}\n";
            content += "-----------------------------\n";
            foreach (var ct in hd.DanhSachChiTiet)
            {
                content += $"{ct.MaHH} x {ct.SoLuongMua} = {ct.ThanhTien}\n";
            }
            content += "-----------------------------\n";
            content += $"TỔNG CỘNG: {hd.TongTien}\n";
            return content;
        }
    }
}