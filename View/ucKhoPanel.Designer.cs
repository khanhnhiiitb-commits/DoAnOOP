namespace ChuongtrinhQuanlybanhangsieuthi
{
    partial class pnlMenu
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

        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            txtSearch = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            label5 = new Label();
            dgvKho = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colTon = new DataGridViewTextBoxColumn();
            colViTri = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            label6 = new Label();
            lblTongSKU = new Label();
            lblSapHet = new Label();
            lblTongGiaTri = new Label();
            pnlUser = new Panel();
            lblNhanVien = new Label();
            lnkDangXuat = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            pnlUser.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pnlUser);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 609);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(16, 237);
            button4.Name = "button4";
            button4.Size = new Size(229, 47);
            button4.TabIndex = 4;
            button4.Text = "Nhà cung cấp";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(16, 184);
            button3.Name = "button3";
            button3.Size = new Size(229, 47);
            button3.TabIndex = 3;
            button3.Text = "Quản lý kệ hàng";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(16, 131);
            button2.Name = "button2";
            button2.Size = new Size(229, 47);
            button2.TabIndex = 2;
            button2.Text = "Phiếu nhập";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(15, 78);
            button1.Name = "button1";
            button1.Size = new Size(229, 47);
            button1.TabIndex = 1;
            button1.Text = "Tồn kho";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 0;
            label1.Text = "SmartInventory";
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(267, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 68);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(526, 15);
            button5.Name = "button5";
            button5.Size = new Size(199, 43);
            button5.TabIndex = 1;
            button5.Text = "+ Tạo phiếu nhập mới";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm mã hàng, tên hàng...";
            txtSearch.Size = new Size(291, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTongSKU);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(285, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 140);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(14, 23);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 0;
            label2.Text = "Tổng SKU (Mặt hàng)";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblSapHet);
            panel4.Controls.Add(label3);
            panel4.ForeColor = Color.Red;
            panel4.Location = new Point(532, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 140);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(33, 23);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 0;
            label3.Text = "Cảnh báo sắp hết";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTongGiaTri);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(774, 131);
            panel5.Name = "panel5";
            panel5.Size = new Size(218, 140);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(38, 23);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 0;
            label4.Text = "Tổng giá trị kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 84);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 5;
            label5.Text = "Tổng quan Tồn kho";
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.BackgroundColor = SystemColors.Control;
            dgvKho.BorderStyle = BorderStyle.None;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen, colLoai, colTon, colViTri, colTrangThai });
            dgvKho.Location = new Point(287, 315);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersVisible = false;
            dgvKho.RowHeadersWidth = 51;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(705, 277);
            dgvKho.TabIndex = 6;
            // 
            // colMa
            // 
            colMa.HeaderText = "MÃ HH";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            // 
            // colTen
            // 
            colTen.HeaderText = "TÊN HÀNG HÓA";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            // 
            // colLoai
            // 
            colLoai.HeaderText = "PHÂN LOẠI";
            colLoai.MinimumWidth = 6;
            colLoai.Name = "colLoai";
            // 
            // colTon
            // 
            colTon.HeaderText = "TỒN KHO";
            colTon.MinimumWidth = 6;
            colTon.Name = "colTon";
            // 
            // colViTri
            // 
            colViTri.HeaderText = "VỊ TRÍ KỆ";
            colViTri.MinimumWidth = 6;
            colViTri.Name = "colViTri";
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(285, 284);
            label6.Name = "label6";
            label6.Size = new Size(277, 28);
            label6.TabIndex = 7;
            label6.Text = "Danh sách hàng hóa trên kệ";
            // 
            // lblTongSKU
            // 
            lblTongSKU.AutoSize = true;
            lblTongSKU.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTongSKU.Location = new Point(14, 79);
            lblTongSKU.Name = "lblTongSKU";
            lblTongSKU.Size = new Size(19, 23);
            lblTongSKU.TabIndex = 1;
            lblTongSKU.Text = "0";
            // 
            // lblSapHet
            // 
            lblSapHet.AutoSize = true;
            lblSapHet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSapHet.Location = new Point(33, 79);
            lblSapHet.Name = "lblSapHet";
            lblSapHet.Size = new Size(19, 23);
            lblSapHet.TabIndex = 1;
            lblSapHet.Text = "0";
            // 
            // lblTongGiaTri
            // 
            lblTongGiaTri.AutoSize = true;
            lblTongGiaTri.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTongGiaTri.Location = new Point(38, 79);
            lblTongGiaTri.Name = "lblTongGiaTri";
            lblTongGiaTri.Size = new Size(19, 23);
            lblTongGiaTri.TabIndex = 1;
            lblTongGiaTri.Text = "0";
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(lnkDangXuat);
            pnlUser.Controls.Add(lblNhanVien);
            pnlUser.Dock = DockStyle.Bottom;
            pnlUser.Location = new Point(0, 548);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(267, 61);
            pnlUser.TabIndex = 5;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(47, 14);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(83, 20);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "NV Kho: ...";
            // 
            // lnkDangXuat
            // 
            lnkDangXuat.AutoSize = true;
            lnkDangXuat.LinkColor = Color.Red;
            lnkDangXuat.Location = new Point(47, 34);
            lnkDangXuat.Name = "lnkDangXuat";
            lnkDangXuat.Size = new Size(77, 20);
            lnkDangXuat.TabIndex = 1;
            lnkDangXuat.TabStop = true;
            lnkDangXuat.Text = "Đăng xuất";
            // 
            // pnlMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(dgvKho);
            Controls.Add(label5);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "pnlMenu";
            Size = new Size(1008, 609);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel panel1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox txtSearch;
        private Button button5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvKho;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colTon;
        private DataGridViewTextBoxColumn colViTri;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label label6;
        private Label lblTongSKU;
        private Label lblSapHet;
        private Label lblTongGiaTri;
        private Panel pnlUser;
        private LinkLabel lnkDangXuat;
        private Label lblNhanVien;
    }
}
#region Component Designer generated code

/// <summary> 
/// Required method for Designer support - do not modify 
/// the contents of this method with the code editor.
/// </summary>

           

        #endregion
    

