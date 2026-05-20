using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Services;
using static QuanLySieuThi.Services.BaoCaoThongKe;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Admin
{
    public partial class ucDashboard : UserControl
    {
        BaoCaoThongKe serviceThongKe = new BaoCaoThongKe(
                DataStorage.Instance.DanhSachHD,
                DataStorage.Instance.DanhSachHang
            );
        public ucDashboard()
        {
            InitializeComponent();
        }
        private void HienThiTopSanPham(BaoCaoThongKe service)
        {
            List<HangHoaDoanhThu> top5 = service.LayTopSanPhamBanChay(5);

            dgvTopSanPham.DataSource = null;
            dgvTopSanPham.DataSource = top5;
            if (dgvTopSanPham.Columns.Count > 0)
            {
                dgvTopSanPham.Columns["TenHang"].HeaderText = "Sản phẩm";
                dgvTopSanPham.Columns["DoanhThu"].HeaderText = "Doanh thu";
                dgvTopSanPham.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
                dgvTopSanPham.Columns["TenHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void CapNhatGiaoDien()
        {
            CapNhatDuLieuDashboard();
            HienThiTopSanPham(serviceThongKe);
            Console.WriteLine("Dashboard đã tự refresh lúc: " + DateTime.Now);
        }
        private void CapNhatDuLieuDashboard()
        {

            DateTime bayGio = DateTime.Now;
            double doanhThuThang = serviceThongKe.TinhDoanhThuTheoThang(bayGio.Month, bayGio.Year);
            int soDonHang = DataStorage.Instance.DanhSachHD.Count;
            int soKhachHang = DataStorage.Instance.DanhSachKH.Count;
            double chiPhiNhap = 0;
            foreach (PhieuNhap pn in DataStorage.Instance.DanhSachPhieuNhap)
            {
                chiPhiNhap += pn.TongTien;
            }

            lblTongDT.Text = doanhThuThang.ToString("N0") + " đ";
            lblSoDonHang.Text = soDonHang.ToString();
            lblKHMoi.Text = soKhachHang.ToString();
            lblCPNhapHang.Text = chiPhiNhap.ToString("N0") + " đ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            CapNhatDuLieuDashboard();
            HienThiTopSanPham(serviceThongKe);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
