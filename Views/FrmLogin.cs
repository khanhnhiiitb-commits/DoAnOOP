using System;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.People;

namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Đăng ký sự kiện Click cho nút Đăng nhập
            this.btnLogin.Click += new EventHandler(btnLogin_Click);

            // Đăng ký sự kiện Click cho nút Thoát
            this.btnExit.Click += new EventHandler(btnExit_Click);
        }

        // Hàm xử lý khi bấm nút Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            NhanVien foundNV = null;

            // THAY ĐỔI 1: Sử dụng DataStorage.Instance.DanhSachNV
            foreach (NhanVien nv in DataStorage.Instance.DanhSachNV)
            {
                // Kiểm tra đa tầng: nv tồn tại -> có taikhoan -> khớp user/pass
                if (nv != null && nv.Taikhoan != null &&
                    nv.Taikhoan.TenDangNhap == user &&
                    nv.Taikhoan.MatKhau == pass)
                {
                    foundNV = nv;
                    break;
                }
            }

            if (foundNV != null)
            {
                // Kiểm tra xem nhân viên này đã được gán Role chưa trước khi cho vào
                if (foundNV.Taikhoan.UserRole == null)
                {
                    MessageBox.Show("Tài khoản này chưa được phân quyền hệ thống!", "Cảnh báo");
                    return;
                }

                // THAY ĐỔI 2: Sử dụng DataStorage.Instance.NhanVienDangNhap
                DataStorage.Instance.NhanVienDangNhap = foundNV;

                MessageBox.Show($"Đăng nhập thành công! Chào {foundNV.HoTen}", "Thông báo");

                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi");
            }
        }

        // Hàm xử lý khi người dùng nhấn nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}