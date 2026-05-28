using QuanLySieuThi.Models;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace QuanLySieuThi.Data
{
    public class SystemRepository
    {
        private readonly string filePath =   @"DataAccess\DatabaseFile\database_system.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        private SystemData GetAllData()
        {
            SystemData data = new SystemData();
            if (!File.Exists(filePath)) return data;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json))
                    data = JsonSerializer.Deserialize<SystemData>(json, options);
            }
            catch (Exception ex) { throw new Exception("Lỗi đọc file JSON System: " + ex.Message); }
            return data;
        }

        public List<TaiKhoan> GetAllTaiKhoan()
        {
            SystemData data = GetAllData();
            if (data != null && data.TaiKhoans != null) return data.TaiKhoans;
            return new List<TaiKhoan>();
        }

        public List<CaLamViec> GetAllCaLamViec()
        {
            SystemData data = GetAllData();
            if (data != null && data.CaLamViecs != null) return data.CaLamViecs;
            return new List<CaLamViec>();
        }

        public void SaveSystemData(List<TaiKhoan> tkList, List<CaLamViec> caList, List<ChuongTrinhKhuyenMai> kmList)
        {
            try
            {
                SystemData data = new SystemData();
                data.TaiKhoans = tkList;
                data.CaLamViecs = caList;
                data.KhuyenMais = kmList;

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(data, options));
            }
            catch (Exception ex) { throw new Exception("Lỗi lưu file JSON System: " + ex.Message); }
        }
    }
}