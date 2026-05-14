namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    partial class ucPhieuNhap
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
            panel1 = new Panel();
            txtSearchPN = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvPhieuNhap = new DataGridView();
            groupBox1 = new GroupBox();
            cboMaHang = new ComboBox();
            txtDonGiaNhap = new TextBox();
            txtSoLuongNhap = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnXoaPN = new Button();
            btnSuaPN = new Button();
            btnThemPN = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtNgayNhap = new DateTimePicker();
            cboTrangThai = new ComboBox();
            txtTongTien = new TextBox();
            txtNCC = new TextBox();
            txtMaPN = new TextBox();
            colMaPN = new DataGridViewTextBoxColumn();
            colNhaCungCap = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colMaHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGiaNhap = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchPN);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 113);
            panel1.TabIndex = 0;
            // 
            // txtSearchPN
            // 
            txtSearchPN.Location = new Point(28, 61);
            txtSearchPN.Name = "txtSearchPN";
            txtSearchPN.PlaceholderText = "Tìm mã phiếu...";
            txtSearchPN.Size = new Size(339, 27);
            txtSearchPN.TabIndex = 1;
            txtSearchPN.TextChanged += txtSearchPN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phiếu Nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPhieuNhap);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 487);
            panel2.TabIndex = 1;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BorderStyle = BorderStyle.None;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPN, colNhaCungCap, colNgayNhap, colTrangThai, colTongTien, colMaHang, colSoLuong, colDonGiaNhap });
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(367, 0);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(366, 487);
            dgvPhieuNhap.TabIndex = 4;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaHang);
            groupBox1.Controls.Add(txtDonGiaNhap);
            groupBox1.Controls.Add(txtSoLuongNhap);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnXoaPN);
            groupBox1.Controls.Add(btnSuaPN);
            groupBox1.Controls.Add(btnThemPN);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtNgayNhap);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(txtNCC);
            groupBox1.Controls.Add(txtMaPN);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 487);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(108, 137);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(151, 28);
            cboMaHang.TabIndex = 18;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(107, 226);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(125, 27);
            txtDonGiaNhap.TabIndex = 17;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(108, 182);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(125, 27);
            txtSoLuongNhap.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 233);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 15;
            label9.Text = "Đơn giá:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 189);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 14;
            label8.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 145);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 13;
            label7.Text = "Mã hàng:";
            // 
            // btnXoaPN
            // 
            btnXoaPN.BackColor = SystemColors.GradientInactiveCaption;
            btnXoaPN.FlatStyle = FlatStyle.Flat;
            btnXoaPN.Location = new Point(248, 417);
            btnXoaPN.Name = "btnXoaPN";
            btnXoaPN.Size = new Size(94, 48);
            btnXoaPN.TabIndex = 12;
            btnXoaPN.Text = "Xoá";
            btnXoaPN.UseVisualStyleBackColor = false;
            btnXoaPN.Click += btnXoaPN_Click;
            // 
            // btnSuaPN
            // 
            btnSuaPN.BackColor = SystemColors.GradientInactiveCaption;
            btnSuaPN.FlatStyle = FlatStyle.Flat;
            btnSuaPN.Location = new Point(138, 417);
            btnSuaPN.Name = "btnSuaPN";
            btnSuaPN.Size = new Size(94, 48);
            btnSuaPN.TabIndex = 11;
            btnSuaPN.Text = "Sửa";
            btnSuaPN.UseVisualStyleBackColor = false;
            btnSuaPN.Click += btnSuaPN_Click;
            // 
            // btnThemPN
            // 
            btnThemPN.BackColor = SystemColors.GradientInactiveCaption;
            btnThemPN.FlatStyle = FlatStyle.Flat;
            btnThemPN.Location = new Point(25, 417);
            btnThemPN.Name = "btnThemPN";
            btnThemPN.Size = new Size(94, 48);
            btnThemPN.TabIndex = 10;
            btnThemPN.Text = "Thêm";
            btnThemPN.UseVisualStyleBackColor = false;
            btnThemPN.Click += btnThemPN_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 371);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 280);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 324);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã phiếu nhập:";
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.Location = new Point(108, 273);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(250, 27);
            dtNgayNhap.TabIndex = 4;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(108, 316);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(142, 28);
            cboTrangThai.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(108, 364);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(142, 27);
            txtTongTien.TabIndex = 2;
            // 
            // txtNCC
            // 
            txtNCC.Location = new Point(132, 94);
            txtNCC.Name = "txtNCC";
            txtNCC.Size = new Size(151, 27);
            txtNCC.TabIndex = 1;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(132, 47);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(151, 27);
            txtMaPN.TabIndex = 0;
            // 
            // colMaPN
            // 
            colMaPN.HeaderText = "Mã PN";
            colMaPN.MinimumWidth = 6;
            colMaPN.Name = "colMaPN";
            // 
            // colNhaCungCap
            // 
            colNhaCungCap.HeaderText = "Nhà cung cấp";
            colNhaCungCap.MinimumWidth = 6;
            colNhaCungCap.Name = "colNhaCungCap";
            // 
            // colNgayNhap
            // 
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            // 
            // colMaHang
            // 
            colMaHang.HeaderText = "Mã hàng";
            colMaHang.MinimumWidth = 6;
            colMaHang.Name = "colMaHang";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "SL nhập";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colDonGiaNhap
            // 
            colDonGiaNhap.HeaderText = "Đơn giá nhập";
            colDonGiaNhap.MinimumWidth = 6;
            colDonGiaNhap.Name = "colDonGiaNhap";
            // 
            // ucPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucPhieuNhap";
            Size = new Size(733, 600);
            Load += ucPhieuNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearchPN;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private DateTimePicker dtNgayNhap;
        private ComboBox cboTrangThai;
        private TextBox txtTongTien;
        private TextBox txtNCC;
        private TextBox txtMaPN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThemPN;
        private Button btnXoaPN;
        private Button btnSuaPN;
        private DataGridView dgvPhieuNhap;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cboMaHang;
        private TextBox txtDonGiaNhap;
        private TextBox txtSoLuongNhap;
        private DataGridViewTextBoxColumn colMaPN;
        private DataGridViewTextBoxColumn colNhaCungCap;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colMaHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGiaNhap;
    }
}
