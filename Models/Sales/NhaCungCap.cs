using System;

namespace Sales
{
    public class NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string soDienThoai;
        private string email;

        public string MaNCC { get { return maNCC; } set { maNCC = value; } }
        public string TenNCC { get { return tenNCC; } set { tenNCC = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        public string SoDienThoai { get { return soDienThoai; } set { soDienThoai = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}