using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class PhieuNhapRepository : ITextSerializable<PhieuNhap>
    {
        private readonly string filePath = "DataAccess/DatabaseFile/database_phieunhap.txt";

        public List<PhieuNhap> GetAll()
        {
            List<PhieuNhap> danhSach = new List<PhieuNhap>();
            if (!File.Exists(filePath)) return danhSach;

            string[] lines = File.ReadAllLines(filePath);
            PhieuNhap currentPN = null;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                string loai = parts[0];

                if (loai == "PN")
                {
                    currentPN = new PhieuNhap();
                    currentPN.MaPN = parts[1];
                    currentPN.NgayNhap = DateTime.Parse(parts[2]);
                    currentPN.MaNCC = parts[3];
                    currentPN.TongTien = double.Parse(parts[4]);

                    // Kiểm tra độ dài mảng để tránh lỗi out of index nếu file cũ thiếu dữ liệu
                    if (parts.Length > 5) currentPN.TrangThai = parts[5];
                    else currentPN.TrangThai = "ChoXacNhan";

                    if (parts.Length > 6) currentPN.SoDienThoai = parts[6];
                    if (parts.Length > 7) currentPN.Email = parts[7];

                    danhSach.Add(currentPN);
                }
                else if (loai == "CTPN" && currentPN != null)
                {
                    ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                    // Lưu ý: Đảm bảo class ChiTietPhieuNhap của bạn có các property tương tự thế này
                    ct.MaPN = parts[1];
                    ct.MaHH = parts[2];
                    ct.SoLuong = int.Parse(parts[3]);
                    ct.DonGia = double.Parse(parts[4]);

                    // Thêm vào danh sách thông qua Getter của DanhSachChiTiet
                    currentPN.DanhSachChiTiet.Add(ct);
                }
            }
            return danhSach;
        }

        public void Save(List<PhieuNhap> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (PhieuNhap pn in danhSach)
            {
                // Format ngày tháng tránh lỗi máy tính khác nhau
                string ngay = pn.NgayNhap.ToString("yyyy-MM-dd");

                // Chuỗi của Phiếu Nhập: PN|MaPN|NgayNhap|MaNCC|TongTien|TrangThai|SDT|Email
                string dongPN = $"PN|{pn.MaPN}|{ngay}|{pn.MaNCC}|{pn.TongTien}|{pn.TrangThai}|{pn.SoDienThoai}|{pn.Email}";
                lines.Add(dongPN);

                foreach (ChiTietPhieuNhap ct in pn.DanhSachChiTiet)
                {
                    // Chuỗi của Chi Tiết: CTPN|MaPN|MaHH|SoLuong|DonGiaNhap
                    string dongCT = $"CTPN|{ct.MaPN}|{ct.MaHH}|{ct.SoLuong}|{ct.DonGia}";
                    lines.Add(dongCT);
                }
            }
            File.WriteAllLines(filePath, lines.ToArray());
        }
    }
    }
