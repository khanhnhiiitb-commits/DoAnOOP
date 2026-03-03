namespace QuanLySieuThi.Models
{
    public class Voucher
    {
         private string maVoucher;
        private double giaTriGiam;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private bool trangThai;

        public string MaVoucher
        {
            get { return maVoucher; }
            set { maVoucher = value; }
        }

        public double GiaTriGiam
        {
            get { return giaTriGiam; }
            set { giaTriGiam = value; }
        }

        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public bool KiemTraHieuLuc()
        {
            DateTime homNay = DateTime.Now;

            if (trangThai == true &&
                homNay >= ngayBatDau &&
                homNay <= ngayKetThuc)
            {
                return true;
            }

            return false;
        }
    }
}