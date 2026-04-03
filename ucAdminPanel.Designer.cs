namespace ChuongtrinhQuanlybanhangsieuthi
{
    partial class ucAdminPanel
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
            AdminMenu = new Panel();
            label1 = new Label();
            btnReports = new Button();
            btnManageProducts = new Button();
            btnManageStaff = new Button();
            pnlAdminContent = new Panel();
            AdminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // AdminMenu
            // 
            AdminMenu.BackColor = SystemColors.ControlDark;
            AdminMenu.Controls.Add(label1);
            AdminMenu.Controls.Add(btnReports);
            AdminMenu.Controls.Add(btnManageProducts);
            AdminMenu.Controls.Add(btnManageStaff);
            AdminMenu.Dock = DockStyle.Left;
            AdminMenu.Location = new Point(0, 0);
            AdminMenu.Name = "AdminMenu";
            AdminMenu.Size = new Size(250, 310);
            AdminMenu.TabIndex = 0;
            AdminMenu.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(35, 14);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "AdminPanel";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(35, 221);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(186, 53);
            btnReports.TabIndex = 2;
            btnReports.Text = "Thống kê doanh thu";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Location = new Point(35, 143);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(186, 53);
            btnManageProducts.TabIndex = 1;
            btnManageProducts.Text = "Quản lý Hàng hóa";
            btnManageProducts.UseVisualStyleBackColor = true;
            // 
            // btnManageStaff
            // 
            btnManageStaff.Location = new Point(35, 62);
            btnManageStaff.Name = "btnManageStaff";
            btnManageStaff.Size = new Size(186, 53);
            btnManageStaff.TabIndex = 0;
            btnManageStaff.Text = "Quản lý Nhân viên";
            btnManageStaff.UseVisualStyleBackColor = true;
            btnManageStaff.Click += btnManageStaff_Click;
            // 
            // pnlAdminContent
            // 
            pnlAdminContent.Dock = DockStyle.Fill;
            pnlAdminContent.Location = new Point(250, 0);
            pnlAdminContent.Name = "pnlAdminContent";
            pnlAdminContent.Size = new Size(671, 310);
            pnlAdminContent.TabIndex = 1;
            // 
            // ucAdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAdminContent);
            Controls.Add(AdminMenu);
            Name = "ucAdminPanel";
            Size = new Size(921, 310);
            Load += ucAdminPanel_Load;
            AdminMenu.ResumeLayout(false);
            AdminMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AdminMenu;
        private Button btnReports;
        private Button btnManageProducts;
        private Button btnManageStaff;
        private Label label1;
        private Panel pnlAdminContent;
    }
}
