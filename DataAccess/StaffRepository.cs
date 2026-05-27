using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace QuanLySieuThi.Data
{
    public class StaffRepository : ITextSerializable<Nguoi>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_nhanvien.json";
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
            catch (Exception ex) { MessageBox.Show("Lỗi đọc JSON Nhân viên: " + ex.Message); }
            return ds;
        }

        public void Save(List<Nguoi> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu JSON Nhân viên: " + ex.Message); }
        }
    }
}