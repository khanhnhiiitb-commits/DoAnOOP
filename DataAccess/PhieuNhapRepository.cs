using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class PhieuNhapRepository : IRepository<PhieuNhap>
    {
        private readonly string filePath = @"DataAccess\DatabaseFile\database_phieunhap.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public List<PhieuNhap> GetAll()
        {
            List<PhieuNhap> ds = new List<PhieuNhap>();
            if (!File.Exists(filePath)) return ds;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json)) ds = JsonSerializer.Deserialize<List<PhieuNhap>>(json, options);
            }
            catch (Exception ex) { throw new Exception("Lỗi đọc JSON Phiếu nhập: " + ex.Message); }
            return ds;
        }

        public void Save(List<PhieuNhap> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex) { throw new Exception("Lỗi lưu JSON Phiếu nhập: " + ex.Message); }
        }
    }
}
