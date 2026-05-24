using System;
using System.Collections.Generic;
using System.IO;
using QuanLySieuThi.Models.Sales;  
using QuanLySieuThi.Data; 
using System.Windows.Forms;
namespace QuanLySieuThi.Data
{
    // Kế thừa Interface và truyền cụ thể kiểu dữ liệu là Voucher
    public class VoucherRepository : ITextSerializable<Voucher>
    {
        private readonly string filePath = @"\DataAccess\DatabaseFile\database_voucher.txt";
        public void Save(List<Voucher> danhSach)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Voucher v in danhSach)
                    {
                        string thongTinChung = v.MaVoucher + "|" + v.TenVoucher + "|" +
                                               v.NgayBatDau.ToString("yyyy/MM/dd") + "|" +
                                               v.NgayKetThuc.ToString("yyyy/MM/dd") + "|" +
                                               v.TrangThai;

                        if (v is VoucherTienMat)
                        {
                            VoucherTienMat tm = (VoucherTienMat)v;
                            sw.WriteLine("TM|" + thongTinChung + "|" + tm.SoTienGiamCoDinh);
                        }
                        else if (v is VoucherPhanTram)
                        {
                            VoucherPhanTram pt = (VoucherPhanTram)v;
                            sw.WriteLine("PT|" + thongTinChung + "|" + pt.PhanTramGiam + "|" + pt.GiamToiDa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file Voucher: " + ex.Message);
            }
        }
        public List<Voucher> GetAll()
        {
            List<Voucher> ds = new List<Voucher>();

            if (!File.Exists(filePath)) return ds;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file Voucher: " + ex.Message);
            }
            return ds;
        }
    }
}