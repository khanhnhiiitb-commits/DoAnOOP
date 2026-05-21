using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucManageProduct : UserControl
    {
        public event EventHandler DuLieuDaThayDoi;

        private QuanLyKho serviceKho;

        private InventoryRepository inventoryRepo = new InventoryRepository();
        public ucManageProduct()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void cbLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiChon = cbLoaiHH.Text;

            if (loaiChon == "Thực phẩm" || loaiChon == "Hàng Thực Phẩm")
            {
                // HIỆN Thực phẩm
                DatePickerSX.Visible = true;
                DatePickerHSD.Visible = true;

                // ẨN Điện tử
                txtThoiGianBH.Visible = false;
            }
            else if (loaiChon == "Điện tử" || loaiChon == "Hàng Điện Tử")
            {
                // ẨN Thực phẩm
                DatePickerSX.Visible = false;
                DatePickerHSD.Visible = false;

                // HIỆN Điện tử
                txtThoiGianBH.Visible = true;
            }
        }
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                if (dgvHangHoa.Rows[e.RowIndex].DataBoundItem is HangHoa hhChon)
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
        private void HienThiLenBang()
        {
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = DataStorage.Instance.DanhSachHang;
            if (dgvHangHoa.Columns["MaKeHang"] != null)
                dgvHangHoa.Columns["MaKeHang"].Visible = false;
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
                inventoryRepo.Save(DataStorage.Instance.DanhSachHang);
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
            string loaiChuan = "";

            if (cbLoaiHH.Text == "Thực phẩm")
                loaiChuan = "ThucPham";
            else if (cbLoaiHH.Text == "Điện tử")
                loaiChuan = "DienTu";

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
                    inventoryRepo.Save(DataStorage.Instance.DanhSachHang);
                    HienThiLenBang();
                    btnLuu.Enabled = false;
                    MessageBox.Show("Đã lưu vào file database_hanghoa.txt thành công!");
                    DuLieuDaThayDoi?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Mã hàng '" + maSua + "' để cập nhật trong RAM!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maXoa = txtMaHH.Text;
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);

            if (xacNhan == DialogResult.Yes)
            {
                bool ketQua = serviceKho.XuatHangHoa(maXoa);

                if (ketQua)
                {
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

       

        private void txtTimHH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimHH.Text.Trim().ToLower();
            List<HangHoa> ketQuaTimKiem = new List<HangHoa>();
            foreach (HangHoa hh in DataStorage.Instance.DanhSachHang)
            {
                if (hh.MaHH.ToLower().Contains(keyword) || hh.TenHang.ToLower().Contains(keyword))
                {
                    ketQuaTimKiem.Add(hh);
                }
            }
            dgvHangHoa.DataSource = ketQuaTimKiem;
        }
    }
}
