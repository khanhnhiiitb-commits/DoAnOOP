using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class TheThanhVienRepository 
    {
        private readonly string filePath = @"\DataAccess\DatabaseFile\database_thethanhvien.txt";
        public List<TheThanhVien> GetAll()
        {
            List<TheThanhVien> danhSach = new List<TheThanhVien>();
            if (!File.Exists(filePath)) return danhSach;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    TheThanhVien tv = MapLineToEntity(line);
                    if (tv != null) danhSach.Add(tv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file thẻ thành viên: " + ex.Message);
            }
            return danhSach;
        }

        public void Save(List<TheThanhVien> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (TheThanhVien tv in danhSach)
            {
                lines.Add(MapEntityToLine(tv));
            }

            try
            {
                File.WriteAllLines(filePath, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file thẻ thành viên: " + ex.Message);
            }
        }
        // --- HELPER METHODS ---

        private TheThanhVien MapLineToEntity(string line)
        {
            try
            {
                string[] parts = line.Split('|');
                if (parts.Length < 5) return null;

                TheThanhVien tv = new TheThanhVien();
                tv.MaThe = parts[1];
                tv.NgayDangKy = DateTime.Parse(parts[2]);
                tv.NapDiemTuFile(int.Parse(parts[3]));

                bool trangThaiTuFile = bool.Parse(parts[4]);
                if (trangThaiTuFile)
                {
                    tv.KichHoatThe();
                }
                else
                {
                    tv.KhoaThe();
                }
                return tv;
            }
            catch
            {
                return null;
            }
        }

        private string MapEntityToLine(TheThanhVien tv)
        {
            string ngay = tv.NgayDangKy.ToString("yyyy-MM-dd");
            return "TV|" + tv.MaThe + "|" + ngay + "|" + tv.DiemTichLuy + "|" + tv.TrangThai;
        }
    }
}