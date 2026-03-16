using System;

namespace QuanLySieuThi.Models.Systems
{//sua
    public class BangChamCong
    {
        public string MaNV { get; set; }           
        public DateTime NgayLamViec { get; set; }   
        public string GioVao { get; set; }         
        public string GioRa { get; set; }          
        public string MaTheTV { get; set; }        

        public BangChamCong() { }
    }
}