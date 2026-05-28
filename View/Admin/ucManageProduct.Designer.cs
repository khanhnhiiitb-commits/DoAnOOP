namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    partial class ucManageProduct
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
            txtDVT = new TextBox();
            label10 = new Label();
            btnLuu = new Button();
            btnReset = new Button();
            btnXoa = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            DatePickerHSD = new DateTimePicker();
            DatePickerSX = new DateTimePicker();
            txtThoiGianBH = new TextBox();
            txtDonGia = new TextBox();
            cbLoaiHH = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtTenHH = new TextBox();
            txtMaHH = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dgvHangHoa = new DataGridView();
            panel3 = new Panel();
            txtTimHH = new TextBox();
            label9 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtDVT);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(DatePickerHSD);
            panel1.Controls.Add(DatePickerSX);
            panel1.Controls.Add(txtThoiGianBH);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(cbLoaiHH);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenHH);
            panel1.Controls.Add(txtMaHH);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 589);
            panel1.TabIndex = 0;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(318, 131);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(94, 27);
            txtDVT.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(204, 130);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 20;
            label10.Text = "Đơn vị tính";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.Control;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(-4, 169);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(428, 46);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Control;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.Highlight;
            btnReset.Location = new Point(-4, 11);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(428, 48);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.Highlight;
            btnXoa.Location = new Point(-4, 221);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(428, 42);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.BackColor = SystemColors.Control;
            btnCapnhat.FlatAppearance.BorderSize = 0;
            btnCapnhat.FlatStyle = FlatStyle.Flat;
            btnCapnhat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapnhat.ForeColor = SystemColors.Highlight;
            btnCapnhat.Location = new Point(-4, 117);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(428, 46);
            btnCapnhat.TabIndex = 16;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Control;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(-4, 65);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(428, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // DatePickerHSD
            // 
            DatePickerHSD.Location = new Point(158, 224);
            DatePickerHSD.Name = "DatePickerHSD";
            DatePickerHSD.Size = new Size(254, 27);
            DatePickerHSD.TabIndex = 14;
            // 
            // DatePickerSX
            // 
            DatePickerSX.Location = new Point(159, 179);
            DatePickerSX.Name = "DatePickerSX";
            DatePickerSX.Size = new Size(253, 27);
            DatePickerSX.TabIndex = 13;
            // 
            // txtThoiGianBH
            // 
            txtThoiGianBH.Location = new Point(206, 273);
            txtThoiGianBH.Name = "txtThoiGianBH";
            txtThoiGianBH.Size = new Size(206, 27);
            txtThoiGianBH.TabIndex = 12;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(102, 134);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(96, 27);
            txtDonGia.TabIndex = 11;
            // 
            // cbLoaiHH
            // 
            cbLoaiHH.FormattingEnabled = true;
            cbLoaiHH.Location = new Point(220, 39);
            cbLoaiHH.Name = "cbLoaiHH";
            cbLoaiHH.Size = new Size(192, 28);
            cbLoaiHH.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 222);
            label8.Name = "label8";
            label8.Size = new Size(129, 28);
            label8.TabIndex = 9;
            label8.Text = "Ngày hết hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(220, 9);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 8;
            label7.Text = "Phân loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 130);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 7;
            label6.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 269);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 6;
            label5.Text = "Thời gian bảo hành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 177);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 5;
            label4.Text = "Ngày sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 87);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 4;
            label3.Text = "Tên hàng";
            // 
            // txtTenHH
            // 
            txtTenHH.Location = new Point(102, 88);
            txtTenHH.Name = "txtTenHH";
            txtTenHH.Size = new Size(310, 27);
            txtTenHH.TabIndex = 3;
            // 
            // txtMaHH
            // 
            txtMaHH.Location = new Point(18, 40);
            txtMaHH.Name = "txtMaHH";
            txtMaHH.Size = new Size(180, 27);
            txtMaHH.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã hàng";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvHangHoa);
            panel2.Location = new Point(467, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 539);
            panel2.TabIndex = 1;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Location = new Point(-1, -1);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(700, 539);
            dgvHangHoa.TabIndex = 0;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtTimHH);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(467, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 85);
            panel3.TabIndex = 2;
            // 
            // txtTimHH
            // 
            txtTimHH.Location = new Point(247, 24);
            txtTimHH.Name = "txtTimHH";
            txtTimHH.Size = new Size(429, 27);
            txtTimHH.TabIndex = 2;
            txtTimHH.TextChanged += txtTimHH_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 21);
            label9.Name = "label9";
            label9.Size = new Size(188, 28);
            label9.TabIndex = 1;
            label9.Text = "Danh sách hàng hóa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin hàng hóa";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(18, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 42);
            panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnCapnhat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(3, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 282);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // ucManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucManageProduct";
            Size = new Size(1202, 676);
            Load += ucManageProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtTenHH;
        private TextBox txtMaHH;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvHangHoa;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private TextBox txtDonGia;
        private ComboBox cbLoaiHH;
        private Label label8;
        private Label label7;
        private DateTimePicker DatePickerHSD;
        private DateTimePicker DatePickerSX;
        private TextBox txtThoiGianBH;
        private Button btnThem;
        private Button btnXoa;
        private Button btnCapnhat;
        private Label label9;
        private TextBox txtTimHH;
        private Button btnReset;
        private Button btnLuu;
        private TextBox txtDVT;
        private Label label10;
        private GroupBox groupBox1;
    }
}
