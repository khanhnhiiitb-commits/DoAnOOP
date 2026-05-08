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
            colMaPN = new DataGridViewTextBoxColumn();
            colNhaCungCap = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colNguoiNhap = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnLamMoiPN = new Button();
            btnXoaPN = new Button();
            btnSuaPN = new Button();
            btnThemPN = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtNgayNhap = new DateTimePicker();
            cboNhaCungCap = new ComboBox();
            txtTongTien = new TextBox();
            txtNguoiNhap = new TextBox();
            txtMaPN = new TextBox();
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
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPN, colNhaCungCap, colNgayNhap, colNguoiNhap, colTongTien });
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(367, 0);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(366, 487);
            dgvPhieuNhap.TabIndex = 4;
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
            // colNguoiNhap
            // 
            colNguoiNhap.HeaderText = "Người nhập";
            colNguoiNhap.MinimumWidth = 6;
            colNguoiNhap.Name = "colNguoiNhap";
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoiPN);
            groupBox1.Controls.Add(btnXoaPN);
            groupBox1.Controls.Add(btnSuaPN);
            groupBox1.Controls.Add(btnThemPN);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtNgayNhap);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(txtNguoiNhap);
            groupBox1.Controls.Add(txtMaPN);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 487);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnLamMoiPN
            // 
            btnLamMoiPN.BackColor = SystemColors.GradientInactiveCaption;
            btnLamMoiPN.FlatStyle = FlatStyle.Flat;
            btnLamMoiPN.Location = new Point(202, 399);
            btnLamMoiPN.Name = "btnLamMoiPN";
            btnLamMoiPN.Size = new Size(94, 48);
            btnLamMoiPN.TabIndex = 13;
            btnLamMoiPN.Text = "Làm mới";
            btnLamMoiPN.UseVisualStyleBackColor = false;
            // 
            // btnXoaPN
            // 
            btnXoaPN.BackColor = SystemColors.GradientInactiveCaption;
            btnXoaPN.FlatStyle = FlatStyle.Flat;
            btnXoaPN.Location = new Point(202, 317);
            btnXoaPN.Name = "btnXoaPN";
            btnXoaPN.Size = new Size(94, 48);
            btnXoaPN.TabIndex = 12;
            btnXoaPN.Text = "Xoá";
            btnXoaPN.UseVisualStyleBackColor = false;
            // 
            // btnSuaPN
            // 
            btnSuaPN.BackColor = SystemColors.GradientInactiveCaption;
            btnSuaPN.FlatStyle = FlatStyle.Flat;
            btnSuaPN.Location = new Point(59, 399);
            btnSuaPN.Name = "btnSuaPN";
            btnSuaPN.Size = new Size(94, 48);
            btnSuaPN.TabIndex = 11;
            btnSuaPN.Text = "Sửa";
            btnSuaPN.UseVisualStyleBackColor = false;
            // 
            // btnThemPN
            // 
            btnThemPN.BackColor = SystemColors.GradientInactiveCaption;
            btnThemPN.FlatStyle = FlatStyle.Flat;
            btnThemPN.Location = new Point(59, 317);
            btnThemPN.Name = "btnThemPN";
            btnThemPN.Size = new Size(94, 48);
            btnThemPN.TabIndex = 10;
            btnThemPN.Text = "Thêm";
            btnThemPN.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 271);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 163);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 216);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 7;
            label4.Text = "Người nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 110);
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
            dtNgayNhap.Location = new Point(106, 156);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(250, 27);
            dtNgayNhap.TabIndex = 4;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(132, 102);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(151, 28);
            cboNhaCungCap.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(113, 264);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(142, 27);
            txtTongTien.TabIndex = 2;
            // 
            // txtNguoiNhap
            // 
            txtNguoiNhap.Location = new Point(113, 209);
            txtNguoiNhap.Name = "txtNguoiNhap";
            txtNguoiNhap.Size = new Size(142, 27);
            txtNguoiNhap.TabIndex = 1;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(132, 47);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(151, 27);
            txtMaPN.TabIndex = 0;
            // 
            // ucPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucPhieuNhap";
            Size = new Size(733, 600);
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
        private ComboBox cboNhaCungCap;
        private TextBox txtTongTien;
        private TextBox txtNguoiNhap;
        private TextBox txtMaPN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThemPN;
        private Button btnLamMoiPN;
        private Button btnXoaPN;
        private Button btnSuaPN;
        private DataGridView dgvPhieuNhap;
        private DataGridViewTextBoxColumn colMaPN;
        private DataGridViewTextBoxColumn colNhaCungCap;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colNguoiNhap;
        private DataGridViewTextBoxColumn colTongTien;
    }
}
