using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongtrinhQuanlybanhangsieuthi.DataAccess
{
    public class KhuyenMaiRepository : ITextSerializable<ChuongTrinhKhuyenMai>
    {
        private readonly string filePath = "DataAccess/DatabaseFile/database_khuyenmai.txt";

        public List<ChuongTrinhKhuyenMai> GetAll()
        {
            List<ChuongTrinhKhuyenMai> danhSach = new List<ChuongTrinhKhuyenMai>();
            if (!File.Exists(filePath)) return danhSach;

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
                    currentKM.DanhSachChiTiet.Add(MapLineToChiTiet(parts));
                }
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
                    lines.Add($"CTKM|{ct.MaCTKM}|{ct.MaMH}|{ct.PhanTramGiam}");
                }
            }
            File.WriteAllLines(filePath, lines.ToArray());
        }

        // --- HELPER METHODS ---

        private ChuongTrinhKhuyenMai MapLineToKhuyenMai(string[] p)
        {
            // p[0]=KM, p[1]=LoaiKM, p[2]=Ma, p[3]=Ten, p[4]=NgayBD, p[5]=NgayKT, p[6]=NoiDung
            ChuongTrinhKhuyenMai km = null;
            string loaiKM = p[1];

            // Dùng tính Đa hình: Khởi tạo lớp con dựa trên dữ liệu file
            // BẠN SỬA LẠI TÊN CLASS CON CHO KHỚP VỚI BÀI CỦA BẠN Ở ĐÂY NHÉ
            if (loaiKM == "GiamTheoSP")
            {
                // km = new KhuyenMaiTheoSanPham(); 
            }
            else if (loaiKM == "GiamTongBill")
            {
                // km = new KhuyenMaiTongBill();
            }

            // Gán các thuộc tính chung của lớp Cha
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

        private ChiTietChuongTrinhKM MapLineToChiTiet(string[] p)
        {
            // p[0]=CTKM, p[1]=MaCTKM, p[2]=MaMH, p[3]=PhanTramGiam
            ChiTietChuongTrinhKM ct = new ChiTietChuongTrinhKM();
            ct.MaCTKM = p[1];
            ct.MaMH = p[2];
            ct.PhanTramGiam = double.Parse(p[3]);
            return ct;
        }

        private string MapKhuyenMaiToLine(ChuongTrinhKhuyenMai km)
        {
            string nbd = km.NgayBatDau.ToString("yyyy-MM-dd");
            string nkt = km.NgayKetThuc.ToString("yyyy-MM-dd");

            // Xác định ngược lại loại KM để ghi ra file
            string loaiKM = "Khac";
            // if (km is KhuyenMaiTheoSanPham) loaiKM = "GiamTheoSP";
            // else if (km is KhuyenMaiTongBill) loaiKM = "GiamTongBill";

            return $"KM|{loaiKM}|{km.MaCTKM}|{km.TenCT}|{nbd}|{nkt}|{km.NoiDung}";
        }
    }
}
