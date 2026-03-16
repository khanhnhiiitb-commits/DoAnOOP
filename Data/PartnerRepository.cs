using System.IO;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Data
{
    public class PartnerRepository
    {
        private readonly string filePath = "Data/database_partner.txt";

        // Lấy danh sách đối tác (bao gồm NCC và Khách hàng)
        public List<object> GetAll()
        {
            List<object> danhSach = new List<object>();

            if (!File.Exists(filePath))
            {
                return danhSach;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                object doiTac = MapLineToEntity(line);
                if (doiTac != null)
                {
                    danhSach.Add(doiTac);
                }
            }

            return danhSach;
        }

        // Lưu danh sách đối tác xuống file
        public void Save(List<object> danhSach)
        {
            string[] lines = new string[danhSach.Count];
            int index = 0;

            foreach (object obj in danhSach)
            {
                lines[index] = MapEntityToLine(obj);
                index = index + 1;
            }

            File.WriteAllLines(filePath, lines);
        }

        // ---------------- PRIVATE HELPER METHODS ----------------

        private object MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 2) return null;

            string loaiDoiTac = parts[0];

            if (loaiDoiTac == "NCC")
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = parts[1];
                ncc.TenNCC = parts[2];
                ncc.DiaChi = parts[3];
                ncc.SoDienThoai = parts[4];
                ncc.Email = parts[5];
                return ncc;
            }

            if (loaiDoiTac == "KH")
            {
                KhachHang kh = new KhachHang();
                // Sử dụng các phương thức Set thủ công của lớp KhachHang
                kh.MaKH(parts[1]);
                kh.DiemTichLuy(int.Parse(parts[2]));
                kh.MaTheTV(parts[3]);
                // Lưu ý: Các thuộc tính từ lớp Nguoi (như HoTen) nếu có 
                // bạn có thể bổ sung thêm việc Set tại đây.
                return kh;
            }

            return null;
        }

        private string MapEntityToLine(object obj)
        {
            if (obj is NhaCungCap)
            {
                NhaCungCap ncc = (NhaCungCap)obj;
                return "NCC|" + ncc.MaNCC + "|" + ncc.TenNCC + "|" + ncc.DiaChi + "|" + ncc.SoDienThoai + "|" + ncc.Email;
            }

            if (obj is KhachHang)
            {
                KhachHang kh = (KhachHang)obj;
                // Sử dụng các phương thức Get thủ công của lớp KhachHang
                return "KH|" + kh.MaKH() + "|" + kh.DiemTichLuy() + "|" + kh.MaTheTV();
            }

            return "";
        }
    }
}