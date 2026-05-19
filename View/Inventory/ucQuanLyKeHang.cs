using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucQuanLyKeHang : UserControl
    {
        private KeHangRepository repo = new KeHangRepository();

        public ucQuanLyKeHang()
        {
            InitializeComponent();
        }

        private void ucQuanLyKeHang_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu từ File txt thẳng vào KHO RAM
            DataStorage.Instance.DanhSachKeHang = repo.GetAll();

            cboKhuVuc.Items.Clear();
            cboKhuVuc.Items.Add("Khu A");
            cboKhuVuc.Items.Add("Khu B");
            cboKhuVuc.Items.Add("Khu C");

            cboLoaiHang.Items.Clear();
            cboLoaiHang.Items.Add("Điện tử");
            cboLoaiHang.Items.Add("Thực phẩm");
            cboLoaiHang.Items.Add("Gia dụng");

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Còn trống");
            cboTrangThai.Items.Add("Đang sử dụng");

            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dgvKeHang.Rows.Clear();

            // Lấy dữ liệu từ Kho RAM ra hiển thị
            foreach (KeHang ke in DataStorage.Instance.DanhSachKeHang)
            {
                dgvKeHang.Rows.Add(
                    ke.MaKe,
                    ke.ViTri,
                    ke.LoaiHang,
                    ke.SucChua,
                    ke.TrangThai
                );
            }
        }

        private void btnThemKeHang_Click(object sender, EventArgs e)
        {
            try
            {
                KeHang ke = new KeHang();
                ke.MaKe = txtMaKe.Text.Trim();
                ke.ViTri = cboKhuVuc.Text;
                ke.LoaiHang = cboLoaiHang.Text;
                ke.SucChua = int.Parse(txtSucChua.Text); // Nếu nhập chữ sẽ nhảy xuống catch

                // Thêm vào Kho RAM
                DataStorage.Instance.DanhSachKeHang.Add(ke);

                // Lưu xuống File txt
                repo.Save(DataStorage.Instance.DanhSachKeHang);

                HienThiDanhSach();
                MessageBox.Show("Thêm kệ hàng thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Sức chứa phải là một con số hợp lệ!", "Lỗi nhập liệu");
            }
        }

        private void btnXoaKeHang_Click(object sender, EventArgs e)
        {
            if (dgvKeHang.CurrentRow == null || dgvKeHang.CurrentRow.IsNewRow)
            {
                return;
            }

            int index = dgvKeHang.CurrentRow.Index;

            // Xóa khỏi Kho RAM
            DataStorage.Instance.DanhSachKeHang.RemoveAt(index);

            // Lưu lại File txt
            repo.Save(DataStorage.Instance.DanhSachKeHang);

            HienThiDanhSach();
            MessageBox.Show("Xóa thành công!");
        }

        private void btnSuaKeHang_Click(object sender, EventArgs e)
        {
            if (dgvKeHang.CurrentRow == null || dgvKeHang.CurrentRow.IsNewRow)
            {
                return;
            }

            try
            {
                int index = dgvKeHang.CurrentRow.Index;

                // Cập nhật lại trong Kho RAM
                DataStorage.Instance.DanhSachKeHang[index].MaKe = txtMaKe.Text.Trim();
                DataStorage.Instance.DanhSachKeHang[index].ViTri = cboKhuVuc.Text;
                DataStorage.Instance.DanhSachKeHang[index].LoaiHang = cboLoaiHang.Text;
                DataStorage.Instance.DanhSachKeHang[index].SucChua = int.Parse(txtSucChua.Text);

                // Lưu lại File txt
                repo.Save(DataStorage.Instance.DanhSachKeHang);

                HienThiDanhSach();
                MessageBox.Show("Sửa thành công!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Sức chứa phải là một con số hợp lệ!", "Lỗi nhập liệu");
            }
        }

        private void dgvKeHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvKeHang.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            txtMaKe.Text = dgvKeHang.Rows[e.RowIndex].Cells[0].Value?.ToString();
            cboKhuVuc.Text = dgvKeHang.Rows[e.RowIndex].Cells[1].Value?.ToString();
            cboLoaiHang.Text = dgvKeHang.Rows[e.RowIndex].Cells[2].Value?.ToString();
            txtSucChua.Text = dgvKeHang.Rows[e.RowIndex].Cells[3].Value?.ToString();
            cboTrangThai.Text = dgvKeHang.Rows[e.RowIndex].Cells[4].Value?.ToString();
        }

        private void txtSearchKeHang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchKeHang.Text.Trim().ToLower();

            dgvKeHang.Rows.Clear();

            // Tìm trực tiếp trong Kho RAM
            foreach (KeHang ke in DataStorage.Instance.DanhSachKeHang)
            {
                if (ke.MaKe.ToLower().Contains(keyword))
                {
                    dgvKeHang.Rows.Add(
                        ke.MaKe,
                        ke.ViTri,
                        ke.LoaiHang,
                        ke.SucChua,
                        ke.TrangThai
                    );
                }
            }
        }
    }
}