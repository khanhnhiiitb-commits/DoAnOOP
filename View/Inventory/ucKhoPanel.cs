using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChuongtrinhQuanlybanhangsieuthi.View.Inventory;
using QuanLySieuThi.Data;

namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class panelKho : UserControl
    {
        private ucTonKho manHinhTonKho;
        private ucPhieuNhap manHinhPhieuNhap;
        private ucQuanLyKeHang manHinhKeHang;
        private ucNhaCungCap manHinhNhaCungCap;

        public panelKho()
        {
            InitializeComponent();
            manHinhTonKho = new ucTonKho();
            manHinhPhieuNhap = new ucPhieuNhap();
            manHinhKeHang = new ucQuanLyKeHang();
            manHinhNhaCungCap = new ucNhaCungCap();
        }

        private void panelKho_Load(object sender, EventArgs e)
        {
            if (DataStorage.Instance.NhanVienDangNhap != null)
            {
                lblNhanVien.Text = "Xin chào, " + DataStorage.Instance.NhanVienDangNhap.HoTen + "!";
            }
            else
            {
                lblNhanVien.Text = "Xin chào, Thủ kho ẩn danh!";
            }
            HighlightActiveButton(btnTonKho);
            OpenUserControl(manHinhTonKho);
        }

        private void OpenUserControl(UserControl uc)
        {
            if (pnlContainer != null)
            {
                pnlContainer.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(uc);
                uc.BringToFront();
            }
        }

        // --- CÁC SỰ KIỆN CLICK (Dùng lại vùng nhớ có sẵn, KHÔNG DÙNG 'new') ---
        private void btnTonKho_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            OpenUserControl(manHinhTonKho);
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            OpenUserControl(manHinhPhieuNhap);
        }

        private void btnQuanLyKeHang_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            OpenUserControl(manHinhKeHang);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            OpenUserControl(manHinhNhaCungCap);
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

        private void HighlightActiveButton(object sender)
        {
            Button clickedBtn = (Button)sender;
            Control parentContainer = clickedBtn.Parent;
            foreach (Control ctrl in parentContainer.Controls)
            {
                if (ctrl is Button && ctrl.Name != "btnLogout") // Trừ nút đăng xuất
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = SystemColors.ActiveCaption;
                }
            }
            clickedBtn.BackColor = SystemColors.Control;
        }
    }
}