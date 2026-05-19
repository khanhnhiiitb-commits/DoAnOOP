using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;

namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class TheThanhVienRepository
    {
        private string filePath = @"DataAccess\DatabaseFile\database_thethanhvien.txt";

        public List<TheThanhVien> GetAll()
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
                    TheThanhVien tv = new TheThanhVien();
                    tv.MaThe = parts[1];
                    tv.NgayDangKy = DateTime.Parse(parts[2]);
                    tv.NapDiemTuFile(int.Parse(parts[3]));
                    bool trangThaiTuFile = bool.Parse(parts[4]);

                    if (trangThaiTuFile == true)
                    {
                        tv.KichHoatThe(); // Dùng hàm public của class để set trạng thái
                    }
                    else
                    {
                        tv.KhoaThe();
                    }

                    danhSach.Add(tv);
                }
            }
            return danhSach;
        }

        public void Save(List<TheThanhVien> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (TheThanhVien tv in danhSach)
            {
                string ngay = tv.NgayDangKy.ToString("yyyy-MM-dd");
                lines.Add($"TV|{tv.MaThe}|{ngay}|{tv.DiemTichLuy}|{tv.TrangThai}");
            }
            File.WriteAllLines(filePath, lines.ToArray());
        }
    }
}