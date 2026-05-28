using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace QuanLySieuThi.Data
{
    public class StaffRepository : IRepository<Nguoi>
    {
        private readonly string filePath = @"DataAccess\DatabaseFile\database_nhanvien.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public List<Nguoi> GetAll()
        {
            List<Nguoi> ds = new List<Nguoi>();
            if (!File.Exists(filePath)) return ds;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json)) ds = JsonSerializer.Deserialize<List<Nguoi>>(json, options);
            }
            catch (Exception ex) { throw new Exception("Lỗi đọc JSON Nhân viên: " + ex.Message); }
            return ds;
        }

        public void Save(List<Nguoi> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex) { throw new Exception("Lỗi lưu JSON Nhân viên: " + ex.Message); }
        }
    }
}