using System;
using System.IO;
using System.Collections.Generic;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using System.Windows.Forms;
namespace QuanLySieuThi.Data
{
    public class PartnerRepository : ITextSerializable<NhaCungCap>
    {
        private readonly string filePath = @"\DataAccess\DatabaseFile\database_partner.txt";
        public List<NhaCungCap> GetAll()
        {
            List<NhaCungCap> danhSach = new List<NhaCungCap>();
            if (!File.Exists(filePath)) return danhSach;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    NhaCungCap ncc = MapLineToEntity(line);
                    if (ncc != null) danhSach.Add(ncc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file đối tác: " + ex.Message);
            }
            return danhSach;
        }

        public void Save(List<NhaCungCap> danhSach)
        {
            List<string> lines = new List<string>();
            try
            {
                File.WriteAllLines(filePath, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file đối tác: " + ex.Message);
            }
        }
        
        // --- HELPER METHODS ---
        private NhaCungCap MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');

            // Format: NCC | MaNCC | TenNCC | DiaChi | SDT | Email (Đủ 6 phần tử)
            if (parts.Length < 6) return null;

            try
            {
                string loaiDoiTac = parts[0];
                if (loaiDoiTac == "NCC")
                {
                    return new NhaCungCap
                    {
                        MaNCC = parts[1],
                        TenNCC = parts[2],
                        DiaChi = parts[3],
                        SoDienThoai = parts[4],
                        Email = parts[5]
                    };
                }
            }
            catch
            {
                return null;
            }

            return null;
        }
        private string MapEntityToLine(NhaCungCap ncc)
        {
            return "NCC|" + ncc.MaNCC + "|" + ncc.TenNCC + "|" + ncc.DiaChi + "|" + ncc.SoDienThoai + "|" + ncc.Email;
        }
    }
}