namespace ChuongtrinhQuanlybanhangsieuthi;

partial class FrmLogin
{
    private System.ComponentModel.IContainer components = null;

    // Khai báo các thành phần giao diện
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.Label lblPass;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.TextBox txtPass;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnExit;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblUser = new System.Windows.Forms.Label();
        this.lblPass = new System.Windows.Forms.Label();
        this.txtUser = new System.Windows.Forms.TextBox();
        this.txtPass = new System.Windows.Forms.TextBox();
        this.btnLogin = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(100, 30);
        this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";

        // lblUser (Nhãn Tên đăng nhập)
        this.lblUser.Location = new System.Drawing.Point(50, 100);
        this.lblUser.Text = "Tên đăng nhập:";

        // txtUser (Ô nhập User)
        this.txtUser.Location = new System.Drawing.Point(180, 97);
        this.txtUser.Size = new System.Drawing.Size(200, 23);
        this.txtUser.Name = "txtUser";

        // lblPass (Nhãn Mật khẩu)
        this.lblPass.Location = new System.Drawing.Point(50, 140);
        this.lblPass.Text = "Mật khẩu:";

        // txtPass (Ô nhập Pass)
        this.txtPass.Location = new System.Drawing.Point(180, 137);
        this.txtPass.Size = new System.Drawing.Size(200, 23);
        this.txtPass.PasswordChar = '*'; // Hiện dấu sao để bảo mật
        this.txtPass.Name = "txtPass";

        // btnLogin
        this.btnLogin.Location = new System.Drawing.Point(180, 180);
        this.btnLogin.Size = new System.Drawing.Size(90, 35);
        this.btnLogin.Text = "Đăng nhập";
        this.btnLogin.Name = "btnLogin";

        // btnExit
        this.btnExit.Location = new System.Drawing.Point(290, 180);
        this.btnExit.Size = new System.Drawing.Size(90, 35);
        this.btnExit.Text = "Thoát";
        this.btnExit.Name = "btnExit";

        // FrmLogin (Cài đặt chung cho Form)
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 260);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.txtPass);
        this.Controls.Add(this.lblPass);
        this.Controls.Add(this.txtUser);
        this.Controls.Add(this.lblUser);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Đăng nhập - Siêu thị Nhi";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}