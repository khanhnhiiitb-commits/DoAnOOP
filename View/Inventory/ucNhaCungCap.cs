using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Sales;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucNhaCungCap : UserControl
    {
        private PartnerRepository repo;

        private List<NhaCungCap> dsNCC;
        public ucNhaCungCap()
        {
            InitializeComponent();

            repo =
                new PartnerRepository();

            dsNCC =
                new List<NhaCungCap>();
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            dsNCC = repo.GetAll();

            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            dgvNCC.Rows.Clear();

            foreach (NhaCungCap ncc in dsNCC)
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
            NhaCungCap ncc =
       new NhaCungCap();

            ncc.MaNCC =
                txtMaNCC.Text.Trim();

            ncc.TenNCC =
                txtTenNCC.Text.Trim();

            ncc.DiaChi =
                txtDiaChi.Text.Trim();

            ncc.SoDienThoai =
                txtSDT.Text.Trim();

            ncc.Email =
                txtEmail.Text.Trim();

            dsNCC.Add(ncc);

            repo.Save(dsNCC);

            HienThiDanhSach();

            MessageBox.Show(
                "Thêm nhà cung cấp thành công!"
            );
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow == null)
            {
                return;
            }

            int index =
                dgvNCC.CurrentRow.Index;

            dsNCC.RemoveAt(index);

            repo.Save(dsNCC);

            HienThiDanhSach();

            MessageBox.Show(
                "Xóa thành công!"
            );
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow == null)
            {
                return;
            }

            int index =
                dgvNCC.CurrentRow.Index;

            dsNCC[index].MaNCC =
                txtMaNCC.Text.Trim();

            dsNCC[index].TenNCC =
                txtTenNCC.Text.Trim();

            dsNCC[index].DiaChi =
                txtDiaChi.Text.Trim();

            dsNCC[index].SoDienThoai =
                txtSDT.Text.Trim();

            dsNCC[index].Email =
                txtEmail.Text.Trim();

            repo.Save(dsNCC);

            HienThiDanhSach();

            MessageBox.Show(
                "Sửa thành công!"
            );
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaNCC.Text =
                dgvNCC.Rows[e.RowIndex]
                .Cells[0].Value.ToString();

            txtTenNCC.Text =
                dgvNCC.Rows[e.RowIndex]
                .Cells[1].Value.ToString();

            txtDiaChi.Text =
                dgvNCC.Rows[e.RowIndex]
                .Cells[2].Value.ToString();

            txtSDT.Text =
                dgvNCC.Rows[e.RowIndex]
                .Cells[3].Value.ToString();

            txtEmail.Text =
                dgvNCC.Rows[e.RowIndex]
                .Cells[4].Value.ToString();
        }

        private void txtSearchNCC_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchNCC.Text.Trim().ToLower();

            dgvNCC.Rows.Clear();

            foreach (NhaCungCap ncc in dsNCC)
            {
                if (
                    ncc.MaNCC.ToLower()
                    .Contains(keyword)
                    ||
                    ncc.TenNCC.ToLower()
                    .Contains(keyword)
                )
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
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
