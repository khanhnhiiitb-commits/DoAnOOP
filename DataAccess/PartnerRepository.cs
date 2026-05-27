using QuanLySieuThi.Models;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace QuanLySieuThi.Data
{
    public class PartnerRepository 
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_partner.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        // 1. Hàm nạp TẤT CẢ (Dành cho DataStorage gọi - Fix lỗi CS1061)
        public PartnerData GetAllData()
        {
            PartnerData data = new PartnerData();
            if (!File.Exists(filePath)) return data;
            try
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(json))
                    data = JsonSerializer.Deserialize<PartnerData>(json, options);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi đọc JSON Partner: " + ex.Message); }
            return data;
        }

        // 2. Hàm chỉ lấy Nhà Cung Cấp (Dành cho Giao diện ucNhaCungCap gọi - Fix lỗi CS0029)
        public List<NhaCungCap> GetAll()
        {
            PartnerData data = GetAllData();
            if (data != null && data.NhaCungCaps != null)
            {
                return data.NhaCungCaps;
            }
            return new List<NhaCungCap>();
        }

        // 3. Hàm chỉ Lưu Nhà Cung Cấp (Dành cho Giao diện ucNhaCungCap gọi - Fix lỗi CS7036)
        // Lưu ý: Phải đọc Khách hàng cũ lên để ghép vào, tránh làm mất dữ liệu Khách hàng
        public void Save(List<NhaCungCap> nccList)
        {
            try
            {
                // Bước A: Lấy lại danh sách Khách Hàng đang có trong file
                PartnerData dataCu = GetAllData();
                List<KhachHang> khList = new List<KhachHang>();

                if (dataCu != null && dataCu.KhachHangs != null)
                {
                    khList = dataCu.KhachHangs;
                }

                // Bước B: Ghép Nhà Cung Cấp mới từ Giao diện với Khách Hàng cũ
                PartnerData dataMoi = new PartnerData();
                dataMoi.NhaCungCaps = nccList;
                dataMoi.KhachHangs = khList;

                // Bước C: Lưu xuống file JSON
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, JsonSerializer.Serialize(dataMoi, options));
            }
            catch (Exception ex) { MessageBox.Show("Lỗi lưu JSON Partner: " + ex.Message); }
        }
    }
}