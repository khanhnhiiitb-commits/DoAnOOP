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
    public partial class ucBanHangPanel : UserControl
    {
        private DataTable dtGioHang = new DataTable();
        //private List<SanPham> danhSachSP = new List<SanPham>();
        public ucBanHangPanel()
        {
            InitializeComponent();
            KhoiTaoGioHang();

        }
        private void KhoiTaoGioHang()
        {
            dtGioHang.Columns.Add("MaSP", typeof(string));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal));

            dgvGioHang.DataSource = dtGioHang;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //ê nè
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucBanHangPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
