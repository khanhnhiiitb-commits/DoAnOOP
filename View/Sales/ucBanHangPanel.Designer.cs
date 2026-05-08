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
            btnTimKiem = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            lbTon = new Label();
            lbGia = new Label();
            label9 = new Label();
            pB1 = new PictureBox();
            groupBox2 = new GroupBox();
            dgvGioHang = new DataGridView();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLamMoi = new Button();
            textBox1 = new TextBox();
            Giohang = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pB1).BeginInit();
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
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.ButtonHighlight;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = SystemColors.ControlDarkDark;
            btnTimKiem.Location = new Point(517, 23);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.RightToLeft = RightToLeft.Yes;
            btnTimKiem.Size = new Size(81, 30);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Điện tử";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 578);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(268, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 181);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(146, 141);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 6;
            label1.Text = "Tồn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(19, 141);
            label5.Name = "label5";
            label5.Size = new Size(35, 23);
            label5.TabIndex = 5;
            label5.Text = "Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(3, 106);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 4;
            label6.Text = "Tên sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(615, 23);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(120, 30);
            button2.TabIndex = 9;
            button2.Text = "Thực phẩm";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(415, 23);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(81, 30);
            button1.TabIndex = 8;
            button1.Text = "Tất cả";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbTon);
            panel1.Controls.Add(lbGia);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pB1);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(27, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 181);
            panel1.TabIndex = 5;
            // 
            // lbTon
            // 
            lbTon.AutoSize = true;
            lbTon.BackColor = Color.DarkSeaGreen;
            lbTon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbTon.ForeColor = Color.DarkGreen;
            lbTon.Location = new Point(146, 141);
            lbTon.Name = "lbTon";
            lbTon.Size = new Size(39, 23);
            lbTon.TabIndex = 6;
            lbTon.Text = "Tồn";
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.BackColor = Color.Transparent;
            lbGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbGia.ForeColor = Color.FromArgb(0, 0, 192);
            lbGia.Location = new Point(19, 141);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(35, 23);
            lbGia.TabIndex = 5;
            lbGia.Text = "Giá";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(19, 106);
            label9.Name = "label9";
            label9.Size = new Size(116, 23);
            label9.TabIndex = 4;
            label9.Text = "Tên sản phẩm";
            label9.Click += label9_Click;
            // 
            // pB1
            // 
            pB1.BackColor = SystemColors.ButtonFace;
            pB1.Location = new Point(3, 3);
            pB1.Name = "pB1";
            pB1.Size = new Size(186, 100);
            pB1.TabIndex = 0;
            pB1.TabStop = false;
            pB1.Click += pB1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvGioHang);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(Giohang);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(768, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(607, 578);
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
            panel4.Controls.Add(btnLamMoi);
            panel4.Location = new Point(17, 322);
            panel4.Name = "panel4";
            panel4.Size = new Size(569, 236);
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
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.InactiveCaption;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = SystemColors.Control;
            btnLamMoi.Location = new Point(184, 177);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(272, 43);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "THANH TOÁN VÀ IN BILL";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(17, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(569, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Nhập SĐT khách hàng...";
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
            // ucBanHangPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ucBanHangPanel";
            Size = new Size(1378, 616);
            Load += ucBanHangPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pB1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label Giohang;
        private Button btnLamMoi;
        private Panel panel1;
        private Label lbGia;
        private Label label9;
        private PictureBox pB1;
        private Label lbTon;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private DataGridView dgvGioHang;
    }
}
