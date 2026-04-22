using System;
using System.IO;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Data
{
    public class StaffRepository
    {
        private readonly string filePath = "Data/database_nhanvien.txt";

        public List<Nguoi> GetAll()
        {
            List<Nguoi> danhSach = new List<Nguoi>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                Nguoi p = MapLineToEntity(line);
                if (p != null) danhSach.Add(p);
            }
            return danhSach;
        }

        public void Save(List<Nguoi> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (Nguoi p in danhSach)
            {
                lines.Add(MapEntityToLine(p));
            }
            File.WriteAllLines(filePath, lines);
        }

        private Nguoi MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 7) return null;

            string loai = parts[0];

            if (loai == "NV")
            {
                NhanVien nv = new NhanVien();
                // Gán thông tin lớp cha (Nguoi) - Dùng Property thay cho hàm Set
                nv.Ma = parts[1];
                nv.HoTen = parts[2];
                nv.NgaySinh = DateTime.Parse(parts[3]);
                nv.GioiTinh = bool.Parse(parts[4]);
                nv.SoDienThoai = parts[5];
                nv.DiaChi = parts[6];

                // Gán thông tin lớp con (NhanVien)
                nv.MaNV = parts[7];
                nv.ChucVu = parts[8];
                nv.LuongCB = double.Parse(parts[9]);
                nv.NgayVaoLam = DateTime.Parse(parts[10]);
                nv.MaCa = parts[11]; // Đổi từ MaCaLV sang MaCa cho khớp Model
                //nv.Taikhoan = parts[12];
                return nv;
            }

            if (loai == "KH")
            {
                KhachHang kh = new KhachHang();
                kh.Ma = parts[1];
                kh.HoTen = parts[2];
                kh.NgaySinh = DateTime.Parse(parts[3]);
                kh.GioiTinh = bool.Parse(parts[4]);
                kh.SoDienThoai = parts[5];
                kh.DiaChi = parts[6];

                kh.MaKH = parts[7];
                kh.DiemTichLuy = int.Parse(parts[8]);
                
                // Khởi tạo đối tượng thẻ thành viên nếu có mã
                if (parts.Length > 9 && parts[9] != "None" && !string.IsNullOrEmpty(parts[9]))
                {
                    kh.TheTV = new TheThanhVien(parts[9]);
                }
                return kh;
            }

            return null;
        }

        private string MapEntityToLine(Nguoi p)
        {
            // Format ngày tháng chuẩn YYYY-MM-DD
            string sSinh = p.NgaySinh.ToString("yyyy-MM-dd");
            string baseInfo = $"{p.Ma}|{p.HoTen}|{sSinh}|{p.GioiTinh}|{p.SoDienThoai}|{p.DiaChi}";

            if (p is NhanVien nv)
            {
                string sVao = nv.NgayVaoLam.ToString("yyyy-MM-dd");
                return $"NV|{baseInfo}|{nv.MaNV}|{nv.ChucVu}|{nv.LuongCB}|{sVao}|{nv.MaCa}";
            }

            if (p is KhachHang kh)
            {
                string maThe = kh.TheTV != null ? kh.TheTV.MaThe : "None";
                return $"KH|{baseInfo}|{kh.MaKH}|{kh.DiemTichLuy}|{maThe}";
            }

            return "";
        }
    }
}