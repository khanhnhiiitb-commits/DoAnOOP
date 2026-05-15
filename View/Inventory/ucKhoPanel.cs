using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongtrinhQuanlybanhangsieuthi.View.Inventory;
using QuanLySieuThi.Data;

namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class panelKho : UserControl
    {
        public panelKho()
        {
            InitializeComponent();
        }

        private void OpenUserControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(uc);

            uc.BringToFront();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucTonKho());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucPhieuNhap());
        }

        private void btnQuanLyKeHang_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucQuanLyKeHang());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucNhaCungCap());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {

                Application.Restart();
            }
        }

        private void panelKho_Load(object sender, EventArgs e)
        {
            if (DataStorage.Instance.NhanVienDangNhap != null)
            {

                label1.Text = "Xin chào, " + DataStorage.Instance.NhanVienDangNhap.HoTen + "!";
            }
            else
            {
                label1.Text = "Xin chào, Thủ kho ẩn danh!";
            }
        }
    }
}

