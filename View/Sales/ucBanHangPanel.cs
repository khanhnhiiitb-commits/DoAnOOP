using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.People;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi
{
    public partial class ucBanHangPanel : UserControl
    {
        private DataTable dtGioHang = new DataTable();

        private DataStorage _db = DataStorage.Instance;
        private QuanLyBanHang _banHangService;
        private QuanLyDoiTac _doiTacService;

        private HoaDon _hoaDonHienTai;
        private KhachHang _khachHangHienTai;
        private List<HangHoa> _danhSachHienThi;

        private const string PLACEHOLDER_TIM_KIEM = "Quét mã vạch hoặc tìm tên hàng...";
        private const string PLACEHOLDER_SDT = "Nhập SĐT khách hàng...";

        public ucBanHangPanel()
        {
            InitializeComponent();
            KhoiTaoGioHang();
            KhoiTaoGridSanPham();
        }

        private void ucBanHangPanel_Load(object sender, EventArgs e)
        {
            if (DataStorage.Instance.NhanVienDangNhap != null)
            {

                label1.Text = "Thu ngân: " + DataStorage.Instance.NhanVienDangNhap.HoTen;
            }
            else
            {
                label1.Text = "Xin chào, Thu ngân ẩn danh!";
            }
            _banHangService = new QuanLyBanHang(_db.DanhSachHang, _db.DanhSachHD);
            _doiTacService = new QuanLyDoiTac();

            for (int i = 0; i < _db.DanhSachKH.Count; i++)
            {
                _doiTacService.ThemKhachHang(_db.DanhSachKH[i]);
            }

            TaoHoaDonMoi();

            _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
            HienThiDanhSachSanPham(_danhSachHienThi);

            // Gán các sự kiện cho đúng tên mới
            dgvSanPham.CellDoubleClick += dgvSanPham_CellDoubleClick;
            dgvGioHang.CellDoubleClick += dgvGioHang_CellDoubleClick;

            btnTatCa.Click += btnTatCa_Click;
            btnDienTu.Click += btnDienTu_Click;
            btnThucPham.Click += btnThucPham_Click;
            btnThanhToan.Click += btnThanhToan_Click;

            txtTimKH.GotFocus += txtTimKH_GotFocus;
            txtTimKH.LostFocus += txtTimKH_LostFocus;
            txtTimKH.KeyDown += txtTimKH_KeyDown;

            txtTimKiem.GotFocus += txtTimKiem_GotFocus;
            txtTimKiem.LostFocus += txtTimKiem_LostFocus;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
        }


        private void KhoiTaoGridSanPham()
        {
            dgvSanPham.Columns.Clear();
            dgvSanPham.Columns.Add("MaSP", "Mã SP");
            dgvSanPham.Columns.Add("TenSP", "Tên sản phẩm");
            dgvSanPham.Columns.Add("Gia", "Giá bán");
            dgvSanPham.Columns.Add("Ton", "Tồn kho");

            dgvSanPham.ReadOnly = true;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HienThiDanhSachSanPham(List<HangHoa> ds)
        {
            dgvSanPham.Rows.Clear();
            foreach (var sp in ds)
            {
                dgvSanPham.Rows.Add(sp.MaHH, sp.TenHang, sp.DonGia.ToString("N0") + " đ", sp.SoLuongTon);
            }
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

        private void DatTieuDeCot()
        {
            if (dgvGioHang.Columns.Count < 5) return;
            dgvGioHang.Columns["MaSP"].HeaderText = "Mã SP";
            dgvGioHang.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvGioHang.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvGioHang.Columns["SoLuong"].HeaderText = "SL";
            dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }


        private void btnTatCa_Click(object sender, EventArgs e)
        {
            _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
            HienThiDanhSachSanPham(_danhSachHienThi);
        }

        private void btnDienTu_Click(object sender, EventArgs e)
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            for (int i = 0; i < _db.DanhSachHang.Count; i++)
            {
                if (_db.DanhSachHang[i] is HangDienTu)
                    ketQua.Add(_db.DanhSachHang[i]);
            }
            _danhSachHienThi = ketQua;
            HienThiDanhSachSanPham(_danhSachHienThi);
        }

        private void btnThucPham_Click(object sender, EventArgs e)
        {
            List<HangHoa> ketQua = new List<HangHoa>();
            for (int i = 0; i < _db.DanhSachHang.Count; i++)
            {
                if (_db.DanhSachHang[i] is HangThucPham)
                    ketQua.Add(_db.DanhSachHang[i]);
            }
            _danhSachHienThi = ketQua;
            HienThiDanhSachSanPham(_danhSachHienThi);
        }


        private void txtTimKH_GotFocus(object sender, EventArgs e)
        {
            if (txtTimKH.Text == PLACEHOLDER_SDT)
            {
                txtTimKH.Text = "";
                txtTimKH.ForeColor = Color.Black;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void pB1_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void Giohang_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void btnLamMoi_Click(object sender, EventArgs e) { }
        private void txtTimKH_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKH.Text))
            {
                txtTimKH.Text = PLACEHOLDER_SDT;
                txtTimKH.ForeColor = Color.Gray;
            }
        }

        private void txtTimKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string sdt = txtTimKH.Text.Trim();
            if (string.IsNullOrEmpty(sdt) || sdt == PLACEHOLDER_SDT) return;

            KhachHang khTimThay = null;
            for (int i = 0; i < _db.DanhSachKH.Count; i++)
            {
                if (_db.DanhSachKH[i].SoDienThoai == sdt)
                {
                    khTimThay = _db.DanhSachKH[i];
                    break;
                }
            }

            if (khTimThay != null)
            {
                _khachHangHienTai = khTimThay;
                _hoaDonHienTai.MaKH = khTimThay.MaKH;

                string info = "Khách: " + khTimThay.HoTen + "  |  Điểm: " + khTimThay.DiemTichLuy;
                if (khTimThay.TheTV != null) info += "  |  Thẻ: " + khTimThay.TheTV.MaThe;

                Giohang.Text = info; // Nhớ đảm bảo có Label tên Giohang trên form
                MessageBox.Show("Tìm thấy: " + khTimThay.HoTen, "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _khachHangHienTai = null;
                Giohang.Text = "Không tìm thấy khách - tính tiền vãng lai";
                MessageBox.Show("Không tìm thấy SĐT này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtTimKiem_GotFocus(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == PLACEHOLDER_TIM_KIEM)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = PLACEHOLDER_TIM_KIEM;
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa) || tuKhoa == PLACEHOLDER_TIM_KIEM)
            {
                _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
                HienThiDanhSachSanPham(_danhSachHienThi);
                return;
            }

            string tuKhoaLower = tuKhoa.ToLower();
            List<HangHoa> ketQua = new List<HangHoa>();

            for (int i = 0; i < _db.DanhSachHang.Count; i++)
            {
                HangHoa h = _db.DanhSachHang[i];
                if (h.MaHH.ToLower().Contains(tuKhoaLower) || h.TenHang.ToLower().Contains(tuKhoaLower))
                {
                    ketQua.Add(h);
                }
            }

            _danhSachHienThi = ketQua;
            HienThiDanhSachSanPham(_danhSachHienThi);


            if (_danhSachHienThi.Count == 1 && tuKhoa.Length >= 4)
            {
                ThemSanPhamVaoGio(_danhSachHienThi[0], 1);
                txtTimKiem.Clear();
            }
        }


        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvSanPham.Rows[e.RowIndex].IsNewRow) return;

            string maSP = dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();

            HangHoa spChon = null;
            foreach (var sp in _db.DanhSachHang)
            {
                if (sp.MaHH == maSP)
                {
                    spChon = sp;
                    break;
                }
            }

            if (spChon != null) ThemSanPhamVaoGio(spChon, 1);
        }

        private void ThemSanPhamVaoGio(HangHoa sp, int soLuong)
        {
            if (_hoaDonHienTai == null) return;

            string ketQua = _banHangService.ThemChiTietHoaDon(_hoaDonHienTai, sp, soLuong);

            if (ketQua.StartsWith("L"))
            {
                MessageBox.Show(ketQua, "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapNhatGioHangUI();
            CapNhatTongTienUI();
            HienThiDanhSachSanPham(_danhSachHienThi);
        }

        private void dgvGioHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maSP = dgvGioHang.Rows[e.RowIndex].Cells["MaSP"].Value?.ToString();
            if (string.IsNullOrEmpty(maSP)) return;

            DialogResult confirm = MessageBox.Show($"Xóa [{maSP}] khỏi giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _banHangService.XoaChiTietHoaDon(_hoaDonHienTai, maSP);
                CapNhatGioHangUI();
                CapNhatTongTienUI();
                HienThiDanhSachSanPham(_danhSachHienThi);
            }
        }

        private void TaoHoaDonMoi()
        {
            NhanVien nv = _db.NhanVienDangNhap;
            if (nv == null)
            {
                _hoaDonHienTai = new HoaDon("HD_TAM", "NV_TEST", "KH_VANGLAI");
            }
            else
            {
                KhachHang khVangLai = new KhachHang("KH_VANGLAI", "Khách vãng lai");
                _hoaDonHienTai = _banHangService.TaoHoaDon(nv, khVangLai);
            }

            _khachHangHienTai = null;
            CapNhatGioHangUI();
            CapNhatTongTienUI();
            Giohang.Text = "Khách hàng: Vãng lai";
        }

        private void CapNhatGioHangUI()
        {
            dtGioHang.Rows.Clear();
            if (_hoaDonHienTai == null) return;

            List<ChiTietHoaDon> dsCT = _hoaDonHienTai.DanhSachChiTiet;
            for (int i = 0; i < dsCT.Count; i++)
            {
                ChiTietHoaDon ct = dsCT[i];

                string tenHang = ct.MaHH;
                for (int j = 0; j < _db.DanhSachHang.Count; j++)
                {
                    if (_db.DanhSachHang[j].MaHH == ct.MaHH)
                    {
                        tenHang = _db.DanhSachHang[j].TenHang;
                        break;
                    }
                }

                dtGioHang.Rows.Add(ct.MaHH, tenHang, (decimal)ct.GiaBan, ct.SoLuongMua, (decimal)ct.ThanhTien);
            }
            DatTieuDeCot();
        }

        private void CapNhatTongTienUI()
        {
            if (_hoaDonHienTai == null) return;

            double tong = _hoaDonHienTai.TongTien;
            label2.Text = "Tạm tính: " + tong.ToString("N0") + " đ";
            label4.Text = "Tổng tiền: " + tong.ToString("N0") + " đ";

            if (!_hoaDonHienTai.DaApDungVoucher)
                label3.Text = "Giảm giá/Voucher: 0 đ";
        }

        // ============================================================
        // THANH TOÁN (btnThanhToan)
        // ============================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (_hoaDonHienTai == null || _hoaDonHienTai.DanhSachChiTiet.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputTien = Microsoft.VisualBasic.Interaction.InputBox(
                "Tổng tiền cần thanh toán: " + _hoaDonHienTai.TongTien.ToString("N0") + " đ" + "\n\nNhập số tiền khách đưa:",
                "Thanh toán", _hoaDonHienTai.TongTien.ToString("F0"));

            if (string.IsNullOrWhiteSpace(inputTien)) return;

            double tienKhachDua = 0;
            bool hopLe = double.TryParse(inputTien, out tienKhachDua);
            if (!hopLe)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ketQua = _banHangService.ThanhToan(_hoaDonHienTai, tienKhachDua, _khachHangHienTai, _doiTacService);

            if (ketQua == "Khong du tien" || ketQua == "Không đủ tiền")
            {
                MessageBox.Show("Tiền khách đưa không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tienThua = 0;
            double.TryParse(ketQua, out tienThua);

            _db.DanhSachHD.Add(_hoaDonHienTai);
            LuuDuLieu();

            string bill = _banHangService.LayNoiDungHoaDon(_hoaDonHienTai);
            bill += "\nTiền khách đưa : " + tienKhachDua.ToString("N0") + " đ";
            bill += "\nTiền thừa      : " + tienThua.ToString("N0") + " đ";
            bill += "\n\n   Cảm ơn quý khách! Hẹn gặp lại!";

            MessageBox.Show(bill, "HÓA ĐƠN - " + _hoaDonHienTai.MaHD, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI sau khi thanh toán xong
            TaoHoaDonMoi();
            txtTimKH.Text = PLACEHOLDER_SDT;
            txtTimKH.ForeColor = Color.Gray;
            txtTimKiem.Text = PLACEHOLDER_TIM_KIEM;
            txtTimKiem.ForeColor = Color.Gray;
            _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
            HienThiDanhSachSanPham(_danhSachHienThi);
        }

        private void LuuDuLieu()
        {
            try
            {
                SalesRepository repo = new SalesRepository();
                repo.SaveAll(_db.DanhSachHD, _db.DanhSachTheTV, _db.DanhSachVoucher);
                InventoryRepository productRepo = new InventoryRepository();
                productRepo.Save(_db.DanhSachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (_hoaDonHienTai == null || _hoaDonHienTai.DanhSachChiTiet.Count == 0) return;
            if (_hoaDonHienTai.DaApDungVoucher)
            {
                MessageBox.Show("Đã áp dụng voucher rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maVoucher = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã Voucher:", "Áp dụng Voucher", "");
            if (string.IsNullOrWhiteSpace(maVoucher)) return;

            Voucher voucher = null;
            for (int i = 0; i < _db.DanhSachVoucher.Count; i++)
            {
                if (_db.DanhSachVoucher[i].MaVoucher.ToUpper() == maVoucher.ToUpper())
                {
                    voucher = _db.DanhSachVoucher[i];
                    break;
                }
            }

            double tongTruoc = _hoaDonHienTai.TongTien;
            string ketQua = _banHangService.ApDungVoucher(_hoaDonHienTai, voucher);

            if (ketQua.StartsWith("Th"))
            {
                double soTienGiam = tongTruoc - _hoaDonHienTai.TongTien;
                label3.Text = "Giảm giá/Voucher: -" + soTienGiam.ToString("N0") + " đ";
                label4.Text = "Tổng tiền: " + _hoaDonHienTai.TongTien.ToString("N0") + " đ";
                MessageBox.Show(ketQua, "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ketQua, "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {

                Application.Restart();
            }
        }
    }
}