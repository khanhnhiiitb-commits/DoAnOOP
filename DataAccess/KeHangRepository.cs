using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using System.Windows.Forms;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class KeHangRepository : ITextSerializable<KeHang>
    {
        private readonly string filePath =
            Application.StartupPath + @"\DataAccess\DatabaseFile\database_kehang.txt";


        public List<KeHang> GetAll()
        {
            List<KeHang> danhSach =
                new List<KeHang>();

            if (!File.Exists(filePath))
            {
                return danhSach;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    KeHang ke = MapLineToEntity(line);

                    if (ke != null)
                    {
                        danhSach.Add(ke);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file kệ hàng: " + ex.Message);
            }

            return danhSach;
        }

        public void Save
        (
            List<KeHang> danhSach
        )
        {
            List<string> lines =
                new List<string>();

            foreach (KeHang ke in danhSach)
            {
                lines.Add(MapEntityToLine(ke));
            }

            // Khắc phục: Bọc try-catch để bảo vệ luồng ghi file vật lý
            try
            {
                File.WriteAllLines(filePath, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file kệ hàng: " + ex.Message);
            }
        }
        // --- PRIVATE HELPER METHODS (Đảm bảo SRP - Single Responsibility) ---

        private KeHang MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');

            if (parts.Length < 5)
            {
                return null;
            }

            // Khắc phục: Bọc try-catch chặn lỗi Crash nếu file txt bị sửa sai định dạng số
            try
            {
                KeHang ke = new KeHang();
                ke.MaKe = parts[0];
                ke.ViTri = parts[1];
                ke.LoaiHang = parts[2];
                ke.SucChua = int.Parse(parts[3]);
                // parts[4] là TrangThai, thường được tính toán tự động trong Model nên không cần parse lại

                return ke;
            }
            catch
            {
                return null; // Bỏ qua đối tượng lỗi
            }
        }

        private string MapEntityToLine(KeHang ke)
        {
            // Điểm sáng: Tách biệt logic ghép chuỗi, giúp hàm Save() trở nên cực kỳ gọn gàng
            return ke.MaKe + "|" +
                   ke.ViTri + "|" +
                   ke.LoaiHang + "|" +
                   ke.SucChua + "|" +
                   ke.TrangThai;
        }
    }
}