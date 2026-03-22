using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLySieuThi.Data
{
    public class SystemRepository
    {
        private readonly string filePath = "Data/database_system.txt";

        // --- TAI KHOAN ---
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            if (!File.Exists(filePath)) return list;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[0] == "TK") list.Add(MapLineToTaiKhoan(parts));
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
                string[] parts = line.Split('|');
                if (parts[0] == "CA") list.Add(MapLineToCaLamViec(parts));
            }
            return list;
        }

        // --- PHIEU NHAP (Master-Detail) ---
        public List<PhieuNhap> GetAllPhieuNhap()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();
            // Logic tuong tu SalesRepository de doc Master-Detail
            return list;
        }

        // --- LUU TOAN BO HE THONG ---
        public void SaveSystemData(List<TaiKhoan> tkList, List<CaLamViec> caList)
        {
            List<string> lines = new List<string>();
            foreach (TaiKhoan tk in tkList) lines.Add(MapTaiKhoanToLine(tk));
            foreach (CaLamViec ca in caList) lines.Add(MapCaToLine(ca));

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
        string tenRoleTuFile = p[3]; 
        Role roleTuongUng = LayRoleHeThong(tenRoleTuFile);
        TaiKhoan tk = new TaiKhoan(p[1], p[2], roleTuongUng, bool.Parse(p[4]));
        return tk; 
        }

        private string MapTaiKhoanToLine(TaiKhoan tk)
        {
            string tenRole = (tk.UserRole != null) ? tk.UserRole.TenRole : "NhanVien";
            return "TK|" + tk.TenDangNhap + "|" + tk.MatKhau + "|" + tenRole + "|" + tk.TrangThai;
        }

        private CaLamViec MapLineToCaLamViec(string[] p)
        {
            return new CaLamViec(p[1], p[2], p[3], p[4]);
        }

        private string MapCaToLine(CaLamViec ca)
        {
            return "CA|" + ca.MaCa + "|" + ca.TenCa + "|" + ca.GioBatDau + "|" + ca.GioKetThuc;
        }

        private string FormatDate(DateTime dt)
        {
            // Ghep chuoi ngay thang thu cong
            return dt.Year + "-" + dt.Month + "-" + dt.Day;
        }
    }
}