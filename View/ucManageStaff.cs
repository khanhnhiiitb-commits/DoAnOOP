using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Data;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucManageStaff : UserControl
    {

        private StaffRepository staffRepo = new StaffRepository();
        private void HienThiLenBang()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = DataStorage.Instance.DanhSachNV;
            if (dgvNhanVien.Columns["Taikhoan"] != null)
            {
                dgvNhanVien.Columns["Taikhoan"].Visible = false;
            }
            if (dgvNhanVien.Columns["GioiTinh"] != null)
                dgvNhanVien.Columns["GioiTinh"].Visible = false; 
            if (dgvNhanVien.Columns["HienThiGioiTinh"] != null)
                dgvNhanVien.Columns["HienThiGioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["Ma"].Visible = false;
            dgvNhanVien.Columns["MaCa"].Visible = false;
        }
        public ucManageStaff()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucManageStaff_Load(object sender, EventArgs e)
        {
            HienThiLenBang();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
