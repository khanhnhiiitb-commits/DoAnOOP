namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
    {
       public string MaCa { get; set; }          // Ví dụ: CA01, CA02
        public string TenCa { get; set; }         // Ví dụ: Ca Sáng, Ca Chiều
        public string GioBatDau { get; set; }     // Định dạng "HH:mm" (ví dụ: "08:00")
        public string GioKetThuc { get; set; }    // Định dạng "HH:mm" (ví dụ: "12:00")
        public string MoTa { get; set; }          // Ghi chú thêm về ca làm việc

        // Constructor không tham số
        public CaLamViec() { }

        // Constructor đầy đủ tham số
        public CaLamViec(string maCa, string tenCa, string gioBatDau, string gioKetThuc, string moTa = "")
        {
            MaCa = maCa;
            TenCa = tenCa;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
            MoTa = moTa;
        }// Phương thức kiểm tra tổng thời gian của ca (tính bằng giờ)
        public double TinhTongThoiGian()
        {
            if (DateTime.TryParse(GioBatDau, out DateTime start) && DateTime.TryParse(GioKetThuc, out DateTime end))
            {
                TimeSpan duration = end - start;
                // Trường hợp ca làm việc xuyên đêm (ví dụ từ 22h đến 06h sáng hôm sau)
                if (duration.TotalHours < 0)
                {
                    return duration.TotalHours + 24;
                }
                return duration.TotalHours;
            }
            return 0;
        }
    }
}