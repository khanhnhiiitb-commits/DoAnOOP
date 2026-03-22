using System;
using System.Collections.Generic;
using QuanLySieuThi.Models.Sales;

namespace QuanLySieuThi.Models.Systems
{
  public class PhieuNhap
 {
    
        private string maPN;
        private string maNCC;
        private NhaCungCap nhaCC;
        private DateTime ngayNhap;
        private double tongTien; 
        private string trangThai;
        private string soDienThoai;
        private string email;
        private List<ChiTietPhieuNhap> danhSachChiTiet = new List<ChiTietPhieuNhap>();

        // Properties
        public string MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public NhaCungCap NhaCC
        {
            get { return nhaCC; }
            set { nhaCC = value; }
        }

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public double TongTien
        {
            get { return tongTien; }
            set { if (value >= 0) tongTien = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<ChiTietPhieuNhap> DanhSachChiTiet 
        { 
            get { return danhSachChiTiet; } 
        }

        // Phương thức để tính lại tổng tiền dựa trên các chi tiết
        public void TinhTongTien()
        {
            double tong = 0;
            foreach (var ct in danhSachChiTiet)
            {
                tong += ct.ThanhTien;
            }
            this.tongTien = tong;
        }

        // Constructor mặc định
        public PhieuNhap() { }


        public PhieuNhap(string maPN, NhaCungCap ncc, DateTime ngayNhap, double tongTien, string sdt, string email)
        {
            this.maPN = maPN;
            this.nhaCC = ncc; // Lưu cả đối tượng thay vì chỉ lưu mã
            this.maNCC = ncc?.MaNCC; // Vẫn giữ mã để sau này lưu file txt dễ dàng
            this.ngayNhap = ngayNhap;
            this.tongTien = tongTien;
            this.soDienThoai = sdt;
            this.email = email;
            this.trangThai = "ChoXacNhan"; // Trạng thái mặc định
            this.danhSachChiTiet = new List<ChiTietPhieuNhap>();
        }
   }
}