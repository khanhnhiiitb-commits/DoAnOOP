using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Services
{
    public class QuanLyKhuyenMai
    {
        private List<ChuongTrinhKhuyenMai> danhSachCTKM;
        private List<Voucher> danhSachVoucher;

        public QuanLyKhuyenMai(List<ChuongTrinhKhuyenMai> dsKM, List<Voucher> dsVC)
        {
            this.danhSachCTKM = dsKM;
            this.danhSachVoucher = dsVC;
        }

        public void ThemChuongTrinh(ChuongTrinhKhuyenMai km)
        {
            if (km != null)
            {
                danhSachCTKM.Add(km);
            }
        }

        public bool CapNhatChuongTrinh(string maCTrinh, ChuongTrinhKhuyenMai kmMoi)
        {
            for (int i = 0; i < danhSachCTKM.Count; i++)
            {
                if (danhSachCTKM[i].MaCTKM == maCTrinh)
                {
                    danhSachCTKM[i] = kmMoi;
                    return true;
                }
            }
            return false;
        }

        // Tìm kiếm và trả về Voucher nếu còn hiệu lực
        public Voucher KiemTraVoucher(string maVoucher)
        {
            foreach (Voucher v in danhSachVoucher)
            {
                // Kiểm tra mã và hạn sử dụng (giả sử có hàm KiemTraHieuLuc trong lớp Voucher)
                if (v.MaVoucher == maVoucher && v.KiemTraHieuLuc())
                {
                    return v;
                }
            }
            return null;
        }

        // Tính toán tổng số tiền được giảm dựa trên các chương trình hiện có
        public double TinhTienGiam(HoaDon hd)
        {
            if (hd == null) return 0; // Thêm kiểm tra null để an toàn
            double tongGiam = 0;
    
                foreach (ChuongTrinhKhuyenMai km in danhSachCTKM)
                {
                    if (km.KiemTraDieuKien(hd))
                    {
                        tongGiam += km.TinhSoTienGiam(hd.TongTien);
                    }   
                }   
            return tongGiam;
        }

        // Hàm chính để áp dụng khuyến mãi vào hóa đơn
        public void ApDungKhuyenMai(HoaDon hd)
        {
            if (KiemTraDieuKienApDung(hd))
            {
                double soTienGiam = TinhTienGiam(hd);
                hd.TongTien -= soTienGiam;
                if (hd.TongTien < 0) hd.TongTien = 0;
            }
        }

        // Kiểm tra điều kiện chung của hóa đơn (ví dụ: hóa đơn trên 100k mới tính KM)
        public bool KiemTraDieuKienApDung(HoaDon hd)
        {
            return hd != null && hd.TongTien > 0;
        }

        
        
    }
}   