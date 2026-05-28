using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucPhieuNhap : UserControl
    {
        private QuanLyNhapHang serviceNhapHang;
        private QuanLyKho serviceKho;

        public ucPhieuNhap()
        {
            InitializeComponent();
        }

        private void ucPhieuNhap_Load(object sender, EventArgs e)
        {
            serviceNhapHang = new QuanLyNhapHang(DataStorage.Instance.DanhSachPhieuNhap);
            serviceKho = new QuanLyKho(DataStorage.Instance.DanhSachHang, new List<KeHang>());

            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("ChoXacNhan");
            cboTrangThai.Items.Add("HoanThanh");
            cboTrangThai.Items.Add("DaHuy");

            cboMaHang.Items.Clear();
            foreach (HangHoa hh in serviceKho.DanhSachHang)
            {
                cboMaHang.Items.Add(hh.MaHH);
            }

            HienThiDanhSach(serviceNhapHang.DanhSachPhieuNhap);
        }

        private void HienThiDanhSach(List<PhieuNhap> danhSach)
        {
            dgvPhieuNhap.Rows.Clear();
            foreach (PhieuNhap pn in danhSach)
            {
                dgvPhieuNhap.Rows.Add(
                    pn.MaPN,
                    pn.MaNCC,
                    pn.NgayNhap.ToString("dd/MM/yyyy"),
                    pn.TrangThai,
                    pn.TongTien.ToString("N0")
                );
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPhieuNhap.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

            txtMaPN.Text = row.Cells[0].Value?.ToString();
            txtNCC.Text = row.Cells[1].Value?.ToString();

            DateTime ngayNhap;
            if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out ngayNhap))
            {
                dtNgayNhap.Value = ngayNhap;
            }

            cboTrangThai.Text = row.Cells[3].Value?.ToString();
            txtTongTien.Text = row.Cells[4].Value?.ToString();

            string maDuocChon = txtMaPN.Text;
            dgvChiTietPhieuNhap.Rows.Clear();

            foreach (PhieuNhap p in serviceNhapHang.DanhSachPhieuNhap)
            {
                if (p.MaPN == maDuocChon)
                {
                    foreach (ChiTietPhieuNhap ctpn in p.DanhSachChiTiet)
                    {
                        dgvChiTietPhieuNhap.Rows.Add(
                            ctpn.MaHH,
                            ctpn.SoLuong,
                            ctpn.DonGia.ToString("N0"),
                            (ctpn.SoLuong * ctpn.DonGia).ToString("N0")
                        );
                    }
                    break;
                }
            }
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNCC.Text) || string.IsNullOrWhiteSpace(cboMaHang.Text))
                {
                    MessageBox.Show("Vui lòng điền đủ Nhà cung cấp và Mã hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = txtNCC.Text.Trim();

                PhieuNhap pn = serviceNhapHang.LapPhieuNhap(ncc);

                HangHoa hangDuocChon = null;
                foreach (HangHoa hh in serviceKho.DanhSachHang)
                {
                    if (hh.MaHH == cboMaHang.Text)
                    {
                        hangDuocChon = hh;
                        break;
                    }
                }

                serviceNhapHang.ThemChiTietPhieuNhap(pn, hangDuocChon, int.Parse(txtSoLuongNhap.Text), double.Parse(txtDonGiaNhap.Text));
                serviceNhapHang.XacNhanNhapKho(pn, serviceKho);
                serviceNhapHang.LuuDuLieuPhieuNhap();
                serviceKho.LuuDuLieuKho();

                HienThiDanhSach(serviceNhapHang.DanhSachPhieuNhap);
                MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuNhap.CurrentRow == null || dgvPhieuNhap.CurrentRow.IsNewRow) return;

                string maPN = txtMaPN.Text.Trim();
                foreach (PhieuNhap pn in serviceNhapHang.DanhSachPhieuNhap)
                {
                    if (pn.MaPN == maPN)
                    {
                        pn.MaNCC = txtNCC.Text.Trim();
                        pn.NgayNhap = dtNgayNhap.Value;
                        pn.TrangThai = cboTrangThai.Text;
                        pn.TinhTongTien();
                        break;
                    }
                }
                serviceNhapHang.LuuDuLieuPhieuNhap();

                HienThiDanhSach(serviceNhapHang.DanhSachPhieuNhap);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuNhap.CurrentRow == null || dgvPhieuNhap.CurrentRow.IsNewRow) return;

                string maPN = txtMaPN.Text.Trim();
                DialogResult xacNhan = MessageBox.Show($"Bạn có chắc chắn muốn hủy phiếu {maPN}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (xacNhan == DialogResult.Yes)
                {
                    bool ketQua = serviceNhapHang.HuyPhieuNhap(maPN);

                    if (ketQua)
                    {
                        serviceNhapHang.LuuDuLieuPhieuNhap();
                        HienThiDanhSach(serviceNhapHang.DanhSachPhieuNhap);
                        MessageBox.Show("Hủy phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy! Phiếu này đã xác nhận hoặc không tồn tại.", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchPN_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchPN.Text.Trim().ToLower();
            List<PhieuNhap> ketQua = new List<PhieuNhap>();

            foreach (PhieuNhap pn in serviceNhapHang.DanhSachPhieuNhap)
            {
                if (pn.MaPN.ToLower().Contains(keyword) || pn.MaNCC.ToLower().Contains(keyword))
                {
                    ketQua.Add(pn);
                }
            }
            HienThiDanhSach(ketQua);
        }
    }
}