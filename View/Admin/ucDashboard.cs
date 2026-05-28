using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Services;
using static QuanLySieuThi.Services.BaoCaoThongKe; 

namespace ChuongtrinhQuanlybanhangsieuthi.View.Admin
{
    public partial class ucDashboard : UserControl
    {
        private BaoCaoThongKe serviceThongKe;

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            CapNhatGiaoDien();
        }

        public void CapNhatGiaoDien()
        {
            try
            {
                serviceThongKe = new BaoCaoThongKe(
                    DataStorage.Instance.DanhSachHD,
                    DataStorage.Instance.DanhSachHang
                );
                CapNhatDuLieuDashboard();
                HienThiTopSanPham(serviceThongKe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Tổng quan: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CapNhatDuLieuDashboard()
        {
            double doanhThuThang, chiPhiNhap;
            int soDonHang;
            serviceThongKe.LayThongSoDashboard(DataStorage.Instance.DanhSachPhieuNhap, out doanhThuThang, out soDonHang, out chiPhiNhap);
            int soKhachHang = DataStorage.Instance.DanhSachKH.Count;
            lblTongDT.Text = doanhThuThang.ToString("N0") + " đ";
            lblSoDonHang.Text = soDonHang.ToString();
            lblKHMoi.Text = soKhachHang.ToString();
            lblCPNhapHang.Text = chiPhiNhap.ToString("N0") + " đ";
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
                dgvTopSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}