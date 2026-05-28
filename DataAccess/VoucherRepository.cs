using QuanLySieuThi.Data; 
using QuanLySieuThi.Models.Sales;  
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace QuanLySieuThi.Data
{
    // Kế thừa Interface và truyền cụ thể kiểu dữ liệu là Voucher
    public class VoucherRepository : IRepository<Voucher>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_voucher.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public List<Voucher> GetAll()
        {
            List<Voucher> ds = new List<Voucher>();
            if (!File.Exists(filePath)) return ds;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    ds = JsonSerializer.Deserialize<List<Voucher>>(json, options);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc JSON Voucher: " + ex.Message);
            }
            return ds;
        }

        public void Save(List<Voucher> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu JSON Voucher: " + ex.Message);
            }
        }
    }
}