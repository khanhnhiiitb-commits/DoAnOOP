using System;
using System.Windows.Forms;
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
            if (pnlContent != null)
            {
                pnlContent.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(uc);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // SỬA TẠI ĐÂY: Dùng DataStorage.Instance thay vì gọi trực tiếp
            NhanVien nv = DataStorage.Instance.NhanVienDangNhap;

            if (nv != null && nv.Taikhoan != null && nv.Taikhoan.UserRole != null)
            {
                string role = nv.Taikhoan.UserRole.MaRole;

                // Lưu ý: So sánh chuỗi nên dùng ToLower() để tránh sai sót chữ hoa/thường
                switch (role.ToLower())
                {
                    case "admin":
                        Navigation(new ucAdminPanel());
                        break;
                    case "cashier":
                        Navigation(new ucBanHangPanel());
                        break;
                    case "warehouse":
                        Navigation(new ucKhoPanel());
                        break;
                    default:
                        MessageBox.Show("Quyền truy cập không hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin đăng nhập!");
                // Có thể đóng Form để quay lại Login tại đây
            }

        }

    }
}