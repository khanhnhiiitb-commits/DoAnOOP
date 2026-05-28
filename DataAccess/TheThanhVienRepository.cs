using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class TheThanhVienRepository 
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_thethanhvien.json";
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
                MessageBox.Show("Lỗi đọc JSON Thẻ Thành Viên: " + ex.Message);
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
                MessageBox.Show("Lỗi lưu JSON Thẻ Thành Viên: " + ex.Message);
            }
        }
    }
}