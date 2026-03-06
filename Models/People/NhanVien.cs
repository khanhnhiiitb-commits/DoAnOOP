namespace QuanLySieuThi.Models.People
{
    public class NhanVien : Nguoi
    {
        private string maNV;
        private string chucVu;
        private double luongCB;
        private DateTime ngayVaoLam;
        private string maCaLV;

        public string GetMaNV()
        {
            return maNV;
        }

        public void SetMaNV(string maNV)
        {
            this.maNV = maNV;
        }

        public string GetChucVu()
        {
            return chucVu;
        }

        public void SetChucVu(string chucVu)
        {
            this.chucVu = chucVu;
        }

        public double GetLuongCB()
        {
            return luongCB;
        }

        public void SetLuongCB(double luongCB)
        {
            this.luongCB = luongCB;
        }

        public DateTime GetNgayVaoLam()
        {
            return ngayVaoLam;
        }

        public void SetNgayVaoLam(DateTime ngayVaoLam)
        {
            this.ngayVaoLam = ngayVaoLam;
        }

        public string GetMaCaLV()
        {
            return maCaLV;
        }

        public void SetMaCaLV(string maCaLV)
        {
            this.maCaLV = maCaLV;
        }
    }
}