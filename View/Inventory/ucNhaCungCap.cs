using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucNhaCungCap : UserControl
    {
        private QuanLyDoiTac serviceDoiTac;

        public ucNhaCungCap()
        {
            InitializeComponent();
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            serviceDoiTac = new QuanLyDoiTac(DataStorage.Instance.DanhSachKH, DataStorage.Instance.DanhSachNCC);

            HienThiDanhSach(serviceDoiTac.DanhSachNCC);
        }

        private void HienThiDanhSach(List<NhaCungCap> danhSach)
        {
            dgvNCC.Rows.Clear();

            foreach (NhaCungCap ncc in danhSach)
            {
                dgvNCC.Rows.Add(
                    ncc.MaNCC,
                    ncc.TenNCC,
                    ncc.DiaChi,
                    ncc.SoDienThoai,
                    ncc.Email
                );
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNCC.Text) || string.IsNullOrWhiteSpace(txtTenNCC.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã và Tên Nhà Cung Cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = txtMaNCC.Text.Trim();
                ncc.TenNCC = txtTenNCC.Text.Trim();
                ncc.DiaChi = txtDiaChi.Text.Trim();
                ncc.SoDienThoai = txtSDT.Text.Trim();
                ncc.Email = txtEmail.Text.Trim();

                bool ketQua = serviceDoiTac.ThemNhaCungCap(ncc);
                if (ketQua)
                {
                    serviceDoiTac.LuuDuLieuDoiTac();
                    HienThiDanhSach(serviceDoiTac.DanhSachNCC);
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNCC.CurrentRow == null || dgvNCC.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp từ bảng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maNCC = txtMaNCC.Text.Trim();
                string tenMoi = txtTenNCC.Text.Trim();
                string sdtMoi = txtSDT.Text.Trim();
                string emailMoi = txtEmail.Text.Trim();

                bool ketQua = serviceDoiTac.CapNhatThongTinNCC(maNCC, tenMoi, sdtMoi, emailMoi);

                if (ketQua)
                {
                    foreach (NhaCungCap ncc in serviceDoiTac.DanhSachNCC)
                    {
                        if (ncc.MaNCC == maNCC)
                        {
                            ncc.DiaChi = txtDiaChi.Text.Trim();
                            break;
                        }
                    }

                    serviceDoiTac.LuuDuLieuDoiTac();
                    HienThiDanhSach(serviceDoiTac.DanhSachNCC);
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhà cung cấp để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNCC.CurrentRow == null || dgvNCC.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp từ bảng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maXoa = txtMaNCC.Text.Trim();
                DialogResult xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn xóa {maXoa}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (xacNhan == DialogResult.Yes)
                {
                    bool ketQua = serviceDoiTac.XoaNhaCungCap(maXoa);
                    if (ketQua)
                    {
                        serviceDoiTac.LuuDuLieuDoiTac();
                        HienThiDanhSach(serviceDoiTac.DanhSachNCC);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNCC.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
            txtMaNCC.Text = row.Cells[0].Value?.ToString();
            txtTenNCC.Text = row.Cells[1].Value?.ToString();
            txtDiaChi.Text = row.Cells[2].Value?.ToString();
            txtSDT.Text = row.Cells[3].Value?.ToString();
            txtEmail.Text = row.Cells[4].Value?.ToString();

            txtMaNCC.Enabled = false; 
        }

        private void txtSearchNCC_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchNCC.Text.Trim().ToLower();
            List<NhaCungCap> ketQua = new List<NhaCungCap>();

            foreach (NhaCungCap ncc in serviceDoiTac.DanhSachNCC)
            {
                if (ncc.MaNCC.ToLower().Contains(keyword) || ncc.TenNCC.ToLower().Contains(keyword))
                {
                    ketQua.Add(ncc);
                }
            }
            HienThiDanhSach(ketQua);
        }

        
    }
}