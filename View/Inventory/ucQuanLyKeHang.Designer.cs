namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    partial class ucQuanLyKeHang
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
            label1 = new Label();
            panel1 = new Panel();
            txtSearchKeHang = new TextBox();
            groupBox1 = new GroupBox();
            btnXoaKeHang = new Button();
            btnSuaKeHang = new Button();
            btnThemKeHang = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboTrangThai = new ComboBox();
            cboLoaiHang = new ComboBox();
            cboKhuVuc = new ComboBox();
            txtSucChua = new TextBox();
            txtMaKe = new TextBox();
            dgvKeHang = new DataGridView();
            colMaKe = new DataGridViewTextBoxColumn();
            colKhuVuc = new DataGridViewTextBoxColumn();
            colLoaiHang = new DataGridViewTextBoxColumn();
            colSucChua = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Kệ Hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchKeHang);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 113);
            panel1.TabIndex = 2;
            // 
            // txtSearchKeHang
            // 
            txtSearchKeHang.Location = new Point(28, 61);
            txtSearchKeHang.Name = "txtSearchKeHang";
            txtSearchKeHang.PlaceholderText = "Tìm mã kệ...";
            txtSearchKeHang.Size = new Size(339, 27);
            txtSearchKeHang.TabIndex = 2;
            txtSearchKeHang.TextChanged += txtSearchKeHang_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaKeHang);
            groupBox1.Controls.Add(btnSuaKeHang);
            groupBox1.Controls.Add(btnThemKeHang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(cboLoaiHang);
            groupBox1.Controls.Add(cboKhuVuc);
            groupBox1.Controls.Add(txtSucChua);
            groupBox1.Controls.Add(txtMaKe);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 487);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin kệ hàng";
            // 
            // btnXoaKeHang
            // 
            btnXoaKeHang.BackColor = SystemColors.GradientInactiveCaption;
            btnXoaKeHang.FlatStyle = FlatStyle.Flat;
            btnXoaKeHang.Location = new Point(202, 317);
            btnXoaKeHang.Name = "btnXoaKeHang";
            btnXoaKeHang.Size = new Size(94, 48);
            btnXoaKeHang.TabIndex = 16;
            btnXoaKeHang.Text = "Xoá";
            btnXoaKeHang.UseVisualStyleBackColor = false;
            btnXoaKeHang.Click += btnXoaKeHang_Click;
            // 
            // btnSuaKeHang
            // 
            btnSuaKeHang.BackColor = SystemColors.GradientInactiveCaption;
            btnSuaKeHang.FlatStyle = FlatStyle.Flat;
            btnSuaKeHang.Location = new Point(132, 400);
            btnSuaKeHang.Name = "btnSuaKeHang";
            btnSuaKeHang.Size = new Size(94, 48);
            btnSuaKeHang.TabIndex = 15;
            btnSuaKeHang.Text = "Sửa";
            btnSuaKeHang.UseVisualStyleBackColor = false;
            btnSuaKeHang.Click += btnSuaKeHang_Click;
            // 
            // btnThemKeHang
            // 
            btnThemKeHang.BackColor = SystemColors.GradientInactiveCaption;
            btnThemKeHang.FlatStyle = FlatStyle.Flat;
            btnThemKeHang.Location = new Point(59, 317);
            btnThemKeHang.Name = "btnThemKeHang";
            btnThemKeHang.Size = new Size(94, 48);
            btnThemKeHang.TabIndex = 14;
            btnThemKeHang.Text = "Thêm";
            btnThemKeHang.UseVisualStyleBackColor = false;
            btnThemKeHang.Click += btnThemKeHang_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 271);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 9;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 216);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Sức chứa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 163);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Loại hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 110);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Khu vực:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã kệ:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(106, 263);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 4;
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.FormattingEnabled = true;
            cboLoaiHang.Location = new Point(106, 155);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(151, 28);
            cboLoaiHang.TabIndex = 3;
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(92, 102);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(151, 28);
            cboKhuVuc.TabIndex = 2;
            // 
            // txtSucChua
            // 
            txtSucChua.Location = new Point(106, 209);
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Size = new Size(151, 27);
            txtSucChua.TabIndex = 1;
            // 
            // txtMaKe
            // 
            txtMaKe.Location = new Point(92, 47);
            txtMaKe.Name = "txtMaKe";
            txtMaKe.Size = new Size(151, 27);
            txtMaKe.TabIndex = 0;
            // 
            // dgvKeHang
            // 
            dgvKeHang.AllowUserToAddRows = false;
            dgvKeHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeHang.BorderStyle = BorderStyle.None;
            dgvKeHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeHang.Columns.AddRange(new DataGridViewColumn[] { colMaKe, colKhuVuc, colLoaiHang, colSucChua, colTrangThai });
            dgvKeHang.Dock = DockStyle.Fill;
            dgvKeHang.Location = new Point(367, 113);
            dgvKeHang.Name = "dgvKeHang";
            dgvKeHang.RowHeadersVisible = false;
            dgvKeHang.RowHeadersWidth = 51;
            dgvKeHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeHang.Size = new Size(366, 487);
            dgvKeHang.TabIndex = 4;
            dgvKeHang.CellClick += dgvKeHang_CellClick;
            dgvKeHang.CellContentClick += dgvKeHang_CellContentClick;
            // 
            // colMaKe
            // 
            colMaKe.HeaderText = "Mã kệ";
            colMaKe.MinimumWidth = 6;
            colMaKe.Name = "colMaKe";
            // 
            // colKhuVuc
            // 
            colKhuVuc.HeaderText = "Khu vực";
            colKhuVuc.MinimumWidth = 6;
            colKhuVuc.Name = "colKhuVuc";
            // 
            // colLoaiHang
            // 
            colLoaiHang.HeaderText = "Loại hàng";
            colLoaiHang.MinimumWidth = 6;
            colLoaiHang.Name = "colLoaiHang";
            // 
            // colSucChua
            // 
            colSucChua.HeaderText = "Sức chứa";
            colSucChua.MinimumWidth = 6;
            colSucChua.Name = "colSucChua";
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // ucQuanLyKeHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvKeHang);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ucQuanLyKeHang";
            Size = new Size(733, 600);
            Load += ucQuanLyKeHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cboTrangThai;
        private ComboBox cboLoaiHang;
        private ComboBox cboKhuVuc;
        private TextBox txtSucChua;
        private TextBox txtMaKe;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXoaKeHang;
        private Button btnSuaKeHang;
        private Button btnThemKeHang;
        private DataGridView dgvKeHang;
        private DataGridViewTextBoxColumn colMaKe;
        private DataGridViewTextBoxColumn colKhuVuc;
        private DataGridViewTextBoxColumn colLoaiHang;
        private DataGridViewTextBoxColumn colSucChua;
        private DataGridViewTextBoxColumn colTrangThai;
        private TextBox txtSearchKeHang;
    }
}
