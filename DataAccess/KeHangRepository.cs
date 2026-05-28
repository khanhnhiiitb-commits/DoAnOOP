using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class KeHangRepository : IRepository<KeHang>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_kehang.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public List<KeHang> GetAll()
        {
            List<KeHang> ds = new List<KeHang>();
            if (!File.Exists(filePath)) return ds;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    ds = JsonSerializer.Deserialize<List<KeHang>>(json, options);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc JSON Kệ Hàng: " + ex.Message);
            }
            return ds;
        }

        public void Save(List<KeHang> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu JSON Kệ Hàng: " + ex.Message);
            }
        }
    }
}