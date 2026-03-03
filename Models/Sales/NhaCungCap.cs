namespace QuanLySieuThi.Models
{
    public class NhaCungCap
    {
         private string maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;
        private string soDienThoai;
        private string email;

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }

        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
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

        public NhaCungCap()
        {
        }

        public NhaCungCap(string ma, string ten, string diaChi, string soDienThoai, string email)
        {
            this.maNhaCungCap = ma;
            this.tenNhaCungCap = ten;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
        }

        public override string ToString()
        {
            return "Mã NCC: " + maNhaCungCap +
                   " | Tên: " + tenNhaCungCap +
                   " | SĐT: " + soDienThoai;
        }
    }
}