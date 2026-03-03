using System;

namespace QuanLySieuThi.Models.Systems
{
    public class BangChamCong
    {
        public string MaNV { get; set; }           
        public DateTime NgayLamViec { get; set; }   
        public string GioVao { get; set; }         
        public string GioRa { get; set; }          
        public string MaTheTV { get; set; }        

        // Constructor không tham số
        public BangChamCong() { }

        // Constructor đầy đủ tham số
        public BangChamCong(string maNV, DateTime ngayLam, string gioVao, string gioRa, string maThe)
        {
            MaNV = maNV;
            NgayLamViec = ngayLam;
            GioVao = gioVao;
            GioRa = gioRa;
            MaTheTV = maThe;
        }

        // Phương thức hiển thị thông tin (ví dụ)
        public void HienThiThongTin()
        {
            Console.WriteLine($"NV: {MaNV} | Ngay: {NgayLamViec:dd/MM/yyyy} | Vao: {GioVao} | Ra: {GioRa}");
        }
    }
}