using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class KhuyenMaiRepository : IRepository<ChuongTrinhKhuyenMai>
    {
        private readonly string filePath = @"DataAccess\DatabaseFile\database_khuyenmai.json";

        public List<ChuongTrinhKhuyenMai> GetAll()
        {
            List<ChuongTrinhKhuyenMai> danhSach = new List<ChuongTrinhKhuyenMai>();
            if (!File.Exists(filePath)) return danhSach;

            try
            {
                // 1. Đọc toàn bộ nội dung file json
                string jsonString = File.ReadAllText(filePath);

                // 2. Cài đặt tùy chọn phân tích JSON
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.PropertyNameCaseInsensitive = true;

                // 3. Ép kiểu tự động từ chuỗi JSON ra List object (Thay thế hoàn toàn maptoline)
                List<ChuongTrinhKhuyenMai> ketQua = JsonSerializer.Deserialize<List<ChuongTrinhKhuyenMai>>(jsonString, options);

                if (ketQua != null)
                {
                    danhSach = ketQua;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file JSON chương trình khuyến mãi: " + ex.Message, "Lỗi");
            }

            return danhSach;
        }

        public void Save(List<ChuongTrinhKhuyenMai> danhSach)
        {
            try
            {
                // 1. Cài đặt tùy chọn để file JSON in ra có thụt lề cho đẹp, dễ đọc
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                // 2. Tự động mã hóa List object thành chuỗi JSON
                string jsonString = JsonSerializer.Serialize<List<ChuongTrinhKhuyenMai>>(danhSach, options);

                // 3. Ghi đè vào file
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file JSON chương trình khuyến mãi: " + ex.Message, "Lỗi");
            }
        }
    }
}

