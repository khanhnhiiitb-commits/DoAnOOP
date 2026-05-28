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

            repo = new PhieuNhapRepository();

            dsPhieuNhap = repo.GetAll();

            inventoryRepo = new InventoryRepository();

            dsHangHoa = inventoryRepo.GetAll();

            serviceKho = new QuanLyKho(dsHangHoa, new List<KeHang>());

            serviceNhapHang = new QuanLyNhapHang(dsPhieuNhap);
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
                NhaCungCap ncc = new NhaCungCap();

                ncc.MaNCC = txtNCC.Text.Trim();

                // LẬP PHIẾU NHẬP
                PhieuNhap pn = serviceNhapHang.LapPhieuNhap(ncc);

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
                serviceNhapHang.ThemChiTietPhieuNhap(pn, hangDuocChon,
                        int.Parse(txtSoLuongNhap.Text),
                        double.Parse(txtDonGiaNhap.Text));

                // XÁC NHẬN NHẬP KHO
                serviceNhapHang.XacNhanNhapKho(pn, serviceKho);

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
            // Bỏ qua nếu click vào tiêu đề cột hoặc click vào dòng trắng cuối cùng
            if (e.RowIndex < 0 || dgvPhieuNhap.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            // Tạo biến row cho ngắn gọn, dễ gõ
            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

            // ==============================================================
            // VIỆC 1: ĐỔ DỮ LIỆU LÊN CÁC TEXTBOX (Code của Nhi)
            // ==============================================================
            // Dùng dấu "?" trước ToString() để an toàn, lỡ ô đó rỗng thì phần mềm không bị văng lỗi
            txtMaPN.Text = row.Cells[0].Value?.ToString();
            txtNCC.Text = row.Cells[1].Value?.ToString();

            // An toàn hơn khi Parse ngày tháng
            if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime ngayNhap))
            {
                dtNgayNhap.Value = ngayNhap;
            }

            cboTrangThai.Text = row.Cells[3].Value?.ToString();
            txtTongTien.Text = row.Cells[4].Value?.ToString();

            // ==============================================================
            // VIỆC 2: TẢI DANH SÁCH MẶT HÀNG XUỐNG BẢNG 2 (dgvChiTietPhieuNhap)
            // ==============================================================
            string maDuocChon = txtMaPN.Text; // Lấy luôn cái mã PN vừa nạp vào TextBox

            dgvChiTietPhieuNhap.Rows.Clear(); // Xóa sạch mặt hàng của phiếu cũ

            // Tìm phiếu nhập này trong Kho RAM (Giả sử Nhi đang dùng list dsPhieuNhap)
            foreach (PhieuNhap p in dsPhieuNhap)
            {
                if (p.MaPN == maDuocChon)
                {
                    // Nếu tìm thấy, móc cái ruột (DanhSachChiTiet) ra đổ vào Bảng 2
                    foreach (ChiTietPhieuNhap ctpn in p.DanhSachChiTiet)
                    {
                        dgvChiTietPhieuNhap.Rows.Add(
                            ctpn.MaHH,
                            ctpn.SoLuong,
                            ctpn.DonGia.ToString("N0"),
                            (ctpn.SoLuong * ctpn.DonGia).ToString("N0") // Thành tiền = Số lượng * Đơn giá
                        );
                    }
                    break; // Đổ xong rồi thì thoát vòng lặp cho nhẹ máy
                }
            }
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
            // sửa thử nghiệm 
            dsPhieuNhap[index].TinhTongTien(); 

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
