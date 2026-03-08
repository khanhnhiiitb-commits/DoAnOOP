using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLySieuThi.Data
{
    public class StaffRepository
    {
        private readonly string filePath = "Data/database_nhanvien.txt";

        // Lấy toàn bộ danh sách (bao gồm cả Nhân viên và Khách hàng)
        public List<Nguoi> GetAll()
        {
            List<Nguoi> danhSach = new List<Nguoi>();

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

                Nguoi p = MapLineToEntity(line);
                if (p != null)
                {
                    danhSach.Add(p);
                }
            }

            return danhSach;
        }

        // Lưu danh sách xuống file
        public void Save(List<Nguoi> danhSach)
        {
            string[] lines = new string[danhSach.Count];
            int index = 0;

            foreach (Nguoi p in danhSach)
            {
                lines[index] = MapEntityToLine(p);
                index = index + 1;
            }

            File.WriteAllLines(filePath, lines);
        }

        // ---------------- PRIVATE HELPER METHODS ----------------

        private Nguoi MapLineToEntity(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length < 7) return null;

            string loai = parts[0];

            // Thông tin chung của lớp Nguoi
            string maChung = parts[1];
            string hoTen = parts[2];
            DateTime ngaySinh = DateTime.Parse(parts[3]);
            bool gioiTinh = bool.Parse(parts[4]);
            string sdt = parts[5];
            string diaChi = parts[6];

            if (loai == "NV")
            {
                NhanVien nv = new NhanVien();
                // Gan thong tin lop cha
                nv.SetMa(maChung);
                nv.SetHoTen(hoTen);
                nv.SetNgaySinh(ngaySinh);
                nv.SetGioiTinh(gioiTinh);
                nv.SetSoDienThoai(sdt);
                nv.SetDiaChi(diaChi);
                // Gan thong tin lop con NhanVien
                nv.SetMaNV(parts[7]);
                nv.SetChucVu(parts[8]);
                nv.SetLuongCB(double.Parse(parts[9]));
                nv.SetNgayVaoLam(DateTime.Parse(parts[10]));
                nv.SetMaCaLV(parts[11]);
                return nv;
            }

            if (loai == "KH")
            {
                KhachHang kh = new KhachHang();
                // Gan thong tin lop cha
                kh.SetMa(maChung);
                kh.SetHoTen(hoTen);
                kh.SetNgaySinh(ngaySinh);
                kh.SetGioiTinh(gioiTinh);
                kh.SetSoDienThoai(sdt);
                kh.SetDiaChi(diaChi);
                // Gan thong tin lop con KhachHang
                kh.SetMaKH(parts[7]);
                kh.SetDiemTichLuy(int.Parse(parts[8]));
                kh.SetMaTheTV(parts[9]);
                return kh;
            }

            return null;
        }

        private string MapEntityToLine(Nguoi p)
        {
            // Format ngay thang thu cong
            DateTime dSinh = p.GetNgaySinh();
            string sSinh = dSinh.Year + "-" + dSinh.Month + "-" + dSinh.Day;

            string baseInfo = p.GetMa() + "|" + p.GetHoTen() + "|" + sSinh + "|" +
                              p.GetGioiTinh() + "|" + p.GetSoDienThoai() + "|" + p.GetDiaChi();

            if (p is NhanVien)
            {
                NhanVien nv = (NhanVien)p;
                DateTime dVao = nv.GetNgayVaoLam();
                string sVao = dVao.Year + "-" + dVao.Month + "-" + dVao.Day;

                return "NV|" + baseInfo + "|" + nv.GetMaNV() + "|" + nv.GetChucVu() + "|" +
                       nv.GetLuongCB() + "|" + sVao + "|" + nv.GetMaCaLV();
            }

            if (p is KhachHang)
            {
                KhachHang kh = (KhachHang)p;
                return "KH|" + baseInfo + "|" + kh.GetMaKH() + "|" + kh.GetDiemTichLuy() + "|" + kh.GetMaTheTV();
            }

            return "";
        }
    }
}