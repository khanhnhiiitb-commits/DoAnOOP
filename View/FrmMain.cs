using System;
using System.Windows.Forms;
using QuanLySieuThi.Data; 
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.People;

namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void Navigation(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            NhanVien nv = DataStorage.NhanVienDangNhap;

            if (nv != null && nv.Taikhoan != null)
            {
                string role = nv.Taikhoan.UserRole.MaRole;

                // Phân quyền điều hướng ban đầu
                if (role == "admin")
                {
                    Navigation(new ucAdminPanel());
                }
                else if (role == "cashier")
                {
                    Navigation(new ucBanHangPanel());
                }
                else if (role == "warehouse")
                {
                    Navigation(new ucKhoPanel());
                }
            }
        }
    }
}