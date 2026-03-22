using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLySieuThi.Data
{
    public class SalesRepository
    {
        private readonly string filePath = "Data/database_sales.txt";

        // 1. Lấy danh sách Hóa đơn (bao gồm cả các Chi tiết bên trong)
        public List<HoaDon> GetHoaDons()
        {
            List<HoaDon> danhSach = new List<HoaDon>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            HoaDon currentHD = null;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                string loai = parts[0];

                if (loai == "HD")
                {
                    currentHD = MapLineToHoaDon(parts);
                    danhSach.Add(currentHD);
                }
                else if (loai == "CT" && currentHD != null)
                {
                    currentHD.ThemChiTiet(MapLineToChiTiet(parts));
                }
            }
            return danhSach;
        }

        // 2. Lưu toàn bộ dữ liệu Sales (Hóa đơn, Thẻ, Voucher)
        public void SaveAll(List<HoaDon> hdList, List<TheThanhVien> tvList, List<Voucher> vcList)
        {
            List<string> lines = new List<string>();

            // Lưu Hóa đơn và Chi tiết
            foreach (HoaDon hd in hdList)
            {
                lines.Add(MapHoaDonToLine(hd));
                foreach (ChiTietHoaDon ct in hd.DanhSachChiTiet)
                {
                    lines.Add(MapChiTietToLine(ct));
                }
            }

            // Lưu Thẻ thành viên
            foreach (TheThanhVien tv in tvList)
            {
                lines.Add(MapTheToLine(tv));
            }

            // Lưu Voucher
            foreach (Voucher vc in vcList)
            {
                lines.Add(MapVoucherToLine(vc));
            }

            File.WriteAllLines(filePath, lines.ToArray());
        }

        // ---------------- PRIVATE HELPER METHODS (Data Mapping) ----------------

        private HoaDon MapLineToHoaDon(string[] p)
        {
            HoaDon hd = new HoaDon();
            hd.MaHD = p[1];
            hd.NgayTao = DateTime.Parse(p[2]);
            if (p[3] == "True") hd.ThanhToan();
            return hd;
        }

        private ChiTietHoaDon MapLineToChiTiet(string[] p)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon();
            ct.MaCTHD = p[1];
            ct.SoLuongMua = int.Parse(p[2]);
            ct.GiaBan = double.Parse(p[3]);
            return ct;
        }

        private string MapHoaDonToLine(HoaDon hd)
        {
            string ngay = hd.NgayTao.Year + "-" + hd.NgayTao.Month + "-" + hd.NgayTao.Day;
            return "HD|" + hd.MaHD + "|" + ngay + "|" + hd.TrangThaiTT;
        }

        private string MapChiTietToLine(ChiTietHoaDon ct)
        {
            return "CT|" + ct.MaCTHD + "|" + ct.SoLuongMua + "|" + ct.GiaBan;
        }

        private string MapTheToLine(TheThanhVien tv)
        {
            string ngay = tv.NgayDangKy.Year + "-" + tv.NgayDangKy.Month + "-" + tv.NgayDangKy.Day;
            return "TV|" + tv.MaThe + "|" + ngay + "|" + tv.DiemTichLuy + "|" + tv.TrangThai;
        }

    }
}
    
