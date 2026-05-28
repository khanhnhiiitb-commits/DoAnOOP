using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucTonKho : UserControl
    {
        private QuanLyKho serviceKho;

        public ucTonKho()
        {
            InitializeComponent();
        }

        private void ucTonKho_Load(object sender, EventArgs e)
        {
            serviceKho = new QuanLyKho(DataStorage.Instance.DanhSachHang, DataStorage.Instance.DanhSachKeHang);

            HienThiDanhSach(serviceKho.DanhSachHang);
            CapNhatThongKe();
        }

        private void HienThiDanhSach(List<HangHoa> ds)
        {
            dgvKho.Rows.Clear();

            foreach (HangHoa hh in ds)
            {
                string loai = "";
                if (hh is HangDienTu) loai = "Điện tử";
                if (hh is HangThucPham) loai = "Thực phẩm";

                string trangThai = "Còn hàng";
                if (hh.SoLuongTon < 10) trangThai = "Sắp hết";

                int rowIndex = dgvKho.Rows.Add(
                    hh.MaHH,
                    hh.TenHang,
                    loai,
                    hh.SoLuongTon,
                    hh.MaKeHang,
                    trangThai
                );

                if (hh.SoLuongTon < 10)
                {
                    dgvKho.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void CapNhatThongKe()
        {
            int tongSKU, sapHet;
            double tongGiaTri;

            serviceKho.LapThongKeTonKho(out tongSKU, out sapHet, out tongGiaTri);

            lblTongSKU.Text = tongSKU.ToString();
            lblSapHet.Text = sapHet.ToString();
            lblTongGiaTri.Text = tongGiaTri.ToString("N0") + " VNĐ";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                HienThiDanhSach(serviceKho.DanhSachHang);
            }
            else
            {
                List<HangHoa> ketQua = serviceKho.TimKiemHangHoa(keyword);
                HienThiDanhSach(ketQua);
            }
        }

        private void btnSearchTonKho_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                HienThiDanhSach(serviceKho.DanhSachHang);
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<HangHoa> ketQua = serviceKho.TimKiemHangHoa(keyword);
            HienThiDanhSach(ketQua);

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadTonKho_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiDanhSach(serviceKho.DanhSachHang);
                CapNhatThongKe();

                MessageBox.Show("Đã làm mới dữ liệu tồn kho!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}