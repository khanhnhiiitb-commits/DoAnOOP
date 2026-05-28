namespace ChuongtrinhQuanlybanhangsieuthi
{
    partial class panelKho
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlUser = new Panel();
            btnLogout = new Button();
            lblNhanVien = new Label();
            btnNhaCungCap = new Button();
            btnQuanLyKeHang = new Button();
            btnPhieuNhap = new Button();
            btnTonKho = new Button();
            label1 = new Label();
            pnlContainer = new Panel();
            pnlMenu.SuspendLayout();
            pnlUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.ActiveCaption;
            pnlMenu.Controls.Add(pnlUser);
            pnlMenu.Controls.Add(lblNhanVien);
            pnlMenu.Controls.Add(btnNhaCungCap);
            pnlMenu.Controls.Add(btnQuanLyKeHang);
            pnlMenu.Controls.Add(btnPhieuNhap);
            pnlMenu.Controls.Add(btnTonKho);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(267, 600);
            pnlMenu.TabIndex = 0;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(btnLogout);
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.Location = new Point(0, 539);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(267, 61);
            pnlUser.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(16, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 37);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(3, 506);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(83, 20);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "NV Kho: ...";
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = SystemColors.ActiveCaption;
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhaCungCap.Image = Properties.Resources.partner_exchange_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(0, 237);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(267, 49);
            btnNhaCungCap.TabIndex = 4;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnQuanLyKeHang
            // 
            btnQuanLyKeHang.BackColor = SystemColors.ActiveCaption;
            btnQuanLyKeHang.FlatAppearance.BorderSize = 0;
            btnQuanLyKeHang.FlatStyle = FlatStyle.Flat;
            btnQuanLyKeHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLyKeHang.Image = Properties.Resources.shelves_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            btnQuanLyKeHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyKeHang.Location = new Point(0, 184);
            btnQuanLyKeHang.Name = "btnQuanLyKeHang";
            btnQuanLyKeHang.Size = new Size(267, 47);
            btnQuanLyKeHang.TabIndex = 3;
            btnQuanLyKeHang.Text = "Quản lý kệ hàng";
            btnQuanLyKeHang.UseVisualStyleBackColor = false;
            btnQuanLyKeHang.Click += btnQuanLyKeHang_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = SystemColors.ActiveCaption;
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhieuNhap.Image = Properties.Resources.order_approve_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40;
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(0, 131);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Size = new Size(267, 47);
            btnPhieuNhap.TabIndex = 2;
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // btnTonKho
            // 
            btnTonKho.BackColor = SystemColors.ActiveCaption;
            btnTonKho.FlatAppearance.BorderSize = 0;
            btnTonKho.FlatStyle = FlatStyle.Flat;
            btnTonKho.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTonKho.ForeColor = SystemColors.ActiveCaptionText;
            btnTonKho.Image = Properties.Resources.inventory_2_32dp_FFFFFF_FILL0_wght400_GRAD0_opsz40__1_;
            btnTonKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnTonKho.Location = new Point(0, 78);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Size = new Size(267, 47);
            btnTonKho.TabIndex = 1;
            btnTonKho.Text = "Tồn kho";
            btnTonKho.UseVisualStyleBackColor = false;
            btnTonKho.Click += btnTonKho_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(47, 18);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(267, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(733, 600);
            pnlContainer.TabIndex = 1;
            // 
            // panelKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Controls.Add(pnlMenu);
            Name = "panelKho";
            Size = new Size(1000, 600);
            Load += panelKho_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlUser.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel pnlMenu;
        private Label label1;
        private Button btnNhaCungCap;
        private Button btnQuanLyKeHang;
        private Button btnPhieuNhap;
        private Button btnTonKho;
        private Panel pnlUser;
        private Label lblNhanVien;
        private Panel pnlContainer;
        private Button btnLogout;
    }
}
#region Component Designer generated code

/// <summary> 
/// Required method for Designer support - do not modify 
/// the contents of this method with the code editor.
/// </summary>

           

        #endregion
    

