using QuanLySieuThi.Models.Products;
using System;
using System.Collections.Generic;
using System.IO;

namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class KeHangRepository
    {
        private readonly string filePath = "DataAccess/DatabaseFile/database_kehang.txt";
        

        public List<KeHang> GetAll()
        {
            List<KeHang> danhSach =
                new List<KeHang>();

            if (!File.Exists(filePath))
            {
                return danhSach;
            }

            string[] lines =
                File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts =
                    line.Split('|');

                if (parts.Length < 5)
                {
                    continue;
                }

                KeHang ke =
                    new KeHang();

                ke.MaKe = parts[0];

                ke.ViTri = parts[1];

                ke.LoaiHang = parts[2];

                ke.SucChua =
                    int.Parse(parts[3]);

                danhSach.Add(ke);
            }

            return danhSach;
        }

        public void Save
        (
            List<KeHang> danhSach
        )
        {
            List<string> lines =
                new List<string>();

            foreach (KeHang ke in danhSach)
            {
                string line =
                    ke.MaKe + "|" +
                    ke.ViTri + "|" +
                    ke.LoaiHang + "|" +
                    ke.SucChua + "|" +
                    ke.TrangThai;

                lines.Add(line);
            }

            File.WriteAllLines(
                filePath,
                lines.ToArray()
            );
        }
    }
}