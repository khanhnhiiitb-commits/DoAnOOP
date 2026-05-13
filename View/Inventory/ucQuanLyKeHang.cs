using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucQuanLyKeHang : UserControl
    {
        private KeHangRepository repo;

        private List<KeHang> dsKeHang;
        public ucQuanLyKeHang()
        {
            InitializeComponent();

            repo =
        new KeHangRepository();

            dsKeHang =
                new List<KeHang>();
        }

        private void ucQuanLyKeHang_Load(object sender, EventArgs e)
        {

            dsKeHang = repo.GetAll();

            cboKhuVuc.Items.Add("Khu A");
            cboKhuVuc.Items.Add("Khu B");
            cboKhuVuc.Items.Add("Khu C");

            cboLoaiHang.Items.Add("Điện tử");
            cboLoaiHang.Items.Add("Thực phẩm");
            cboLoaiHang.Items.Add("Gia dụng");

            cboTrangThai.Items.Add("Còn trống");
            cboTrangThai.Items.Add("Đang sử dụng");

            HienThiDanhSach();

        }
        private void HienThiDanhSach()
        {
            dgvKeHang.Rows.Clear();

            foreach (KeHang ke in dsKeHang)
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
            KeHang ke =
       new KeHang();

            ke.MaKe =
                txtMaKe.Text.Trim();

            ke.ViTri =
                cboKhuVuc.Text;

            ke.LoaiHang =
                cboLoaiHang.Text;

            ke.SucChua =
                int.Parse(txtSucChua.Text);

            ke.TrangThai =
                cboTrangThai.Text;

            dsKeHang.Add(ke);

            repo.Save(dsKeHang);

            HienThiDanhSach();

            MessageBox.Show(
                "Thêm kệ hàng thành công!"
            );
        }

        private void btnXoaKeHang_Click(object sender, EventArgs e)
        {
            if (dgvKeHang.CurrentRow == null)
            {
                return;
            }

            int index =
                dgvKeHang.CurrentRow.Index;

            dsKeHang.RemoveAt(index);

            repo.Save(dsKeHang);

            HienThiDanhSach();

            MessageBox.Show(
                "Xóa thành công!"
            );
        }

        private void btnSuaKeHang_Click(object sender, EventArgs e)
        {
            if (dgvKeHang.CurrentRow == null)
            {
                return;
            }

            int index =
                dgvKeHang.CurrentRow.Index;

            dsKeHang[index].MaKe =
                txtMaKe.Text.Trim();

            dsKeHang[index].ViTri =
                cboKhuVuc.Text;

            dsKeHang[index].LoaiHang =
                cboLoaiHang.Text;

            dsKeHang[index].SucChua =
                int.Parse(txtSucChua.Text);

            dsKeHang[index].TrangThai =
                cboTrangThai.Text;

            repo.Save(dsKeHang);

            HienThiDanhSach();

            MessageBox.Show(
                "Sửa thành công!"
            );
        }

        private void dgvKeHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaKe.Text =
                dgvKeHang.Rows[e.RowIndex]
                .Cells[0].Value.ToString();

            cboKhuVuc.Text =
                dgvKeHang.Rows[e.RowIndex]
                .Cells[1].Value.ToString();

            cboLoaiHang.Text =
                dgvKeHang.Rows[e.RowIndex]
                .Cells[2].Value.ToString();

            txtSucChua.Text =
                dgvKeHang.Rows[e.RowIndex]
                .Cells[3].Value.ToString();

            cboTrangThai.Text =
                dgvKeHang.Rows[e.RowIndex]
                .Cells[4].Value.ToString();
        }

        private void txtSearchKeHang_TextChanged(object sender, EventArgs e)
        {
            string keyword =
       txtSearchKeHang.Text.Trim().ToLower();

            dgvKeHang.Rows.Clear();

            foreach (KeHang ke in dsKeHang)
            {
                if (
                    ke.MaKe.ToLower()
                    .Contains(keyword)
                )
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
