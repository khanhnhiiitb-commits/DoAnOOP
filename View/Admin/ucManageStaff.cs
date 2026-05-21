using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucManageStaff : UserControl
    {
        private QuanLyNhanSu serviceNhanSu;
        private StaffRepository staffRepo = new StaffRepository();

        private void HienThiLenBang()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = DataStorage.Instance.DanhSachNV;
            if (dgvNhanVien.Columns["MaNV"] != null) dgvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            if (dgvNhanVien.Columns["HoTen"] != null) dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và tên";
            if (dgvNhanVien.Columns["ChucVu"] != null) dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            if (dgvNhanVien.Columns["NgayVaoLam"] != null) dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
            if (dgvNhanVien.Columns["NgaySinh"] != null) dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            if (dgvNhanVien.Columns["SoDienThoai"] != null) dgvNhanVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            if (dgvNhanVien.Columns["DiaChi"] != null) dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            if (dgvNhanVien.Columns["Taikhoan"] != null)
            {
                dgvNhanVien.Columns["Taikhoan"].Visible = false;
            }
            if (dgvNhanVien.Columns["GioiTinh"] != null)
                dgvNhanVien.Columns["GioiTinh"].Visible = false;
            if (dgvNhanVien.Columns["HienThiGioiTinh"] != null)
                dgvNhanVien.Columns["HienThiGioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["Ma"].Visible = false;
            dgvNhanVien.Columns["MaCa"].Visible = false;
        }
        public ucManageStaff()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucManageStaff_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;

            serviceNhanSu = new QuanLyNhanSu(
                DataStorage.Instance.DanhSachNV,
                    DataStorage.Instance.DanhSachBCM,
                DataStorage.Instance.DanhSachTaiKhoan
                 );
            HienThiLenBang();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvNhanVien.Rows[e.RowIndex];
                if (row.DataBoundItem is NhanVien nv)
                {
                    txtMaNV.Text = nv.Ma;
                    txtHoTen.Text = nv.HoTen;
                    cboGioiTinh.Text = nv.GioiTinh ? "Nam" : "Nữ";
                    txtLuongCB.Text = nv.LuongCB.ToString("N0");
                    txtSDT.Text = nv.SoDienThoai;
                    txtChucVu.Text = nv.ChucVu;
                    txtDiaChi.Text = nv.DiaChi;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nvMoi = new NhanVien();
                nvMoi.Ma = txtMaNV.Text;
                nvMoi.HoTen = txtHoTen.Text;
                nvMoi.SoDienThoai = txtSDT.Text;
                nvMoi.ChucVu = txtChucVu.Text;
                nvMoi.GioiTinh = (cboGioiTinh.Text == "Nam");
                nvMoi.DiaChi = txtDiaChi.Text;
                nvMoi.LuongCB = 5000000;
                nvMoi.NgayVaoLam = DateTime.Now;
                serviceNhanSu.ThemNhanVien(nvMoi);
                List<Nguoi> dsTam = new List<Nguoi>();
                foreach (NhanVien item in DataStorage.Instance.DanhSachNV)
                {
                    dsTam.Add(item);
                }
                staffRepo.Save(dsTam);

                HienThiLenBang();
                MessageBox.Show("Đã thêm nhân viên và lưu file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                txtMaNV.Enabled = false;
                btnLuu.Enabled = true;
                MessageBox.Show("Mời bạn chỉnh sửa thông tin phía bên trái, sau đó bấm 'Lưu'.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên từ bảng để sửa!", "Thông báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maSua = txtMaNV.Text.Trim();
                if (string.IsNullOrEmpty(maSua)) return;
                DateTime ngayVaoLamGoc = DateTime.Now;
                foreach (NhanVien nvOld in DataStorage.Instance.DanhSachNV)
                {
                    if (nvOld.Ma == maSua)
                    {
                        ngayVaoLamGoc = nvOld.NgayVaoLam;

                        break;
                    }
                }
                NhanVien nvUpdate = new NhanVien();
                nvUpdate.Ma = maSua;
                nvUpdate.HoTen = txtHoTen.Text;
                nvUpdate.SoDienThoai = txtSDT.Text;
                nvUpdate.ChucVu = txtChucVu.Text;
                nvUpdate.DiaChi = txtDiaChi.Text;
                nvUpdate.GioiTinh = (cboGioiTinh.Text == "Nam");
                nvUpdate.NgayVaoLam = ngayVaoLamGoc;
                nvUpdate.LuongCB = 5000000;
                bool thanhCong = serviceNhanSu.CapNhatThongTinNhanVien(maSua, nvUpdate);
                if (thanhCong)
                {
                    List<Nguoi> dsTam = new List<Nguoi>();
                    foreach (NhanVien item in DataStorage.Instance.DanhSachNV)
                    {
                        dsTam.Add(item);
                    }
                    staffRepo.Save(dsTam);
                    HienThiLenBang();
                    txtMaNV.Enabled = true;
                    btnLuu.Enabled = false;
                    MessageBox.Show("Đã lưu thay đổi vào file database_nhanvien.txt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            cboGioiTinh.SelectedIndex = 0;
            txtMaNV.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNV.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maXoa = txtMaNV.Text.Trim();

            if (string.IsNullOrEmpty(maXoa))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo");
                return;
            }
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maXoa} không?",
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                bool daXoaTrongRam = serviceNhanSu.XoaNhanVien(maXoa);

                if (daXoaTrongRam)
                {
                    List<Nguoi> dsTam = new List<Nguoi>();
                    foreach (NhanVien item in DataStorage.Instance.DanhSachNV)
                    {
                        dsTam.Add(item);
                    }
                    staffRepo.Save(dsTam);
                    HienThiLenBang();
                    btnReset_Click(sender, e);
                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên này trong hệ thống!", "Lỗi");
                }
            }
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Text= "";
        }   


        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim().ToLower();
            List<NhanVien> ketQuaTimKiem = new List<NhanVien>();
            foreach (NhanVien nv in DataStorage.Instance.DanhSachNV)
            {
                if (nv.Ma.ToLower().Contains(keyword) || nv.HoTen.ToLower().Contains(keyword))
                {
                    ketQuaTimKiem.Add(nv);
                }
            }
            dgvNhanVien.DataSource = ketQuaTimKiem;
        }
    }

}
