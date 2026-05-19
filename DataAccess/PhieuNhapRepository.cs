using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class PhieuNhapRepository : ITextSerializable<PhieuNhap>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_phieunhap.txt";
        public List<PhieuNhap> GetAll()
        {
            List<PhieuNhap> danhSach = new List<PhieuNhap>();
            if (!File.Exists(filePath)) return danhSach;

            try
            {
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

                        if (parts.Length > 5) currentPN.TrangThai = parts[5];
                        else currentPN.TrangThai = "ChoXacNhan";

                        if (parts.Length > 6) currentPN.SoDienThoai = parts[6];
                        if (parts.Length > 7) currentPN.Email = parts[7];

                        danhSach.Add(currentPN);
                    }
                    else if (loai == "CTPN" && currentPN != null)
                    {
                        ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
                        ct.MaPN = parts[1];
                        ct.MaHH = parts[2];
                        ct.SoLuong = int.Parse(parts[3]);
                        ct.DonGia = double.Parse(parts[4]);
                        currentPN.ThemChiTiet(ct);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file phiếu nhập: " + ex.Message);
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
            try
            {
                File.WriteAllLines(filePath, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file phiếu nhập: " + ex.Message);
            }
        }
    }
    }
