using ChuongtrinhQuanlybanhangsieuthi.DataAccess;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucPhieuNhap : UserControl
    {
        private PhieuNhapRepository repo;

        private List<PhieuNhap> dsPhieuNhap;
        private QuanLyNhapHang serviceNhapHang;

        private InventoryRepository inventoryRepo;

        private List<HangHoa> dsHangHoa;

        private QuanLyKho serviceKho;
        public ucPhieuNhap()
        {
            InitializeComponent();

            repo =new PhieuNhapRepository();

            dsPhieuNhap =repo.GetAll();

            inventoryRepo =new InventoryRepository();

            dsHangHoa =inventoryRepo.GetAll();

            serviceKho =new QuanLyKho(dsHangHoa,new List<KeHang>());

            serviceNhapHang =new QuanLyNhapHang(dsPhieuNhap);
        }
        private void HienThiDanhSach()
        {
            dgvPhieuNhap.Rows.Clear();

            foreach (PhieuNhap pn in dsPhieuNhap)
            {
                dgvPhieuNhap.Rows.Add(
                    pn.MaPN,
                    pn.MaNCC,
                    pn.NgayNhap.ToShortDateString(),
                    pn.TrangThai,
                    pn.TongTien
                );
            }
        }

        private void ucPhieuNhap_Load(object sender, EventArgs e)
        {
            cboTrangThai.DropDownStyle =
        ComboBoxStyle.DropDownList;

            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("ChoXacNhan");

            cboTrangThai.Items.Add("HoanThanh");

            cboTrangThai.Items.Add("DaHuy");

            HienThiDanhSach();

            foreach (HangHoa hh in dsHangHoa)
            {
                cboMaHang.Items.Add(hh.MaHH);
            }
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            try
            {
                // TẠO NHÀ CUNG CẤP
                NhaCungCap ncc =new NhaCungCap();

                ncc.MaNCC =txtNCC.Text.Trim();

                // LẬP PHIẾU NHẬP
                PhieuNhap pn =serviceNhapHang.LapPhieuNhap(ncc);

                // TÌM HÀNG HÓA
                HangHoa hangDuocChon = null;

                foreach (HangHoa hh in dsHangHoa)
                {
                    if (hh.MaHH == cboMaHang.Text)
                    {
                        hangDuocChon = hh;

                        break;
                    }
                }

                // THÊM CHI TIẾT PHIẾU NHẬP
                serviceNhapHang.ThemChiTietPhieuNhap(pn,hangDuocChon,
                        int.Parse(txtSoLuongNhap.Text),
                        double.Parse(txtDonGiaNhap.Text));

                // XÁC NHẬN NHẬP KHO
                serviceNhapHang.XacNhanNhapKho(pn,serviceKho);

                // LƯU FILE PHIẾU NHẬP
                repo.Save(dsPhieuNhap);

                // LƯU FILE KHO
                inventoryRepo.Save(dsHangHoa);

                // HIỂN THỊ LẠI
                HienThiDanhSach();

                MessageBox.Show("Nhập hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message
                );
            }
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.CurrentRow == null)
            {
                return;
            }

            int index =
                dgvPhieuNhap.CurrentRow.Index;

            dsPhieuNhap.RemoveAt(index);

            repo.Save(dsPhieuNhap);

            HienThiDanhSach();

            MessageBox.Show("Xóa thành công!");
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtMaPN.Text =
                dgvPhieuNhap.Rows[e.RowIndex]
                .Cells[0].Value.ToString();

            txtNCC.Text =
                dgvPhieuNhap.Rows[e.RowIndex]
                .Cells[1].Value.ToString();

            dtNgayNhap.Value =
                DateTime.Parse(
                    dgvPhieuNhap.Rows[e.RowIndex]
                    .Cells[2].Value.ToString()
                );

            cboTrangThai.Text =
                dgvPhieuNhap.Rows[e.RowIndex]
                .Cells[3].Value.ToString();

            txtTongTien.Text =
                dgvPhieuNhap.Rows[e.RowIndex]
                .Cells[4].Value.ToString();
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.CurrentRow == null)
            {
                return;
            }

            int index =
                dgvPhieuNhap.CurrentRow.Index;

            dsPhieuNhap[index].MaPN =
                txtMaPN.Text.Trim();

            dsPhieuNhap[index].MaNCC =
                txtNCC.Text.Trim();

            dsPhieuNhap[index].NgayNhap =
                dtNgayNhap.Value;

            dsPhieuNhap[index].TrangThai =
                cboTrangThai.Text;

            dsPhieuNhap[index].TongTien =
                double.Parse(txtTongTien.Text);

            repo.Save(dsPhieuNhap);

            HienThiDanhSach();

            MessageBox.Show(
                "Sửa thành công!"
            );
        }

        private void txtSearchPN_TextChanged(object sender, EventArgs e)
        {
            string keyword =
       txtSearchPN.Text.Trim().ToLower();

            dgvPhieuNhap.Rows.Clear();

            foreach (PhieuNhap pn in dsPhieuNhap)
            {
                if (
                    pn.MaPN.ToLower()
                    .Contains(keyword)
                )
                {
                    dgvPhieuNhap.Rows.Add(
                        pn.MaPN,
                        pn.MaNCC,
                        pn.NgayNhap.ToShortDateString(),
                        pn.TrangThai,
                        pn.TongTien
                    );
                }
            }
        }
    }
}
