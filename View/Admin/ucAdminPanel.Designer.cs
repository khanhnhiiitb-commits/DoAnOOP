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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTongQuan = new Button();
            btnManageStaff = new Button();
            btnKM = new Button();
            btnManageProducts = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            pnlAdminContent = new Panel();
            PanelAdminMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAdminMenu
            // 
            PanelAdminMenu.BackColor = SystemColors.GradientInactiveCaption;
            PanelAdminMenu.Controls.Add(label1);
            PanelAdminMenu.Controls.Add(flowLayoutPanel1);
            PanelAdminMenu.Dock = DockStyle.Left;
            PanelAdminMenu.ForeColor = SystemColors.ControlText;
            PanelAdminMenu.Location = new Point(0, 0);
            PanelAdminMenu.Name = "PanelAdminMenu";
            PanelAdminMenu.Size = new Size(244, 679);
            PanelAdminMenu.TabIndex = 0;
            PanelAdminMenu.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "AdminPanel";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnTongQuan);
            flowLayoutPanel1.Controls.Add(btnManageStaff);
            flowLayoutPanel1.Controls.Add(btnKM);
            flowLayoutPanel1.Controls.Add(btnManageProducts);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Location = new Point(0, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(244, 635);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTongQuan
            // 
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnTongQuan.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.Image = Properties.Resources.iconHome;
            btnTongQuan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.Location = new Point(3, 3);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Size = new Size(244, 53);
            btnTongQuan.TabIndex = 5;
            btnTongQuan.Text = "Tổng quan Dashboard";
            btnTongQuan.UseVisualStyleBackColor = true;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // btnManageStaff
            // 
            btnManageStaff.FlatAppearance.BorderSize = 0;
            btnManageStaff.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnManageStaff.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnManageStaff.FlatStyle = FlatStyle.Flat;
            btnManageStaff.Image = Properties.Resources.iconPeople;
            btnManageStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageStaff.Location = new Point(3, 62);
            btnManageStaff.Name = "btnManageStaff";
            btnManageStaff.Size = new Size(244, 53);
            btnManageStaff.TabIndex = 0;
            btnManageStaff.Text = "Quản lý Nhân sự";
            btnManageStaff.UseVisualStyleBackColor = true;
            btnManageStaff.Click += btnManageStaff_Click;
            // 
            // btnKM
            // 
            btnKM.FlatAppearance.BorderSize = 0;
            btnKM.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnKM.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnKM.FlatStyle = FlatStyle.Flat;
            btnKM.Image = Properties.Resources.iconDiscount;
            btnKM.ImageAlign = ContentAlignment.MiddleLeft;
            btnKM.Location = new Point(3, 121);
            btnKM.Name = "btnKM";
            btnKM.Size = new Size(244, 53);
            btnKM.TabIndex = 6;
            btnKM.Text = "Khuyến mãi & Voucher";
            btnKM.UseVisualStyleBackColor = true;
            btnKM.Click += btnKM_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.FlatAppearance.BorderSize = 0;
            btnManageProducts.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnManageProducts.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnManageProducts.FlatStyle = FlatStyle.Flat;
            btnManageProducts.Image = Properties.Resources.iconPackage;
            btnManageProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageProducts.Location = new Point(3, 180);
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
            btnReports.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Image = Properties.Resources.iconLineChart;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 239);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(244, 53);
            btnReports.TabIndex = 2;
            btnReports.Text = "Thống kê doanh thu";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(3, 298);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 37);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlAdminContent
            // 
            pnlAdminContent.AutoSize = true;
            pnlAdminContent.Location = new Point(244, 0);
            pnlAdminContent.Name = "pnlAdminContent";
            pnlAdminContent.Size = new Size(1202, 676);
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
            Size = new Size(1449, 679);
            Load += ucAdminPanel_Load;
            PanelAdminMenu.ResumeLayout(false);
            PanelAdminMenu.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnTongQuan;
        private Button btnKM;
    }
}
