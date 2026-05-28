namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    partial class ucNhaCungCap
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
            txtSearchNCC = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenNCC = new TextBox();
            btnXoaNCC = new Button();
            btnSuaNCC = new Button();
            btnThemNCC = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtMaNCC = new TextBox();
            dgvNCC = new DataGridView();
            colMaNCC = new DataGridViewTextBoxColumn();
            colTenNCC = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchNCC);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 113);
            panel1.TabIndex = 3;
            // 
            // txtSearchNCC
            // 
            txtSearchNCC.Location = new Point(28, 61);
            txtSearchNCC.Name = "txtSearchNCC";
            txtSearchNCC.PlaceholderText = "Tìm mã NCC...";
            txtSearchNCC.Size = new Size(339, 27);
            txtSearchNCC.TabIndex = 2;
            txtSearchNCC.TextChanged += txtSearchNCC_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(btnXoaNCC);
            groupBox1.Controls.Add(btnSuaNCC);
            groupBox1.Controls.Add(btnThemNCC);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 487);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(80, 166);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(146, 27);
            txtDiaChi.TabIndex = 20;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(80, 216);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(146, 27);
            txtSDT.TabIndex = 19;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(92, 107);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(151, 27);
            txtTenNCC.TabIndex = 18;
            // 
            // btnXoaNCC
            // 
            btnXoaNCC.BackColor = SystemColors.GradientInactiveCaption;
            btnXoaNCC.FlatStyle = FlatStyle.Flat;
            btnXoaNCC.Location = new Point(202, 317);
            btnXoaNCC.Name = "btnXoaNCC";
            btnXoaNCC.Size = new Size(94, 48);
            btnXoaNCC.TabIndex = 16;
            btnXoaNCC.Text = "Xoá";
            btnXoaNCC.UseVisualStyleBackColor = false;
            btnXoaNCC.Click += btnXoaNCC_Click;
            // 
            // btnSuaNCC
            // 
            btnSuaNCC.BackColor = SystemColors.GradientInactiveCaption;
            btnSuaNCC.FlatStyle = FlatStyle.Flat;
            btnSuaNCC.Location = new Point(132, 400);
            btnSuaNCC.Name = "btnSuaNCC";
            btnSuaNCC.Size = new Size(94, 48);
            btnSuaNCC.TabIndex = 15;
            btnSuaNCC.Text = "Sửa";
            btnSuaNCC.UseVisualStyleBackColor = false;
            btnSuaNCC.Click += btnSuaNCC_Click;
            // 
            // btnThemNCC
            // 
            btnThemNCC.BackColor = SystemColors.GradientInactiveCaption;
            btnThemNCC.FlatStyle = FlatStyle.Flat;
            btnThemNCC.Location = new Point(59, 317);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Size = new Size(94, 48);
            btnThemNCC.TabIndex = 14;
            btnThemNCC.Text = "Thêm";
            btnThemNCC.UseVisualStyleBackColor = false;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 169);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 272);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 223);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "SĐT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên NCC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã NCC:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(146, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(92, 47);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(151, 27);
            txtMaNCC.TabIndex = 0;
            // 
            // dgvNCC
            // 
            dgvNCC.AllowUserToAddRows = false;
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.BorderStyle = BorderStyle.None;
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNCC.Columns.AddRange(new DataGridViewColumn[] { colMaNCC, colTenNCC, colDiaChi, colSDT, colEmail });
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.Location = new Point(367, 113);
            dgvNCC.Name = "dgvNCC";
            dgvNCC.RowHeadersVisible = false;
            dgvNCC.RowHeadersWidth = 51;
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNCC.Size = new Size(366, 487);
            dgvNCC.TabIndex = 5;
            dgvNCC.CellClick += dgvNCC_CellClick;
            // 
            // colMaNCC
            // 
            colMaNCC.HeaderText = "Mã NCC";
            colMaNCC.MinimumWidth = 6;
            colMaNCC.Name = "colMaNCC";
            // 
            // colTenNCC
            // 
            colTenNCC.HeaderText = "Tên NCC";
            colTenNCC.MinimumWidth = 6;
            colTenNCC.Name = "colTenNCC";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colSDT
            // 
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // ucNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvNCC);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ucNhaCungCap";
            Size = new Size(733, 600);
            Load += ucNhaCungCap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearchNCC;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnXoaNCC;
        private Button btnSuaNCC;
        private Button btnThemNCC;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboTrangThai;
        private ComboBox cboLoaiHang;
        private ComboBox cboKhuVuc;
        private TextBox txtEmail;
        private TextBox txtMaNCC;
        private TextBox txtSDT;
        private TextBox txtTenNCC;
        private DataGridView dgvNCC;
        private TextBox txtDiaChi;
        private DataGridViewTextBoxColumn colMaNCC;
        private DataGridViewTextBoxColumn colTenNCC;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colEmail;
    }
}
