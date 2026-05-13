using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongtrinhQuanlybanhangsieuthi.Models.Products;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucManageProduct : UserControl
    {
        private InventoryRepository inventoryRepo = new InventoryRepository();
        public ucManageProduct()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void HienThiLenBang()
        {
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = DataStorage.Instance.DanhSachHang;
            if (dgvHangHoa.Columns["MaKeHang"] != null)
                dgvHangHoa.Columns["MaKeHang"].Visible = false;
        }
        public void XuLyThemHang(string luaChonTuComboBox)
        {
            try
            {
                HangHoa spMoi = HangHoaFactory.TaoHangHoa(luaChonTuComboBox);

                spMoi.MaHH = txtMaHH.Text;
                spMoi.TenHang = txtTenHH.Text;
                spMoi.DonGia = Convert.ToDouble(txtDonGia.Text);

                if (spMoi is HangThucPham tp)
                {
                    tp.HSD = DatePickerHSD.Value;
                    tp.NgaySX = DatePickerSX.Value;
                }
                else if (spMoi is HangDienTu dt)
                {
                    dt.ThoiGianBH = int.Parse(txtThoiGianBH.Text);
                }

                DataStorage.Instance.DanhSachHang.Add(spMoi);
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            XuLyThemHang(cbLoaiHH.Text);
        }

        private void ucManageProduct_Load(object sender, EventArgs e)
        {
            HienThiLenBang();
        }
    }
}
