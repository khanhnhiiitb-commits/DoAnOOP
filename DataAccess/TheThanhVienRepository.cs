using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class TheThanhVienRepository : IRepository<TheThanhVien>
    {
        private readonly string filePath = @"DataAccess\DatabaseFile\database_thethanhvien.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public List<TheThanhVien> GetAll()
        {
            List<TheThanhVien> ds = new List<TheThanhVien>();
            if (!File.Exists(filePath)) return ds;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    ds = JsonSerializer.Deserialize<List<TheThanhVien>>(json, options);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đọc JSON Thẻ Thành Viên: " + ex.Message);
            }
            return ds;
        }

        public void Save(List<TheThanhVien> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lưu JSON Thẻ Thành Viên: " + ex.Message);
            }
        }
    }
}