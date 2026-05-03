using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLySieuThi.Data
{
    public class SalesRepository
    {
        private readonly string filePath = "DataAccess/DatabaseFile/database_sales.txt";

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
        public List<TheThanhVien> GetTheThanhViens()
        {
            List<TheThanhVien> danhSach = new List<TheThanhVien>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('|');
                if (parts[0] == "TV")
                {
                    danhSach.Add(MapLineToTheThanhVien(parts));
                }
            }
            return danhSach;
        }

        public List<Voucher> GetVouchers()
        {
            List<Voucher> danhSach = new List<Voucher>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split('|');
                if (parts[0] == "VC")
                {
                    danhSach.Add(MapLineToVoucher(parts));
                }
            }
            return danhSach;
        }
        private TheThanhVien MapLineToTheThanhVien(string[] p)
        {
            TheThanhVien tv = new TheThanhVien();
            tv.MaThe = p[1];
            tv.NgayDangKy = DateTime.Parse(p[2]);
            tv.NapDiemTuFile(int.Parse(p[3]));
            tv.TrangThai = bool.Parse(p[4]); 
            return tv;
        }

        private Voucher MapLineToVoucher(string[] p)
        {
            // Dựa theo cấu trúc bạn nối chuỗi ở MapVoucherToLine:
            // p[0]=VC | p[1]=Ma | p[2]=Ten | p[3]=NgayBD | p[4]=NgayKT | p[5]=DK | p[6]=TrangThai | p[7]=Loai | p[8]=GiaTri1 | p[9]=GiaTri2

            string loaiVoucher = p[7];

            if (loaiVoucher == "PhanTram")
            {
                VoucherPhanTram vp = new VoucherPhanTram();
                vp.MaVoucher = p[1];
                vp.TenVoucher = p[2];
                vp.NgayBatDau = DateTime.Parse(p[3]);
                vp.NgayKetThuc = DateTime.Parse(p[4]);
                vp.DKApDung = (p[5]);
                vp.TrangThai = bool.Parse(p[6]);
                vp.PhanTramGiam = float.Parse(p[8]);
                vp.GiamToiDa = double.Parse(p[9]);
                return vp;
            }
            else // Trường hợp "TienMat"
            {
                VoucherTienMat vt = new VoucherTienMat();
                vt.MaVoucher = p[1];
                vt.TenVoucher = p[2];
                vt.NgayBatDau = DateTime.Parse(p[3]);
                vt.NgayKetThuc = DateTime.Parse(p[4]);
                vt.DKApDung = (p[5]);
                vt.TrangThai = bool.Parse(p[6]);
                vt.SoTienGiamCoDinh = double.Parse(p[8]);
                return vt;
            }
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


        private string MapVoucherToLine(Voucher vc)
        {
            string nbd = vc.NgayBatDau.ToString("yyyy-MM-dd");
            string nkt = vc.NgayKetThuc.ToString("yyyy-MM-dd");
            string baseData = $"VC|{vc.MaVoucher}|{vc.TenVoucher}|{nbd}|{nkt}|{vc.DKApDung}|{vc.TrangThai}";

            if (vc is VoucherPhanTram vp)
            {
                return baseData + $"|PhanTram|{vp.PhanTramGiam}|{vp.GiamToiDa}";
            }
            else if (vc is VoucherTienMat vt)
            {
                return baseData + $"|TienMat|{vt.SoTienGiamCoDinh}|0";
            }

            return baseData;
        }       
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
    
