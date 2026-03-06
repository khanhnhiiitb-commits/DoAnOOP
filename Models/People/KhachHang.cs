namespace QuanLySieuThi.Models
{
    public class KhachHang : Nguoi
    {
        private string maKH;
        private int diemTichLuy;
        private string maTheTV;

        public string GetMaKH()
        {
            return maKH;
        }

        public void SetMaKH(string maKH)
        {
            this.maKH = maKH;
        }

        public int GetDiemTichLuy()
        {
            return diemTichLuy;
        }

        public void SetDiemTichLuy(int diemTichLuy)
        {
            this.diemTichLuy = diemTichLuy;
        }

        public string GetMaTheTV()
        {
            return maTheTV;
        }

        public void SetMaTheTV(string maTheTV)
        {
            this.maTheTV = maTheTV;
        }
    }
}