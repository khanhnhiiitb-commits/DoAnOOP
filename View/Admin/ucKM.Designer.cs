namespace ChuongtrinhQuanlybanhangsieuthi.View.Admin
{
    partial class ucKM
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
            btnCreate = new Button();
            DatePicker2 = new DateTimePicker();
            DatePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            cbLoaiGiam = new ComboBox();
            txtMucGiam = new TextBox();
            label4 = new Label();
            txtTenKM = new TextBox();
            label3 = new Label();
            txtMaKM = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            btnDoiTrangThai = new Button();
            label7 = new Label();
            panel4 = new Panel();
            dgvKM = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKM).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(DatePicker2);
            panel1.Controls.Add(DatePicker1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbLoaiGiam);
            panel1.Controls.Add(txtMucGiam);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTenKM);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaKM);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(31, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 583);
            panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.MenuHighlight;
            btnCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(11, 506);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(313, 43);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Tạo Khuyến mãi";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // DatePicker2
            // 
            DatePicker2.Location = new Point(13, 453);
            DatePicker2.Name = "DatePicker2";
            DatePicker2.Size = new Size(250, 27);
            DatePicker2.TabIndex = 10;
            // 
            // DatePicker1
            // 
            DatePicker1.Location = new Point(13, 379);
            DatePicker1.Name = "DatePicker1";
            DatePicker1.Size = new Size(250, 27);
            DatePicker1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 425);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 8;
            label6.Text = "Đến ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 351);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 7;
            label5.Text = "Từ ngày";
            // 
            // cbLoaiGiam
            // 
            cbLoaiGiam.FormattingEnabled = true;
            cbLoaiGiam.Items.AddRange(new object[] { "%", "VNĐ" });
            cbLoaiGiam.Location = new Point(111, 227);
            cbLoaiGiam.Name = "cbLoaiGiam";
            cbLoaiGiam.Size = new Size(213, 28);
            cbLoaiGiam.TabIndex = 6;
            // 
            // txtMucGiam
            // 
            txtMucGiam.Location = new Point(13, 261);
            txtMucGiam.Name = "txtMucGiam";
            txtMucGiam.Size = new Size(311, 27);
            txtMucGiam.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 226);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 4;
            label4.Text = "Mức giảm";
            // 
            // txtTenKM
            // 
            txtTenKM.Location = new Point(13, 157);
            txtTenKM.Name = "txtTenKM";
            txtTenKM.Size = new Size(311, 27);
            txtTenKM.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 129);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên Khuyến mãi";
            // 
            // txtMaKM
            // 
            txtMaKM.Location = new Point(13, 57);
            txtMaKM.Name = "txtMaKM";
            txtMaKM.Size = new Size(311, 27);
            txtMaKM.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 29);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã Khuyến mãi";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDoiTrangThai);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(372, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 630);
            panel2.TabIndex = 1;
            // 
            // btnDoiTrangThai
            // 
            btnDoiTrangThai.BackColor = Color.LightCoral;
            btnDoiTrangThai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoiTrangThai.Location = new Point(3, 553);
            btnDoiTrangThai.Name = "btnDoiTrangThai";
            btnDoiTrangThai.Size = new Size(233, 43);
            btnDoiTrangThai.TabIndex = 12;
            btnDoiTrangThai.Text = "Đổi trạng thái";
            btnDoiTrangThai.UseVisualStyleBackColor = false;
            btnDoiTrangThai.Click += btnDoiTrangThai_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 18);
            label7.Name = "label7";
            label7.Size = new Size(324, 25);
            label7.TabIndex = 1;
            label7.Text = "Danh sách Khuyến Mãi của hệ thống";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvKM);
            panel4.Location = new Point(3, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(823, 471);
            panel4.TabIndex = 2;
            // 
            // dgvKM
            // 
            dgvKM.BackgroundColor = SystemColors.Control;
            dgvKM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKM.Location = new Point(-1, 3);
            dgvKM.Name = "dgvKM";
            dgvKM.RowHeadersWidth = 51;
            dgvKM.Size = new Size(819, 463);
            dgvKM.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(31, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 55);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 0;
            label1.Text = "Phát hành Khuyến Mãi mới";
            // 
            // ucKM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucKM";
            Size = new Size(1202, 676);
            Load += ucKM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKM).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView dgvKM;
        private Panel panel3;
        private Label label1;
        private Button btnCreate;
        private DateTimePicker DatePicker2;
        private DateTimePicker DatePicker1;
        private Label label6;
        private Label label5;
        private ComboBox cbLoaiGiam;
        private TextBox txtMucGiam;
        private Label label4;
        private TextBox txtTenKM;
        private Label label3;
        private TextBox txtMaKM;
        private Label label2;
        private Label label7;
        private Button btnDoiTrangThai;
    }
}
