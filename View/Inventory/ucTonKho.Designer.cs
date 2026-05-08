namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    partial class ucTonKho
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
            button5 = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            dgvKho = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colTon = new DataGridViewTextBoxColumn();
            colViTri = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            panel5 = new Panel();
            lblTongGiaTri = new Label();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblTongSKU = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblSapHet = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(512, 45);
            button5.Name = "button5";
            button5.Size = new Size(199, 43);
            button5.TabIndex = 9;
            button5.Text = "+ Tạo phiếu nhập mới";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(28, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm mã hàng, tên hàng...";
            txtSearch.Size = new Size(291, 27);
            txtSearch.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 113);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 10;
            label1.Text = "Tồn Kho";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(733, 487);
            panel2.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Controls.Add(dgvKho);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(733, 333);
            panel7.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 3);
            label6.Name = "label6";
            label6.Size = new Size(277, 28);
            label6.TabIndex = 21;
            label6.Text = "Danh sách hàng hóa trên kệ";
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.BackgroundColor = SystemColors.Control;
            dgvKho.BorderStyle = BorderStyle.None;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen, colLoai, colTon, colViTri, colTrangThai });
            dgvKho.Location = new Point(11, 43);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersVisible = false;
            dgvKho.RowHeadersWidth = 51;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(705, 269);
            dgvKho.TabIndex = 20;
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
            // panel6
            // 
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 154);
            panel6.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTongGiaTri);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(486, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(218, 117);
            panel5.TabIndex = 18;
            // 
            // lblTongGiaTri
            // 
            lblTongGiaTri.AutoSize = true;
            lblTongGiaTri.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTongGiaTri.Location = new Point(38, 60);
            lblTongGiaTri.Name = "lblTongGiaTri";
            lblTongGiaTri.Size = new Size(19, 23);
            lblTongGiaTri.TabIndex = 1;
            lblTongGiaTri.Text = "0";
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
            label5.Location = new Point(13, -4);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 19;
            label5.Text = "Tổng quan Tồn kho";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTongSKU);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(11, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 117);
            panel3.TabIndex = 16;
            // 
            // lblTongSKU
            // 
            lblTongSKU.AutoSize = true;
            lblTongSKU.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTongSKU.Location = new Point(16, 60);
            lblTongSKU.Name = "lblTongSKU";
            lblTongSKU.Size = new Size(19, 23);
            lblTongSKU.TabIndex = 1;
            lblTongSKU.Text = "0";
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
            panel4.Location = new Point(249, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 117);
            panel4.TabIndex = 17;
            // 
            // lblSapHet
            // 
            lblSapHet.AutoSize = true;
            lblSapHet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSapHet.Location = new Point(33, 60);
            lblSapHet.Name = "lblSapHet";
            lblSapHet.Size = new Size(19, 23);
            lblSapHet.TabIndex = 1;
            lblSapHet.Text = "0";
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
            // ucTonKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucTonKho";
            Size = new Size(733, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private TextBox txtSearch;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private DataGridView dgvKho;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colTon;
        private DataGridViewTextBoxColumn colViTri;
        private DataGridViewTextBoxColumn colTrangThai;
        private Panel panel5;
        private Label lblTongGiaTri;
        private Label label4;
        private Panel panel3;
        private Label lblTongSKU;
        private Label label2;
        private Panel panel4;
        private Label lblSapHet;
        private Label label3;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
    }
}
