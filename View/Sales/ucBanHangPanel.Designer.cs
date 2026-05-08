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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvSP = new DataGridView();
            Masp = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TồnKho = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvGioHang = new DataGridView();
            Giohang = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTongTien = new Label();
            label5 = new Label();
            lblTong = new Label();
            txtKhachDua = new TextBox();
            lblTienThua = new Label();
            btnXoaHang = new Button();
            btnLamMoi = new Button();
            btnThanhToan = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(541, 25);
            label1.TabIndex = 0;
            label1.Text = "Khu vực tìm kiếm sản phẩm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = SystemColors.InactiveCaption;
            txtTimKiem.Location = new Point(17, 58);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(308, 30);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.ActiveCaption;
            btnTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            btnTimKiem.Location = new Point(351, 61);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 30);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvSP
            // 
            dgvSP.BackgroundColor = SystemColors.ActiveCaption;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Columns.AddRange(new DataGridViewColumn[] { Masp, TenSP, DonGia, TồnKho });
            dgvSP.Location = new Point(7, 94);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.Size = new Size(551, 236);
            dgvSP.TabIndex = 3;
            // 
            // Masp
            // 
            Masp.HeaderText = "Mã SP";
            Masp.MinimumWidth = 6;
            Masp.Name = "Masp";
            Masp.Width = 125;
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.Width = 125;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 125;
            // 
            // TồnKho
            // 
            TồnKho.HeaderText = "Tồn kho";
            TồnKho.MinimumWidth = 6;
            TồnKho.Name = "TồnKho";
            TồnKho.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dgvSP);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 578);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Controls.Add(btnXoaHang);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvGioHang);
            groupBox2.Controls.Add(Giohang);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(611, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 578);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // dgvGioHang
            // 
            dgvGioHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGioHang.BackgroundColor = SystemColors.ActiveCaption;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGioHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGioHang.Location = new Point(7, 61);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.Size = new Size(570, 236);
            dgvGioHang.TabIndex = 3;
            // 
            // Giohang
            // 
            Giohang.BackColor = SystemColors.ActiveCaption;
            Giohang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Giohang.ForeColor = SystemColors.Highlight;
            Giohang.Location = new Point(17, 23);
            Giohang.Name = "Giohang";
            Giohang.Size = new Size(569, 25);
            Giohang.TabIndex = 0;
            Giohang.Text = "Giỏ hàng";
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên SP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Đơn giá";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "SL";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(lblTienThua);
            groupBox3.Controls.Add(txtKhachDua);
            groupBox3.Controls.Add(lblTong);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lblTongTien);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(6, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(544, 190);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(52, 36);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 0;
            label2.Text = "Tổng cộng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(52, 97);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 1;
            label3.Text = "Khách đưa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(52, 157);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 2;
            label4.Text = "Tiền thừa:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(294, 35);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 23);
            lblTongTien.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Location = new Point(278, 35);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 4;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTong.ForeColor = Color.Red;
            lblTong.Location = new Point(161, 35);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(28, 20);
            lblTong.TabIndex = 5;
            lblTong.Text = "0đ";
            // 
            // txtKhachDua
            // 
            txtKhachDua.Location = new Point(181, 94);
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Size = new Size(324, 30);
            txtKhachDua.TabIndex = 6;
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienThua.ForeColor = Color.FromArgb(0, 64, 0);
            lblTienThua.Location = new Point(161, 157);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(28, 20);
            lblTienThua.TabIndex = 7;
            lblTienThua.Text = "0đ";
            // 
            // btnXoaHang
            // 
            btnXoaHang.BackColor = Color.Red;
            btnXoaHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaHang.ForeColor = SystemColors.Control;
            btnXoaHang.Location = new Point(187, 509);
            btnXoaHang.Name = "btnXoaHang";
            btnXoaHang.Size = new Size(106, 43);
            btnXoaHang.TabIndex = 7;
            btnXoaHang.Text = "Xóa hàng";
            btnXoaHang.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ActiveCaption;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = SystemColors.Control;
            btnLamMoi.Location = new Point(312, 509);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 43);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Green;
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.ForeColor = SystemColors.Control;
            btnThanhToan.Location = new Point(438, 509);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(106, 43);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(320, 345);
            label6.Name = "label6";
            label6.Size = new Size(238, 23);
            label6.TabIndex = 4;
            label6.Text = "Double-click -->thêm vào giỏ";
            label6.Click += label6_Click;
            // 
            // ucBanHangPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ucBanHangPanel";
            Size = new Size(1184, 616);
            Load += ucBanHangPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvSP;
        private DataGridViewTextBoxColumn Masp;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TồnKho;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvGioHang;
        private Label Giohang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox3;
        private Label lblTongTien;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTienThua;
        private TextBox txtKhachDua;
        private Label lblTong;
        private Label label5;
        private Button btnThanhToan;
        private Button btnLamMoi;
        private Button btnXoaHang;
        private Label label6;
    }
}
