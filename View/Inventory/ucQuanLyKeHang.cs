using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Data;
using QuanLySieuThi.Services; // Thêm thư viện BLL
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucQuanLyKeHang : UserControl
    {
        private QuanLyKho serviceKho;

        public ucQuanLyKeHang()
        {
            InitializeComponent();
        }

        private void ucQuanLyKeHang_Load(object sender, EventArgs e)
        {
            serviceKho = new QuanLyKho(DataStorage.Instance.DanhSachHang, DataStorage.Instance.DanhSachKeHang);

            cboKhuVuc.Items.Clear();
            cboKhuVuc.Items.Add("Khu A");
            cboKhuVuc.Items.Add("Khu B");
            cboKhuVuc.Items.Add("Khu C");

            cboLoaiHang.Items.Clear();
            cboLoaiHang.Items.Add("Điện tử");
            cboLoaiHang.Items.Add("Thực phẩm");
            cboLoaiHang.Items.Add("Gia dụng");

 

            HienThiDanhSach(serviceKho.DanhSachKe);
        }

        private void HienThiDanhSach(List<KeHang> danhSach)
        {
            dgvKeHang.Rows.Clear();
            foreach (KeHang ke in danhSach)
            {
                dgvKeHang.Rows.Add(
                    ke.MaKe,
                    ke.ViTri,
                    ke.LoaiHang,
                    ke.SucChua,
                    ke.SoLuongHienTai,
                    ke.TrangThai
                );
            }
        }

        private void btnThemKeHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKe.Text))
                {
                    MessageBox.Show("Mã kệ không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KeHang ke = new KeHang();
                ke.MaKe = txtMaKe.Text.Trim();
                ke.ViTri = cboKhuVuc.Text;
                ke.LoaiHang = cboLoaiHang.Text;
                ke.SucChua = int.Parse(txtSucChua.Text);
                bool thanhCong = serviceKho.ThemKeHang(ke);

                if (thanhCong)
                {
                    serviceKho.LuuDuLieuKeHang(); 
                    HienThiDanhSach(serviceKho.DanhSachKe);
                    MessageBox.Show("Thêm kệ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã kệ hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sức chứa phải là một con số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaKeHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKeHang.CurrentRow == null || dgvKeHang.CurrentRow.IsNewRow) return;

                string maKeCu = txtMaKe.Text.Trim();

                KeHang keUpdate = new KeHang();
                keUpdate.ViTri = cboKhuVuc.Text;
                keUpdate.LoaiHang = cboLoaiHang.Text;
                keUpdate.SucChua = int.Parse(txtSucChua.Text);

                bool thanhCong = serviceKho.CapNhatKeHang(maKeCu, keUpdate);

                if (thanhCong)
                {
                    serviceKho.LuuDuLieuKeHang();
                    HienThiDanhSach(serviceKho.DanhSachKe);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã kệ này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sức chứa phải là một con số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKeHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKeHang.CurrentRow == null || dgvKeHang.CurrentRow.IsNewRow) return;

                string maXoa = txtMaKe.Text.Trim();

                DialogResult xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa kệ {maXoa}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (xacNhan == DialogResult.Yes)
                {
                    bool thanhCong = serviceKho.XoaKeHang(maXoa);
                    if (thanhCong)
                    {
                        serviceKho.LuuDuLieuKeHang();
                        HienThiDanhSach(serviceKho.DanhSachKe);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã kệ này để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKeHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvKeHang.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvKeHang.Rows[e.RowIndex];
            txtMaKe.Text = row.Cells[0].Value?.ToString();
            cboKhuVuc.Text = row.Cells[1].Value?.ToString();
            cboLoaiHang.Text = row.Cells[2].Value?.ToString();
            txtSucChua.Text = row.Cells[3].Value?.ToString();

            txtMaKe.Enabled = false; // Ngăn người dùng sửa Mã Kệ
        }

        private void txtSearchKeHang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchKeHang.Text.Trim().ToLower();
            List<KeHang> ketQua = new List<KeHang>();

            foreach (KeHang ke in serviceKho.DanhSachKe)
            {
                if (ke.MaKe.ToLower().Contains(keyword))
                {
                    ketQua.Add(ke);
                }
            }

            HienThiDanhSach(ketQua);
        }
    }
}