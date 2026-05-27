using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class PhieuNhapRepository : ITextSerializable<PhieuNhap>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_phieunhap.json";
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
            catch (Exception ex) { MessageBox.Show("Lỗi đọc JSON Phiếu nhập: " + ex.Message); }
            return ds;
        }

        public void Save(List<PhieuNhap> ds)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(ds, options));
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu JSON Phiếu nhập: " + ex.Message); }
        }
    }
}
