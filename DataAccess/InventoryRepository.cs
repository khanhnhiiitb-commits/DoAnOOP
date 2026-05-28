using QuanLySieuThi.Models.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace QuanLySieuThi.Data
{
    public class InventoryRepository : IRepository<HangHoa>
    {
        private readonly string filePath =  @"DataAccess\DatabaseFile\database_hanghoa.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public List<HangHoa> GetAll()
        {
            List<HangHoa> ds = new List<HangHoa>();
            if (!File.Exists(filePath)) return ds;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json)) ds = JsonSerializer.Deserialize<List<HangHoa>>(json, options);
            }
            catch (Exception ex) 
            {
                throw new Exception("Lỗi đọc JSON Hàng hóa: " + ex.Message);
            }
            return ds;
        }

        public void Save(List<HangHoa> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex) 
            {
                throw new Exception("Lỗi lưu JSON Hàng hóa: " + ex.Message);
            }
        }
    }
}