namespace ChuongtrinhQuanlybanhangsieuthi
{
    partial class ucKhoPanel
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
            panelMenu = new Panel();
            panelContent = new Panel();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnTonKho = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDark;
            panelMenu.Controls.Add(btnTonKho);
            panelMenu.Controls.Add(btnXoa);
            panelMenu.Controls.Add(btnTimKiem);
            panelMenu.Controls.Add(btnCapNhat);
            panelMenu.Controls.Add(btnThem);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(279, 326);
            panelMenu.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(279, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(624, 323);
            panelContent.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(91, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(91, 92);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(91, 207);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(91, 151);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTonKho
            // 
            btnTonKho.Location = new Point(91, 265);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Size = new Size(94, 29);
            btnTonKho.TabIndex = 4;
            btnTonKho.Text = "Tồn kho";
            btnTonKho.UseVisualStyleBackColor = true;
            // 
            // ucKhoPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Name = "ucKhoPanel";
            Size = new Size(903, 323);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContent;
        private Button btnTonKho;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnCapNhat;
        private Button btnThem;
    }
}
