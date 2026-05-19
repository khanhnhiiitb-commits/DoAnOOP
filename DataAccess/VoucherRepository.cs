using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Models.Sales; // Nơi chứa các class Voucher
using QuanLySieuThi.Data;         // Nơi chứa Interface ITextSerializable<T>

namespace QuanLySieuThi.Data
{
    // Kế thừa Interface và truyền cụ thể kiểu dữ liệu là Voucher
    public class VoucherRepository : ITextSerializable<Voucher>
    {
        // Đường dẫn file (Nhi tự điều chỉnh lại cho giống các file Repo khác nhé)
        private string filePath = @"DataAccess\DatabaseFile\database_voucher.txt";

        // ======================================================
        // 1. THỰC THI INTERFACE: HÀM GHI FILE (Save)
        // ======================================================
        public void Save(List<Voucher> danhSach)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Voucher v in danhSach)
                {
                    string thongTinChung = $"{v.MaVoucher}|{v.TenVoucher}|{v.NgayBatDau:yyyy/MM/dd}|{v.NgayKetThuc:yyyy/MM/dd}|{v.TrangThai}";

                    if (v is VoucherTienMat tm)
                    {
                        sw.WriteLine($"TM|{thongTinChung}|{tm.SoTienGiamCoDinh}");
                    }
                    else if (v is VoucherPhanTram pt)
                    {
                        sw.WriteLine($"PT|{thongTinChung}|{pt.PhanTramGiam}|{pt.GiamToiDa}");
                    }
                }
            }
        }

        // ======================================================
        // 2. THỰC THI INTERFACE: HÀM ĐỌC FILE (GetAll)
        // ======================================================
        public List<Voucher> GetAll()
        {
            List<Voucher> ds = new List<Voucher>();

            if (!File.Exists(filePath)) return ds;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length < 7) continue;

                    string coLoai = parts[0];
                    string ma = parts[1];
                    string ten = parts[2];
                    DateTime bd = DateTime.Parse(parts[3]);
                    DateTime kt = DateTime.Parse(parts[4]);
                    bool trangThai = bool.Parse(parts[5]);

                    if (coLoai == "TM")
                    {
                        VoucherTienMat vTm = new VoucherTienMat();
                        vTm.MaVoucher = ma;
                        vTm.TenVoucher = ten;
                        vTm.NgayBatDau = bd;
                        vTm.NgayKetThuc = kt;
                        vTm.TrangThai = trangThai;
                        vTm.SoTienGiamCoDinh = double.Parse(parts[6]);

                        ds.Add(vTm);
                    }
                    else if (coLoai == "PT")
                    {
                        VoucherPhanTram vPt = new VoucherPhanTram();
                        vPt.MaVoucher = ma;
                        vPt.TenVoucher = ten;
                        vPt.NgayBatDau = bd;
                        vPt.NgayKetThuc = kt;
                        vPt.TrangThai = trangThai;
                        vPt.PhanTramGiam = float.Parse(parts[6]);

                        if (parts.Length >= 8)
                        {
                            vPt.GiamToiDa = double.Parse(parts[7]);
                        }

                        ds.Add(vPt);
                    }
                }
            }
            return ds;
        }
    }
}