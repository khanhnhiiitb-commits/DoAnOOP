using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using System.Windows.Forms;
namespace QuanLySieuThi.Data
{
    public class StaffRepository : ITextSerializable<Nguoi>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_nhanvien.txt";
        public List<Nguoi> GetAll()
        {
            List<Nguoi> danhSach = new List<Nguoi>();
            if (!File.Exists(filePath)) return danhSach;
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    Nguoi p = MapLineToEntity(line);
                    if (p != null) danhSach.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file nhân viên/khách hàng: " + ex.Message);
            }
            return danhSach;
        }

        public void Save(List<Nguoi> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (Nguoi p in danhSach)
            {
                lines.Add(MapEntityToLine(p));
            }

            try
            {
                File.WriteAllLines(filePath, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file nhân viên/khách hàng: " + ex.Message);
            }
        }

        private Nguoi MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');

            // Chỉ check an toàn tối thiểu (Loại + 6 thông tin cơ bản)
            if (parts.Length < 8) return null;

            string loai = parts[0];

            if (loai == "NV")
            {
                // NV cần ít nhất 12 phần tử thì mới check ở đây
                if (parts.Length < 12) return null;

                NhanVien nv = new NhanVien();
                // Gán thông tin lớp cha (Nguoi)
                nv.Ma = parts[1];
                nv.HoTen = parts[2];
                nv.NgaySinh = DateTime.Parse(parts[3]);
                nv.GioiTinh = bool.Parse(parts[4]);
                nv.SoDienThoai = parts[5];
                nv.DiaChi = parts[6];

                // Gán thông tin lớp con (NhanVien)
                nv.Ma = parts[7];
                nv.ChucVu = parts[8];
                nv.LuongCB = double.Parse(parts[9]);
                nv.NgayVaoLam = DateTime.Parse(parts[10]);
                nv.MaCa = parts[11];

                if (parts.Length > 12 && !string.IsNullOrEmpty(parts[12]) && parts[12] != "None")
                {
                    string[] accParts = parts[12].Split('-');
                    if (accParts.Length >= 3)
                    {
                        nv.Taikhoan = new TaiKhoan
                        {
                            TenDangNhap = accParts[0],
                            MatKhau = accParts[1],
                            UserRole = new Role { MaRole = accParts[2] }
                        };
                    }
                }
                return nv;
            }

            if (loai == "KH")
            {
                // KH cần ít nhất 9 phần tử
                if (parts.Length < 9) return null;

                KhachHang kh = new KhachHang();
                kh.Ma = parts[1];
                kh.HoTen = parts[2];
                kh.NgaySinh = DateTime.Parse(parts[3]);
                kh.GioiTinh = bool.Parse(parts[4]);
                kh.SoDienThoai = parts[5];
                kh.DiaChi = parts[6];

                kh.Ma = parts[7];
                kh.DiemTichLuy = int.Parse(parts[8]);

                // Khởi tạo đối tượng thẻ thành viên nếu có mã
                if (parts.Length > 9 && parts[9] != "None" && !string.IsNullOrEmpty(parts[9]))
                {
                    kh.TheTV = new TheThanhVien(parts[9]);
                }
                return kh;
            }

            return null;
        }

        private string MapEntityToLine(Nguoi p)
        {
            string sSinh = p.NgaySinh.ToString("yyyy-MM-dd");
            string baseInfo = $"{p.Ma}|{p.HoTen}|{sSinh}|{p.GioiTinh}|{p.SoDienThoai}|{p.DiaChi}";
            if (p is NhanVien nv)
            {
                string sVao = nv.NgayVaoLam.ToString("yyyy-MM-dd");

                // Xử lý chuỗi Tài khoản (nếu không có thì ghi là "None")
                string sTaiKhoan = "None";
                if (nv.Taikhoan != null && nv.Taikhoan.UserRole != null)
                {
                    // Định dạng: Username-Password-RoleID
                    sTaiKhoan = $"{nv.Taikhoan.TenDangNhap}-{nv.Taikhoan.MatKhau}-{nv.Taikhoan.UserRole.MaRole}";
                }
                return $"NV|{baseInfo}|{nv.Ma}|{nv.ChucVu}|{nv.LuongCB}|{sVao}|{nv.MaCa}|{sTaiKhoan}";
            }
            if (p is KhachHang kh)
            {
                string maThe = kh.TheTV != null ? kh.TheTV.MaThe : "None";
                return $"KH|{baseInfo}|{kh.Ma}|{kh.DiemTichLuy}|{maThe}";
            }

            return "";
        }
    }
}