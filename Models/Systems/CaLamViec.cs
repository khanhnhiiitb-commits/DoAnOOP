namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
    {
        // Private Fields (Trường dữ liệu riêng tư)
        private string maCa;
        private string tenCa;
        private TimeSpan gioBatDau;
        private TimeSpan gioKetThuc;

        // Properties 
        public string MaCa
        {
            get { return maCa; }
            set { maCa = value; }
        }

        public string TenCa
        {
            get { return tenCa; }
            set { tenCa = value; }
        }

        public TimeSpan GioBatDau
        {
            get { return gioBatDau; }
            set { gioBatDau = value; }
        }

        public TimeSpan GioKetThuc
        {
            get { return gioKetThuc; }
            set 
            {
                if (value > gioBatDau)
                {
                    gioKetThuc = value;
                }
                else
                {
                    // Nếu nhập sai, tự động cộng thêm 8 tiếng làm việc tiêu chuẩn tính từ giờ bắt đầu
                    gioKetThuc = gioBatDau.Add(TimeSpan.FromHours(8));
                }
            }
        }

        // Constructor 
        public CaLamViec() { }

        public CaLamViec(string maCa, string tenCa, TimeSpan batDau, TimeSpan ketThuc)
        {
            this.MaCa = maCa;
            this.TenCa = tenCa;
            this.GioBatDau = batDau;
            this.GioKetThuc = ketThuc;
        }
    
    }
}