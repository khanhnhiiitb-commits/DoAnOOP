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
        lblTitle = new Label();
        lblUser = new Label();
        lblPass = new Label();
        txtUser = new TextBox();
        txtPass = new TextBox();
        btnLogin = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(34, 45);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(496, 41);
        lblTitle.TabIndex = 6;
        lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG SIÊU THỊ";
        // 
        // lblUser
        // 
        lblUser.Location = new Point(57, 133);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(114, 31);
        lblUser.TabIndex = 5;
        lblUser.Text = "Tên đăng nhập:";
        // 
        // lblPass
        // 
        lblPass.Location = new Point(57, 187);
        lblPass.Name = "lblPass";
        lblPass.Size = new Size(114, 31);
        lblPass.TabIndex = 3;
        lblPass.Text = "Mật khẩu:";
        // 
        // txtUser
        // 
        txtUser.BackColor = SystemColors.Menu;
        txtUser.Location = new Point(206, 129);
        txtUser.Margin = new Padding(3, 4, 3, 4);
        txtUser.Name = "txtUser";
        txtUser.Size = new Size(228, 27);
        txtUser.TabIndex = 4;
        // 
        // txtPass
        // 
        txtPass.BackColor = SystemColors.Menu;
        txtPass.Location = new Point(206, 183);
        txtPass.Margin = new Padding(3, 4, 3, 4);
        txtPass.Name = "txtPass";
        txtPass.PasswordChar = '*';
        txtPass.Size = new Size(228, 27);
        txtPass.TabIndex = 2;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(206, 240);
        btnLogin.Margin = new Padding(3, 4, 3, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(103, 47);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Đăng nhập";
        // 
        // btnExit
        // 
        btnExit.Location = new Point(331, 240);
        btnExit.Margin = new Padding(3, 4, 3, 4);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(103, 47);
        btnExit.TabIndex = 0;
        btnExit.Text = "Thoát";
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        ClientSize = new Size(561, 348);
        Controls.Add(btnExit);
        Controls.Add(btnLogin);
        Controls.Add(txtPass);
        Controls.Add(lblPass);
        Controls.Add(txtUser);
        Controls.Add(lblUser);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Load += FrmLogin_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}