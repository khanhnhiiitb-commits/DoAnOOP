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
            label10 = new Label();
            txtSearchPN = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvChiTietPhieuNhap = new DataGridView();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dgvPhieuNhap = new DataGridView();
            colMaPN = new DataGridViewTextBoxColumn();
            colNhaCungCap = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
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
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtSearchPN);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 113);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(921, 82);
            label10.Name = "label10";
            label10.Size = new Size(201, 28);
            label10.TabIndex = 2;
            label10.Text = "Chi Tiết Phiếu Nhập";
            // 
            // txtSearchPN
            // 
            txtSearchPN.Location = new Point(11, 41);
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
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phiếu Nhập";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvChiTietPhieuNhap);
            panel2.Controls.Add(dgvPhieuNhap);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 563);
            panel2.TabIndex = 1;
            // 
            // dgvChiTietPhieuNhap
            // 
            dgvChiTietPhieuNhap.AllowUserToAddRows = false;
            dgvChiTietPhieuNhap.BorderStyle = BorderStyle.None;
            dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16 });
            dgvChiTietPhieuNhap.Location = new Point(868, 0);
            dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            dgvChiTietPhieuNhap.RowHeadersVisible = false;
            dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            dgvChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieuNhap.Size = new Size(336, 487);
            dgvChiTietPhieuNhap.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Mã hàng";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 110;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "SL nhập";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 111;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Đơn giá nhập";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 110;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.BorderStyle = BorderStyle.None;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPN, colNhaCungCap, colNgayNhap, colTrangThai, colTongTien });
            dgvPhieuNhap.Location = new Point(316, 3);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(546, 487);
            dgvPhieuNhap.TabIndex = 4;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // colMaPN
            // 
            colMaPN.HeaderText = "Mã PN";
            colMaPN.MinimumWidth = 6;
            colMaPN.Name = "colMaPN";
            colMaPN.Width = 109;
            // 
            // colNhaCungCap
            // 
            colNhaCungCap.HeaderText = "Nhà cung cấp";
            colNhaCungCap.MinimumWidth = 6;
            colNhaCungCap.Name = "colNhaCungCap";
            colNhaCungCap.Width = 110;
            // 
            // colNgayNhap
            // 
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.Width = 109;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.Width = 104;
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            colTongTien.Width = 110;
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
            groupBox1.Size = new Size(367, 563);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(97, 137);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(151, 28);
            cboMaHang.TabIndex = 18;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(96, 226);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(125, 27);
            txtDonGiaNhap.TabIndex = 17;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(97, 182);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(125, 27);
            txtSoLuongNhap.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 233);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 15;
            label9.Text = "Đơn giá:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 189);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 14;
            label8.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 145);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 13;
            label7.Text = "Mã hàng:";
            // 
            // btnXoaPN
            // 
            btnXoaPN.BackColor = SystemColors.GradientInactiveCaption;
            btnXoaPN.FlatStyle = FlatStyle.Flat;
            btnXoaPN.Location = new Point(216, 417);
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
            btnSuaPN.Location = new Point(116, 417);
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
            btnThemPN.Location = new Point(17, 417);
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
            label6.Location = new Point(0, 371);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 280);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 324);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 101);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 54);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã phiếu nhập:";
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.Location = new Point(97, 273);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(213, 27);
            dtNgayNhap.TabIndex = 4;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(97, 316);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(142, 28);
            cboTrangThai.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(97, 364);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(142, 27);
            txtTongTien.TabIndex = 2;
            // 
            // txtNCC
            // 
            txtNCC.Location = new Point(121, 94);
            txtNCC.Name = "txtNCC";
            txtNCC.Size = new Size(151, 27);
            txtNCC.TabIndex = 1;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(121, 47);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(151, 27);
            txtMaPN.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(327, 85);
            label11.Name = "label11";
            label11.Size = new Size(226, 28);
            label11.TabIndex = 3;
            label11.Text = "Danh sách Phiếu Nhập";
            // 
            // ucPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucPhieuNhap";
            Size = new Size(1199, 676);
            Load += ucPhieuNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).EndInit();
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
        private DataGridView dgvChiTietPhieuNhap;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn colMaPN;
        private DataGridViewTextBoxColumn colNhaCungCap;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTongTien;
        private Label label10;
        private Label label11;
    }
}
