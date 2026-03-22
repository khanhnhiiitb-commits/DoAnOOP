using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Products;

namespace QuanLySieuThi.Services
{
    public class QuanLyKho
    {
        private List<HangHoa> danhSachHang;
        private List<KeHang> danhSachKe;

        public QuanLyKho(List<HangHoa> dsHang, List<KeHang> dsKe)
        {
            this.danhSachHang = dsHang;
            this.danhSachKe = dsKe;
        }

        // Thêm hàng hóa mới vào danh sách
        public void ThemHangHoa(HangHoa hh)
        {
            if (hh != null)
            {
                danhSachHang.Add(hh);
            }
        }

        // Cập nhật thông tin hàng hóa dựa trên mã
        public bool CapNhatThongTin(string maHH, HangHoa hhMoi)
        {
            for (int i = 0; i < danhSachHang.Count; i++)
            {
                if (danhSachHang[i].MaHH == maHH)
                {
                    danhSachHang[i] = hhMoi;
                    return true;
                }
            }
            return false;
        }

        // Xóa hàng hóa khỏi danh sách (Xuất hàng khỏi kho hoàn toàn)
        public bool XuatHangHoa(string maHH)
        {
            for (int i = 0; i < danhSachHang.Count; i++)
            {
                if (danhSachHang[i].MaHH == maHH)
                {
                    danhSachHang.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        // Tìm kiếm hàng hóa theo từ khóa (Mã hoặc Tên) - Trả về danh sách kết quả
        public List<HangHoa> TimKiemHangHoa(string keyword)
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            foreach (HangHoa hh in danhSachHang)
            {
                // Kiểm tra xem từ khóa có nằm trong Mã hoặc Tên không
                if (hh.MaHH.Contains(keyword) || hh.TenHang.Contains(keyword))
                {
                    ketQua.Add(hh);
                }
            }
            return ketQua;
        }

        // Kiểm tra số lượng tồn kho của một mặt hàng cụ thể
        public int KiemTraTonKho(string maHH)
        {
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH)
                {
                    return hh.SoLuongTon;
                }
            }
            return 0; // Không tìm thấy hàng
        }

        // Cập nhật số lượng (Nhập thêm hoặc Bán bớt)
        public bool CapNhatSoLuong(string maHH, int soLuongThayDoi)
        {
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH)
                {
                    hh.SoLuongTon += soLuongThayDoi;
                    // Đảm bảo số lượng không nhỏ hơn 0
                    if (hh.SoLuongTon < 0) hh.SoLuongTon = 0;
                    return true;
                }
            }
            return false;
        }

        // Sắp xếp hàng hóa vào một Kệ hàng (Association giữa Hàng và Kệ)
        public bool SapXepKeHang(string maHH, string maKe)
        {
            // Kiểm tra hàng có tồn tại không
            HangHoa hangTimThay = null;
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.MaHH == maHH) { hangTimThay = hh; break; }
            }

            // Kiểm tra kệ có tồn tại không
            KeHang keTimThay = null;
            foreach (KeHang ke in danhSachKe)
            {
                if (ke.MaKe == maKe) { keTimThay = ke; break; }
            }

            if (hangTimThay != null && keTimThay != null)
            {
                hangTimThay.MaKeHang = maKe; // Gán mã kệ vào hàng hóa
                return true;
            }
            return false;
        }

        // Lấy danh sách các mặt hàng sắp hết (ví dụ dưới 10 đơn vị)
        public List<HangHoa> LayDSHangSapHet()
        {
            List<HangHoa> dsSapHet = new List<HangHoa>();
            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.SoLuongTon < 10)
                {
                    dsSapHet.Add(hh);
                }
            }
            return dsSapHet;
        }
    }
}