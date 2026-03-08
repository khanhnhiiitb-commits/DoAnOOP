using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Models.Products;

namespace QuanLySieuThi.Data
{
    public class InventoryRepository
    {
        private readonly string filePath = "Data/database_hanghoa.txt";

        // Lấy danh sách hàng hóa từ file
        public List<HangHoa> GetAll()
        {
            List<HangHoa> danhSach = new List<HangHoa>();

            if (!File.Exists(filePath))
            {
                return danhSach;
            }

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

            return danhSach;
        }

        // Lưu danh sách hàng hóa vào file
        public void Save(List<HangHoa> danhSach)
        {
            string[] lines = new string[danhSach.Count];
            int index = 0;

            foreach (HangHoa hh in danhSach)
            {
                lines[index] = MapEntityToLine(hh);
                index = index + 1;
            }

            File.WriteAllLines(filePath, lines);
        }

        //  PRIVATE HELPER METHODS 

        // Chuyển dòng text thành đối tượng dựa trên Constructor 8 tham số
        private HangHoa MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');

            // Cấu trúc: Loại + 8 tham số = 9 phần tử
            if (parts.Length < 9)
            {
                return null;
            }

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

                // Gọi đúng Constructor 8 tham số của HangDienTu
                return new HangDienTu(ma, ten, gia, ton, make, donvi, baoHanh, hang);
            }

            if (loai == "THUCPHAM")
            {
                DateTime nsx = DateTime.Parse(parts[7]);
                DateTime hsd = DateTime.Parse(parts[8]);

                // Gọi đúng Constructor 8 tham số của HangThucPham
                return new HangThucPham(ma, ten, gia, ton, make, donvi, nsx, hsd);
            }

            return null;
        }

        // Chuyển đối tượng thành dòng text (Data Mapping)
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

                // Định dạng ngày tháng thủ công (yyyy-MM-dd)
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