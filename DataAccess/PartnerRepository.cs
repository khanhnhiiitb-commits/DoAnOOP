using System;
using System.IO;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Data
{
    public class PartnerRepository
    {
        private readonly string filePath = "Data/database_partner.txt";

        public List<object> GetAll()
        {
            List<object> danhSach = new List<object>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                object doiTac = MapLineToEntity(line);
                if (doiTac != null) danhSach.Add(doiTac);
            }
            return danhSach;
        }

        public void Save(List<object> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (object obj in danhSach)
            {
                lines.Add(MapEntityToLine(obj));
            }
            File.WriteAllLines(filePath, lines);
        }

        private object MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 2) return null;

            string loaiDoiTac = parts[0];

            if (loaiDoiTac == "NCC")
            {
                return new NhaCungCap
                {
                    MaNCC = parts[1],
                    TenNCC = parts[2],
                    DiaChi = parts[3],
                    SoDienThoai = parts[4],
                    Email = parts[5]
                };
            }

            if (loaiDoiTac == "KH")
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = parts[1];
                kh.DiemTichLuy = int.Parse(parts[2]);
                
                // KIỂM TRA THẺ THÀNH VIÊN
                // Nếu dữ liệu file có mã thẻ (không phải "None"), ta khởi tạo đối tượng thẻ
                if (parts.Length > 3 && parts[3] != "None" && !string.IsNullOrEmpty(parts[3]))
                {
                    kh.TheTV = new TheThanhVien(parts[3]);
                }
                
                
                kh.HoTen = parts[4];  
                kh.DiaChi = parts[6];
                kh.SoDienThoai = parts[7];  
                
                return kh;
            }

            return null;
        }

        private string MapEntityToLine(object obj)
        {
            if (obj is NhaCungCap ncc)
            {
                return $"NCC|{ncc.MaNCC}|{ncc.TenNCC}|{ncc.DiaChi}|{ncc.SoDienThoai}|{ncc.Email}";
            }

            if (obj is KhachHang kh)
            {
                // Lấy mã thẻ: Nếu có thẻ thì lấy MaThe, không thì ghi "None"
                string maThe = kh.TheTV != null ? kh.TheTV.MaThe : "None";
                return $"KH|{kh.MaKH}|{kh.DiemTichLuy}|{maThe}";
            }

            return "";
        }
    }
}