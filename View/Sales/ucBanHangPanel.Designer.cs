namespace ChuongtrinhQuanlybanhangsieuthi
{
    partial class ucBanHangPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTimKiem = new TextBox();
            btnDienTu = new Button();
            groupBox1 = new GroupBox();
            dgvSanPham = new DataGridView();
            btnThucPham = new Button();
            btnTatCa = new Button();
            groupBox2 = new GroupBox();
            dgvGioHang = new DataGridView();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThanhToan = new Button();
            txtTimKH = new TextBox();
            Giohang = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnLogout = new Button();
            label1 = new Label();
            btnDangKyThe = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = SystemColors.InactiveCaption;
            txtTimKiem.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(27, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(382, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.Text = "Quét mã vạch hoặc tìm tên hàng...";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnDienTu
            // 
            btnDienTu.BackColor = SystemColors.ButtonHighlight;
            btnDienTu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDienTu.ForeColor = SystemColors.ControlDarkDark;
            btnDienTu.Location = new Point(517, 23);
            btnDienTu.Name = "btnDienTu";
            btnDienTu.RightToLeft = RightToLeft.Yes;
            btnDienTu.Size = new Size(92, 44);
            btnDienTu.TabIndex = 2;
            btnDienTu.Text = "Điện tử";
            btnDienTu.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dgvSanPham);
            groupBox1.Controls.Add(btnThucPham);
            groupBox1.Controls.Add(btnTatCa);
            groupBox1.Controls.Add(btnDienTu);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 543);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(27, 73);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(708, 505);
            dgvSanPham.TabIndex = 10;
            // 
            // btnThucPham
            // 
            btnThucPham.BackColor = SystemColors.ButtonHighlight;
            btnThucPham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThucPham.ForeColor = SystemColors.ControlDarkDark;
            btnThucPham.Location = new Point(615, 23);
            btnThucPham.Name = "btnThucPham";
            btnThucPham.RightToLeft = RightToLeft.Yes;
            btnThucPham.Size = new Size(120, 44);
            btnThucPham.TabIndex = 9;
            btnThucPham.Text = "Thực phẩm";
            btnThucPham.UseVisualStyleBackColor = false;
            // 
            // btnTatCa
            // 
            btnTatCa.BackColor = SystemColors.ButtonHighlight;
            btnTatCa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTatCa.ForeColor = SystemColors.ControlDarkDark;
            btnTatCa.Location = new Point(415, 23);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.RightToLeft = RightToLeft.Yes;
            btnTatCa.Size = new Size(96, 44);
            btnTatCa.TabIndex = 8;
            btnTatCa.Text = "Tất cả";
            btnTatCa.UseVisualStyleBackColor = false;
            btnTatCa.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvGioHang);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(txtTimKH);
            groupBox2.Controls.Add(Giohang);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(768, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 543);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgvGioHang
            // 
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Location = new Point(17, 92);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.Size = new Size(569, 224);
            dgvGioHang.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnThanhToan);
            panel4.Location = new Point(17, 322);
            panel4.Name = "panel4";
            panel4.Size = new Size(569, 221);
            panel4.TabIndex = 10;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(18, 121);
            label4.Name = "label4";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 11;
            label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(18, 69);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 11;
            label3.Text = "Giảm giá/Voucher";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 10;
            label2.Text = "Tạm tính (1 sản phẩm)";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = SystemColors.ActiveCaption;
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.ForeColor = SystemColors.Control;
            btnThanhToan.Location = new Point(166, 149);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(272, 43);
            btnThanhToan.TabIndex = 8;
            btnThanhToan.Text = "THANH TOÁN VÀ IN BILL";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnLamMoi_Click;
            // 
            // txtTimKH
            // 
            txtTimKH.BackColor = SystemColors.InactiveCaption;
            txtTimKH.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKH.ForeColor = Color.Gray;
            txtTimKH.Location = new Point(17, 59);
            txtTimKH.Name = "txtTimKH";
            txtTimKH.Size = new Size(569, 27);
            txtTimKH.TabIndex = 6;
            txtTimKH.Text = "Nhập SĐT khách hàng...";
            // 
            // Giohang
            // 
            Giohang.BackColor = SystemColors.ButtonHighlight;
            Giohang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Giohang.ForeColor = SystemColors.Desktop;
            Giohang.Location = new Point(17, 23);
            Giohang.Name = "Giohang";
            Giohang.Size = new Size(569, 25);
            Giohang.TabIndex = 0;
            Giohang.Text = "Khách hàng";
            Giohang.Click += Giohang_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1266, 568);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 37);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(9, 576);
            label1.Name = "label1";
            label1.Size = new Size(317, 25);
            label1.TabIndex = 11;
            label1.Text = "nv";
            // 
            // btnDangKyThe
            // 
            btnDangKyThe.Location = new Point(1067, 568);
            btnDangKyThe.Name = "btnDangKyThe";
            btnDangKyThe.Size = new Size(180, 37);
            btnDangKyThe.TabIndex = 12;
            btnDangKyThe.Text = "Đăng ký Thẻ thành viên";
            btnDangKyThe.UseVisualStyleBackColor = true;
            btnDangKyThe.Click += btnDangKyThe_Click;
            // 
            // ucBanHangPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(btnDangKyThe);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ucBanHangPanel";
            Size = new Size(1378, 616);
            Load += ucBanHangPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTimKiem;
        private Button btnDienTu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label Giohang;
        private Button btnThanhToan;
        private TextBox txtTimKH;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnThucPham;
        private Button btnTatCa;
        private Panel panel4;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label3;
        private Label label4;
        private DataGridView dgvGioHang;
        private DataGridView dgvSanPham;
        private Button btnLogout;
        private Label label1;
        private Button btnDangKyThe;
    }
}
