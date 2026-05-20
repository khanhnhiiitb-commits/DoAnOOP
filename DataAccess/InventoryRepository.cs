using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Models.Products;
using System.Windows.Forms;

namespace QuanLySieuThi.Data
{
    public class InventoryRepository : ITextSerializable<HangHoa>
    {
        private readonly string filePath = Application.StartupPath +@"\DataAccess\DatabaseFile\database_hanghoa.txt";
        public List<HangHoa> GetAll()
        {
            List<HangHoa> danhSach = new List<HangHoa>();
            if (!File.Exists(filePath))
            {
                return danhSach;
            }
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    HangHoa hh = MapLineToEntity(line);

                    if (hh != null)
                    {
                        danhSach.Add(hh);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file hàng hóa: " + ex.Message);
            }

            return danhSach;
        }
        public void Save(List<HangHoa> danhSach)
        {
            string[] lines = new string[danhSach.Count];
            int index = 0;

            foreach (HangHoa hh in danhSach)
            {
                lines[index] = MapEntityToLine(hh);
                index = index + 1;
            }
            try
            {
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file hàng hóa: " + ex.Message);
            }
        }

        //  PRIVATE HELPER METHODS 

        // Chuyển dòng text thành đối tượng dựa trên Constructor 8 tham số
        private HangHoa MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 9)
            {
                return null;
            }
            try
            {
                string loai = parts[0];
                string ma = parts[1];
                string ten = parts[2];
                double gia = double.Parse(parts[3]);
                int ton = int.Parse(parts[4]);
                string make = parts[5];
                string donvi = parts[6];
                if (loai == "DIENTU")
                {
                    int baoHanh = int.Parse(parts[7]);
                    string hang = parts[8];
                    return new HangDienTu(ma, ten, gia, ton, make, donvi, baoHanh, hang);
                }
                if (loai == "THUCPHAM")
                {
                    DateTime nsx = DateTime.Parse(parts[7]);
                    DateTime hsd = DateTime.Parse(parts[8]);
                    return new HangThucPham(ma, ten, gia, ton, make, donvi, nsx, hsd);
                }
            }
            catch
            { return null;}
            return null;
        }
        private string MapEntityToLine(HangHoa hh)
        {
            if (hh is HangDienTu)
            {
                HangDienTu dt = (HangDienTu)hh;
                return "DIENTU|" + dt.MaHH + "|" + dt.TenHang + "|" + dt.DonGia + "|" +
                       dt.SoLuongTon + "|" + dt.MaKeHang + "|" + dt.DonViTinh + "|" +
                       dt.ThoiGianBH + "|" + dt.HangSX;
            }

            if (hh is HangThucPham)
            {
                HangThucPham tp = (HangThucPham)hh;
                string sNSX = tp.NgaySX.Year + "-" + tp.NgaySX.Month + "-" + tp.NgaySX.Day;
                string sHSD = tp.HSD.Year + "-" + tp.HSD.Month + "-" + tp.HSD.Day;

                return "THUCPHAM|" + tp.MaHH + "|" + tp.TenHang + "|" + tp.DonGia + "|" +
                       tp.SoLuongTon + "|" + tp.MaKeHang + "|" + tp.DonViTinh + "|" +
                       sNSX + "|" + sHSD;
            }
            return "";
        }
    }
}