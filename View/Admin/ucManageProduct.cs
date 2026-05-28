using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Data;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucManageProduct : UserControl
    {
        public event EventHandler DuLieuDaThayDoi;
        private QuanLyKho serviceKho;

        public ucManageProduct()
        {
            InitializeComponent();
        }

        private void ucManageProduct_Load(object sender, EventArgs e)
        {
            cbLoaiHH.Items.Clear();
            cbLoaiHH.Items.Add("Thực phẩm");
            cbLoaiHH.Items.Add("Điện tử");
            if (cbLoaiHH.Items.Count > 0)
            {
                cbLoaiHH.SelectedIndex = 0;
            }

            serviceKho = new QuanLyKho(DataStorage.Instance.DanhSachHang, new List<KeHang>());
            HienThiLenBang();
        }

        private void HienThiLenBang()
        {
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = serviceKho.DanhSachHang;
            if (dgvHangHoa.Columns["MaKeHang"] != null)
                dgvHangHoa.Columns["MaKeHang"].Visible = false;
        }

        private void cbLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiChon = cbLoaiHH.Text;

            if (loaiChon == "Thực phẩm" || loaiChon == "Hàng Thực Phẩm")
            {
                DatePickerSX.Visible = true;
                DatePickerHSD.Visible = true;
                txtThoiGianBH.Visible = false;
            }
            else if (loaiChon == "Điện tử" || loaiChon == "Hàng Điện Tử")
            {
                DatePickerSX.Visible = false;
                DatePickerHSD.Visible = false;
                txtThoiGianBH.Visible = true;
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                if (row.DataBoundItem is HangHoa hhChon)
                {
                    txtMaHH.Text = hhChon.MaHH;
                    txtTenHH.Text = hhChon.TenHang;
                    txtDonGia.Text = hhChon.DonGia.ToString();
                    txtDVT.Text = hhChon.DonViTinh;
                    txtMaHH.Enabled = false;

                    if (row.DataBoundItem is HangThucPham tp)
                    {
                        cbLoaiHH.Text = "Thực phẩm";
                        DatePickerSX.Value = tp.NgaySX;
                        DatePickerHSD.Value = tp.HSD;
                    }
                    else if (row.DataBoundItem is HangDienTu dt)
                    {
                        cbLoaiHH.Text = "Điện tử";
                        txtThoiGianBH.Text = dt.ThoiGianBH.ToString();
                    }
                }
            }
        }

        public void XuLyThemHang(string luaChonTuComboBox)
        {
            try
            {
                HangHoa spMoi = HangHoaFactory.TaoHangHoa(luaChonTuComboBox);

                spMoi.MaHH = txtMaHH.Text;
                spMoi.TenHang = txtTenHH.Text;
                spMoi.DonGia = Convert.ToDouble(txtDonGia.Text);

                if (spMoi is HangThucPham tp)
                {
                    tp.HSD = DatePickerHSD.Value;
                    tp.NgaySX = DatePickerSX.Value;
                }
                else if (spMoi is HangDienTu dt)
                {
                    dt.ThoiGianBH = int.Parse(txtThoiGianBH.Text);
                }

                serviceKho.ThemHangHoa(spMoi);
                serviceKho.LuuDuLieuKho();
                HienThiLenBang();
                MessageBox.Show("Đã thêm hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string loaiChuan = (cbLoaiHH.Text == "Thực phẩm") ? "ThucPham" : "DienTu";
            XuLyThemHang(loaiChuan);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ bảng để cập nhật!", "Thông báo");
                return;
            }
            btnLuu.Enabled = true;
            MessageBox.Show("Bây giờ bạn có thể sửa thông tin và bấm 'Lưu' để hoàn tất.", "Thông báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maSua = txtMaHH.Text.Trim();
                int soLuongHienTai = serviceKho.KiemTraTonKho(maSua);
                string loaiChuan = (cbLoaiHH.Text == "Thực phẩm") ? "ThucPham" : "DienTu";

                HangHoa spMoi = HangHoaFactory.TaoHangHoa(loaiChuan);
                spMoi.MaHH = maSua;
                spMoi.TenHang = txtTenHH.Text;
                spMoi.DonGia = Convert.ToDouble(txtDonGia.Text);
                spMoi.DonViTinh = txtDVT.Text;
                spMoi.SoLuongTon = soLuongHienTai;

                if (spMoi is HangThucPham tp)
                {
                    tp.HSD = DatePickerHSD.Value;
                    tp.NgaySX = DatePickerSX.Value;
                }
                else if (spMoi is HangDienTu dt)
                {
                    dt.ThoiGianBH = int.Parse(txtThoiGianBH.Text);
                }

                bool ketQua = serviceKho.CapNhatThongTin(maSua, spMoi);
                if (ketQua)
                {
                    serviceKho.LuuDuLieuKho();
                    HienThiLenBang();
                    btnLuu.Enabled = false;
                    MessageBox.Show("Đã lưu vào cơ sở dữ liệu thành công!", "Thông báo");
                    DuLieuDaThayDoi?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã hàng '" + maSua + "' để cập nhật trong hệ thống!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maXoa = txtMaHH.Text;
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (xacNhan == DialogResult.Yes)
            {
                bool ketQua = serviceKho.XuatHangHoa(maXoa);

                if (ketQua)
                {
                    serviceKho.LuuDuLieuKho();
                    HienThiLenBang();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hàng để xóa!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHH.Clear();
            txtTenHH.Clear();
            txtDonGia.Clear();
            txtThoiGianBH.Clear();
            txtMaHH.Enabled = true;
            txtMaHH.Focus();
        }

        private void txtTimHH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimHH.Text.Trim();
            List<HangHoa> ketQuaTimKiem = serviceKho.TimKiemHangHoa(keyword);
            dgvHangHoa.DataSource = ketQuaTimKiem;
        }
    }
}