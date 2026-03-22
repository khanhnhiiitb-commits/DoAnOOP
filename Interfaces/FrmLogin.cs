namespace ChuongtrinhQuanlybanhangsieuthi;

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
        if (txtUser.Text == "admin" && txtPass.Text == "123")
        {
            MessageBox.Show("Đăng nhập thành công!", "Thông báo");
        }
        else
        {
            MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
        }
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}