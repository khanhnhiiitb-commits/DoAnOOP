using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class KhuyenMaiRepository : ITextSerializable<ChuongTrinhKhuyenMai>
    {
        private readonly string filePath = Application.StartupPath + @"\DataAccess\DatabaseFile\database_khuyenmai.txt";
        public List<ChuongTrinhKhuyenMai> GetAll()
        {
            List<ChuongTrinhKhuyenMai> danhSach = new List<ChuongTrinhKhuyenMai>();
            if (!File.Exists(filePath)) return danhSach;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                ChuongTrinhKhuyenMai currentKM = null;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');
                    string loaiDong = parts[0];

                    if (loaiDong == "KM")
                    {
                        currentKM = MapLineToKhuyenMai(parts);
                        if (currentKM != null) danhSach.Add(currentKM);
                    }
                    else if (loaiDong == "CTKM" && currentKM != null)
                    {
                        ChiTietChuongTrinhKM chiTiet = MapLineToChiTiet(parts);
                        if (chiTiet != null)
                        {
                            currentKM.ThemChiTiet(chiTiet);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file chương trình khuyến mãi: " + ex.Message);
            }

            return danhSach;
        }

        public void Save(List<ChuongTrinhKhuyenMai> danhSach)
        {
            List<string> lines = new List<string>();
            foreach (ChuongTrinhKhuyenMai km in danhSach)
            {
                lines.Add(MapKhuyenMaiToLine(km));

                foreach (ChiTietChuongTrinhKM ct in km.DanhSachChiTiet)
                {
                    string lineCT = "CTKM|" + ct.MaCTKM + "|" + ct.MaMH + "|" + ct.PhanTramGiam;
                    lines.Add(lineCT);
                }
            }

            try
            {
                File.WriteAllLines(filePath, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file chương trình khuyến mãi: " + ex.Message);
            }
        }

        // --- HELPER METHODS ---

        private ChuongTrinhKhuyenMai MapLineToKhuyenMai(string[] p)
        {
            try
            {
                ChuongTrinhKhuyenMai km = null;
                string loaiKM = p[1];

                // Cần điền đúng tên lớp con của bạn tại đây
                if (loaiKM == "GiamTheoSP")
                {
                    // km = new KhuyenMaiTheoSanPham(); 
                }
                else if (loaiKM == "GiamTongBill")
                {
                    // km = new KhuyenMaiTongBill();
                }

                if (km != null)
                {
                    km.MaCTKM = p[2];
                    km.TenCT = p[3];
                    km.NgayBatDau = DateTime.Parse(p[4]);
                    km.NgayKetThuc = DateTime.Parse(p[5]);
                    km.NoiDung = p[6];
                }

                return km;
            }
            catch
            {
                return null;
            }
        }

        private ChiTietChuongTrinhKM MapLineToChiTiet(string[] p)
        {
            try
            {
                ChiTietChuongTrinhKM ct = new ChiTietChuongTrinhKM();
                ct.MaCTKM = p[1];
                ct.MaMH = p[2];
                ct.PhanTramGiam = double.Parse(p[3]);
                return ct;
            }
            catch
            {
                return null;
            }
        }

        private string MapKhuyenMaiToLine(ChuongTrinhKhuyenMai km)
        {
            string nbd = km.NgayBatDau.ToString("yyyy-MM-dd");
            string nkt = km.NgayKetThuc.ToString("yyyy-MM-dd");

            string loaiKM = "Khac";
            // Cần điền đúng tên lớp con của bạn tại đây
            //if (km is KhuyenMaiTheoSanPham) loaiKM = "GiamTheoSP";
            // else if (km is KhuyenMaiTongBill) loaiKM = "GiamTongBill";
            return "KM|" + loaiKM + "|" + km.MaCTKM + "|" + km.TenCT + "|" + nbd + "|" + nkt + "|" + km.NoiDung;
        }
    }
}

