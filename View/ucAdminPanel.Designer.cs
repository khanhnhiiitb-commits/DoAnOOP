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
            PanelAdminMenu = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnManageStaff = new Button();
            btnManageProducts = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            label1 = new Label();
            pnlAdminContent = new Panel();
            PanelAdminMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAdminMenu
            // 
            PanelAdminMenu.BackColor = SystemColors.ControlDark;
            PanelAdminMenu.Controls.Add(flowLayoutPanel1);
            PanelAdminMenu.Controls.Add(label1);
            PanelAdminMenu.Dock = DockStyle.Left;
            PanelAdminMenu.ForeColor = SystemColors.ControlText;
            PanelAdminMenu.Location = new Point(0, 0);
            PanelAdminMenu.Name = "PanelAdminMenu";
            PanelAdminMenu.Size = new Size(244, 310);
            PanelAdminMenu.TabIndex = 0;
            PanelAdminMenu.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnManageStaff);
            flowLayoutPanel1.Controls.Add(btnManageProducts);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Location = new Point(0, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(244, 266);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnManageStaff
            // 
            btnManageStaff.FlatAppearance.BorderSize = 0;
            btnManageStaff.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnManageStaff.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnManageStaff.FlatStyle = FlatStyle.Flat;
            btnManageStaff.Location = new Point(3, 3);
            btnManageStaff.Name = "btnManageStaff";
            btnManageStaff.Size = new Size(244, 53);
            btnManageStaff.TabIndex = 0;
            btnManageStaff.Text = "Quản lý Nhân viên";
            btnManageStaff.UseVisualStyleBackColor = true;
            btnManageStaff.Click += btnManageStaff_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.FlatAppearance.BorderSize = 0;
            btnManageProducts.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnManageProducts.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnManageProducts.FlatStyle = FlatStyle.Flat;
            btnManageProducts.Location = new Point(3, 62);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(244, 53);
            btnManageProducts.TabIndex = 1;
            btnManageProducts.Text = "Quản lý Hàng hóa";
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnReports.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(3, 121);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(244, 53);
            btnReports.TabIndex = 2;
            btnReports.Text = "Thống kê doanh thu";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(3, 180);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 37);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "AdminPanel";
            // 
            // pnlAdminContent
            // 
            pnlAdminContent.Dock = DockStyle.Fill;
            pnlAdminContent.Location = new Point(244, 0);
            pnlAdminContent.Name = "pnlAdminContent";
            pnlAdminContent.Size = new Size(677, 310);
            pnlAdminContent.TabIndex = 1;
            pnlAdminContent.Paint += pnlAdminContent_Paint;
            // 
            // ucAdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAdminContent);
            Controls.Add(PanelAdminMenu);
            Name = "ucAdminPanel";
            Size = new Size(921, 310);
            Load += ucAdminPanel_Load;
            PanelAdminMenu.ResumeLayout(false);
            PanelAdminMenu.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAdminMenu;
        private Button btnReports;
        private Button btnManageProducts;
        private Button btnManageStaff;
        private Label label1;
        private Panel pnlAdminContent;
        private Button btnLogout;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
