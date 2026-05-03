using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;

namespace QuanLySieuThi.Data
{
    public class StaffRepository
    {
        private readonly string filePath = "DataAccess/DatabaseFile/database_nhanvien.txt";

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
            if (parts.Length < 12) return null;

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
                if (parts.Length > 12 && !string.IsNullOrEmpty(parts[12]))
                {
                    string[] accParts = parts[12].Split('-'); // Chẻ chuỗi bằng dấu gạch ngang
                    if (accParts.Length >= 3)
                    {
                        nv.Taikhoan = new TaiKhoan
                        {
                            TenDangNhap = accParts[0],
                            MatKhau = accParts[1],
                            UserRole = new Role { MaRole = accParts[2] }
                        };
                    }
                }
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
            string sSinh = p.NgaySinh.ToString("yyyy-MM-dd");
            string baseInfo = $"{p.Ma}|{p.HoTen}|{sSinh}|{p.GioiTinh}|{p.SoDienThoai}|{p.DiaChi}";
            if (p is NhanVien nv)
            {
                string sVao = nv.NgayVaoLam.ToString("yyyy-MM-dd");

                // Xử lý chuỗi Tài khoản (nếu không có thì ghi là "None")
                string sTaiKhoan = "None";
                if (nv.Taikhoan != null && nv.Taikhoan.UserRole != null)
                {
                    // Định dạng: Username-Password-RoleID
                    sTaiKhoan = $"{nv.Taikhoan.TenDangNhap}-{nv.Taikhoan.MatKhau}-{nv.Taikhoan.UserRole.MaRole}";
                }
                return $"NV|{baseInfo}|{nv.MaNV}|{nv.ChucVu}|{nv.LuongCB}|{sVao}|{nv.MaCa}|{sTaiKhoan}";
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