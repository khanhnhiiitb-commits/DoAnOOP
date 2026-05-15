using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongtrinhQuanlybanhangsieuthi.View;
using ChuongtrinhQuanlybanhangsieuthi.View.Admin;
using QuanLySieuThi.Data;
using QuanLySieuThi.Services;


namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class ucAdminPanel : UserControl
    {
        public ucAdminPanel()
        {
            InitializeComponent();
        }

        private void Navigation(UserControl uc)
        {
            if (pnlAdminContent != null)
            {
                pnlAdminContent.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                pnlAdminContent.Controls.Add(uc);
            }
        }

        private void ucAdminPanel_Load(object sender, EventArgs e)
        {

            if (DataStorage.Instance.NhanVienDangNhap != null)
            {

                label1.Text = "Xin chào, " + DataStorage.Instance.NhanVienDangNhap.HoTen + "!";
            }
            else
            {
                label1.Text = "Xin chào, Admin ẩn danh!";
            }
            HighlightActiveButton(btnTongQuan); 
            Navigation(new ucDashboard());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            Navigation(new ucManageStaff());
        }



        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            Navigation(new ucManageProduct());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            Navigation(new ucReports());
        }
        private void HighlightActiveButton(object sender)
        {
            Button clickedBtn = (Button)sender;
            Control parentContainer = clickedBtn.Parent;
            foreach (Control ctrl in parentContainer.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = SystemColors.ActiveCaption;
                }
            }
            clickedBtn.BackColor = SystemColors.Control;
        }
        private void pnlAdminContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            Navigation(new ucDashboard());
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(sender);
            Navigation(new ucKM());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
