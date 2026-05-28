using QuanLySieuThi.Models;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace QuanLySieuThi.Data
{
    public class SalesRepository 
    {
        private readonly string filePath = @"DataAccess\DatabaseFile\database_sales.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        private SalesData GetAllData()
        {
            SalesData data = new SalesData();
            if (!File.Exists(filePath)) return data;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json))
                    data = JsonSerializer.Deserialize<SalesData>(json, options);
            }
            catch (Exception ex) { throw new Exception("Lỗi đọc file JSON Sales: " + ex.Message); }
            return data;
        }

        public List<HoaDon> GetHoaDons()
        {
            SalesData data = GetAllData();
            if (data != null && data.HoaDons != null) return data.HoaDons;
            return new List<HoaDon>();
        }

        public List<Voucher> GetVouchers()
        {
            SalesData data = GetAllData();
            if (data != null && data.Vouchers != null) return data.Vouchers;
            return new List<Voucher>();
        }

        public void SaveAll(List<HoaDon> hdList, List<Voucher> vcList)
        {
            try
            {
                SalesData data = new SalesData();
                data.HoaDons = hdList;
                data.Vouchers = vcList;

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(data, options));
            }
            catch (Exception ex) { throw new Exception("Lỗi lưu file JSON Sales: " + ex.Message); }
        }
    }
}
    
