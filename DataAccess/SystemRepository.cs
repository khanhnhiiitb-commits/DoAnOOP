using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLySieuThi.Data
{
    public class SystemRepository
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_system.txt";
        // --- TAI KHOAN ---
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            if (!File.Exists(filePath)) return list;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue; // Bỏ qua dòng trống

                string[] parts = line.Split('|');
                if (parts[0] == "TK")
                {
                    TaiKhoan tk = MapLineToTaiKhoan(parts);
                    if (tk != null) list.Add(tk);
                }
            }
            return list;
        }

        // --- CA LAM VIEC ---
        public List<CaLamViec> GetAllCaLamViec()
        {
            List<CaLamViec> list = new List<CaLamViec>();
            if (!File.Exists(filePath)) return list;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue; // Bỏ qua dòng trống

                string[] parts = line.Split('|');
                if (parts[0] == "CA")
                {
                    CaLamViec ca = MapLineToCaLamViec(parts);
                    if (ca != null) list.Add(ca);
                }
            }
            return list;
        }

        // --- LUU TOAN BO HE THONG ---
        // Hàm này gom chung Save vì Tài Khoản và Ca Làm Việc lưu chung 1 file
        public void SaveSystemData(List<TaiKhoan> tkList, List<CaLamViec> caList)
        {
            List<string> lines = new List<string>();

            foreach (TaiKhoan tk in tkList)
            {
                lines.Add(MapTaiKhoanToLine(tk));
            }

            foreach (CaLamViec ca in caList)
            {
                lines.Add(MapCaToLine(ca));
            }

            File.WriteAllLines(filePath, lines.ToArray());
        }

        // ---------------- PRIVATE HELPER METHODS ----------------

        private Role LayRoleHeThong(string tenRole)
        {
            if (tenRole == "Admin")
                return new Role("R01", "Admin", "Toàn quyền hệ thống");

            return new Role("R02", "NhanVien", "Nhân viên bán hàng");
        }

        private TaiKhoan MapLineToTaiKhoan(string[] p)
        {
            // Format an toàn: TK | TenDangNhap | MatKhau | TenRole | TrangThai
            if (p.Length < 5) return null;

            string tenRoleTuFile = p[3];
            Role roleTuongUng = LayRoleHeThong(tenRoleTuFile);
            TaiKhoan tk = new TaiKhoan(p[1], p[2], roleTuongUng, bool.Parse(p[4]));
            return tk;
        }

        private string MapTaiKhoanToLine(TaiKhoan tk)
        {
            string tenRole = (tk.UserRole != null) ? tk.UserRole.TenRole : "NhanVien";
            return $"TK|{tk.TenDangNhap}|{tk.MatKhau}|{tenRole}|{tk.TrangThai}";
        }

        private CaLamViec MapLineToCaLamViec(string[] p)
        {
            // Format an toàn: CA | MaCa | TenCa | GioBatDau | GioKetThuc
            if (p.Length < 5) return null;

            return new CaLamViec(p[1], p[2], TimeSpan.Parse(p[3]), TimeSpan.Parse(p[4]));
        }

        private string MapCaToLine(CaLamViec ca)
        {
            return $"CA|{ca.MaCa}|{ca.TenCa}|{ca.GioBatDau}|{ca.GioKetThuc}";
        }
    }
}