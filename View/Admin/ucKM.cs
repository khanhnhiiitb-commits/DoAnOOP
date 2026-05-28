using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Admin
{
    public partial class ucKM : UserControl
    {
        private QuanLyKhuyenMai serviceKM;

        public ucKM()
        {
            InitializeComponent();
            serviceKM = new QuanLyKhuyenMai(
                DataStorage.Instance.DanhSachKhuyenMai,
                DataStorage.Instance.DanhSachVoucher
            );
        }
        private void ucKM_Load(object sender, EventArgs e)
        {
            CauHinhDataGridView();
            HienThiLenBang();
            cbLoaiGiam.Items.Clear();
            cbLoaiGiam.Items.Add("%");
            cbLoaiGiam.Items.Add("VNĐ");

            if (cbLoaiGiam.Items.Count > 0)
            {
                cbLoaiGiam.SelectedIndex = 0;
            }
        }

        private void CauHinhDataGridView()
        {
            dgvKM.AutoGenerateColumns = false;
            dgvKM.Columns.Clear();
            dgvKM.Columns.Add("colMaKM", "Mã KM");
            dgvKM.Columns.Add("colTenKM", "Tên KM");
            dgvKM.Columns.Add("colMucGiam", "Mức giảm");
            dgvKM.Columns.Add("colTuNgay", "Từ ngày");
            dgvKM.Columns.Add("colDenNgay", "Đến ngày");
            dgvKM.Columns.Add("colTrangThai", "Trạng thái");

            dgvKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKM.AllowUserToAddRows = false;
            dgvKM.ReadOnly = true;
            dgvKM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void HienThiLenBang()
        {
            dgvKM.Rows.Clear();
            List<Voucher> dsVoucher = serviceKM.LayDanhSachVoucher();

            for (int i = 0; i < dsVoucher.Count; i++)
            {
                Voucher v = dsVoucher[i];
                string chuoiMucGiam = "";

                if (v is VoucherTienMat vTm)
                {
                    chuoiMucGiam = vTm.SoTienGiamCoDinh.ToString("N0") + " VNĐ";
                }
                else if (v is VoucherPhanTram vPt)
                {
                    chuoiMucGiam = vPt.PhanTramGiam.ToString() + " %";
                }

                string trangThai = v.TrangThai ? "Đang hoạt động" : "Đã vô hiệu hóa";

                // Đẩy dữ liệu tĩnh lên lưới
                dgvKM.Rows.Add(v.MaVoucher, v.TenVoucher, chuoiMucGiam, v.NgayBatDau.ToString("dd/MM/yyyy"), v.NgayKetThuc.ToString("dd/MM/yyyy"), trangThai);
            }
        }

        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKM.CurrentRow == null || dgvKM.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Vui lòng chọn một Voucher hợp lệ từ bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                object cellValue = dgvKM.CurrentRow.Cells["colMaKM"].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("Dòng được chọn không có Mã Voucher!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maDaChon = cellValue.ToString();
                bool thanhCong = serviceKM.DoiTrangThaiVoucher(maDaChon);

                if (thanhCong)
                {
                    serviceKM.LuuDuLieuVoucher();

                    HienThiLenBang();
                    MessageBox.Show("Đã thay đổi trạng thái Voucher thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Voucher trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKM.Text) || string.IsNullOrWhiteSpace(txtMucGiam.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DatePicker2.Value.Date < DatePicker1.Value.Date)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string loaiGiam = cbLoaiGiam.Text;
                double mucGiam;
                if (!double.TryParse(txtMucGiam.Text, out mucGiam))
                {
                    MessageBox.Show("Mức giảm phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Voucher vMoi = null;
                if (loaiGiam == "%")
                {
                    VoucherPhanTram vPt = new VoucherPhanTram();
                    vPt.PhanTramGiam = (float)mucGiam;
                    vPt.GiamToiDa = 500000;
                    vMoi = vPt;
                }
                else
                {
                    VoucherTienMat vTm = new VoucherTienMat();
                    vTm.SoTienGiamCoDinh = mucGiam;
                    vMoi = vTm;
                }

                vMoi.MaVoucher = txtMaKM.Text.Trim();
                vMoi.TenVoucher = txtTenKM.Text.Trim();
                vMoi.NgayBatDau = DatePicker1.Value.Date;
                vMoi.NgayKetThuc = DatePicker2.Value.Date;
                vMoi.TrangThai = true;

                serviceKM.ThemVoucher(vMoi);

                serviceKM.LuuDuLieuVoucher();

                HienThiLenBang();
                MessageBox.Show("Tạo Voucher thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}