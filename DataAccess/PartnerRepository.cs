using System;
using System.IO;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Data
{
    public class PartnerRepository : ITextSerializable<NhaCungCap>
    {
        private readonly string filePath = "DataAccess/DatabaseFile/database_partner.txt";
        public List<NhaCungCap> GetAll()
        {
            List<NhaCungCap> danhSach = new List<NhaCungCap>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                NhaCungCap ncc = MapLineToEntity(line);
                if (ncc != null) danhSach.Add(ncc);
            }
            return danhSach;
        }

        public void Save(List<NhaCungCap> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (NhaCungCap ncc in danhSach)
            {
                lines.Add(MapEntityToLine(ncc));
            }
            File.WriteAllLines(filePath, lines);
        }
        
        // --- HELPER METHODS ---
        private NhaCungCap MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');

            // Format: NCC | MaNCC | TenNCC | DiaChi | SDT | Email (Đủ 6 phần tử)
            if (parts.Length < 6) return null;

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

            return null;
        }
        private string MapEntityToLine(NhaCungCap ncc)
        {
            return $"NCC|{ncc.MaNCC}|{ncc.TenNCC}|{ncc.DiaChi}|{ncc.SoDienThoai}|{ncc.Email}";
        }
    }
}