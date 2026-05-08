using ChuongtrinhQuanlybanhangsieuthi.View.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class panelKho : UserControl
    {
        public panelKho()
        {
            InitializeComponent();
        }

        private void OpenUserControl(UserControl uc)
        {
            pnlContainer.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(uc);

            uc.BringToFront();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucTonKho());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucPhieuNhap());
        }

        private void btnQuanLyKeHang_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucQuanLyKeHang());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ucNhaCungCap());
        }
       
    }
}

