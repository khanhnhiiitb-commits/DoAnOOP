// ============================================================
// ucBanHangPanel.cs - Nghiep vu Ban Hang
// ============================================================
// TEN CONTROL trong Designer (giu nguyen khong doi):
//   txtTimKiem  = o tim kiem / quet ma vach
//   btnTimKiem  = nut loc "Dien tu"
//   button1     = nut loc "Tat ca"
//   button2     = nut loc "Thuc pham"
//   textBox1    = o nhap SDT khach hang
//   btnLamMoi   = nut THANH TOAN VA IN BILL
//   Giohang     = label hien thi ten khach
//   label2      = Tam tinh | label3 = Giam gia | label4 = Tong tien
//   panel1      = card SP slot 1 (label9=ten, lbGia=gia, lbTon=ton)
//   panel2      = card SP slot 2 (label6=ten, label5=gia, label1=ton)
//   dgvGioHang  = DataGridView gio hang
// ============================================================

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

        private const string PLACEHOLDER_TIM_KIEM = "Quet ma vach hoac tim ten hang...";
        private const string PLACEHOLDER_SDT = "Nhap SDT khach hang...";

        // ============================================================
        // CONSTRUCTOR
        // ============================================================
        public ucBanHangPanel()
        {
            InitializeComponent();
            KhoiTaoGioHang();
        }

        // ============================================================
        // LOAD
        // ============================================================
        private void ucBanHangPanel_Load(object sender, EventArgs e)
        {
            // 1. Khoi tao service truoc
            _banHangService = new QuanLyBanHang(_db.DanhSachHang);
            _doiTacService = new QuanLyDoiTac();

            for (int i = 0; i < _db.DanhSachKH.Count; i++)
            {
                _doiTacService.ThemKhachHang(_db.DanhSachKH[i]);
            }

            // 2. Tao hoa don moi
            TaoHoaDonMoi();

            // 3. Hien thi danh sach hang len card
            _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
            HienThiCardSanPham(_danhSachHienThi);

            // 4. Gan su kien click card (phai sau HienThiCardSanPham de Tag co du lieu)
            GanClickCard(panel1);
            GanClickCard(panel2);

            // 5. Cac nut loc, thanh toan, grid
            button1.Click += btnTatCa_Click;
            button2.Click += btnThucPham_Click;
            btnTimKiem.Click += btnDienTu_Click;
            btnLamMoi.Click += btnThanhToan_Click;
            dgvGioHang.CellDoubleClick += dgvGioHang_CellDoubleClick;

            // 6. Placeholder SDT
            textBox1.GotFocus += textBox1_GotFocus;
            textBox1.LostFocus += textBox1_LostFocus;
            textBox1.KeyDown += txtSDT_KeyDown;

            // 7. Placeholder tim kiem
            txtTimKiem.GotFocus += txtTimKiem_GotFocus;
            txtTimKiem.LostFocus += txtTimKiem_LostFocus;
        }

        // ============================================================
        // KHOI TAO GIO HANG
        // ============================================================
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
            dgvGioHang.Columns["MaSP"].HeaderText = "Ma SP";
            dgvGioHang.Columns["TenSP"].HeaderText = "Ten san pham";
            dgvGioHang.Columns["DonGia"].HeaderText = "Don gia";
            dgvGioHang.Columns["SoLuong"].HeaderText = "SL";
            dgvGioHang.Columns["ThanhTien"].HeaderText = "Thanh tien";
        }

        // ============================================================
        // TAO HOA DON MOI
        // ============================================================
        private void TaoHoaDonMoi()
        {
            NhanVien nv = _db.NhanVienDangNhap;
            if (nv == null)
            {
                _hoaDonHienTai = new HoaDon("HD_TAM", "NV_TEST", "KH_VANGLAI");
            }
            else
            {
                KhachHang khVangLai = new KhachHang("KH_VANGLAI", "Khach vang lai");
                _hoaDonHienTai = _banHangService.TaoHoaDon(nv, khVangLai);
            }

            _khachHangHienTai = null;
            CapNhatGioHangUI();
            CapNhatTongTienUI();
            Giohang.Text = "Khach hang: Vang lai";
        }

        // ============================================================
        // HIEN THI CARD SAN PHAM (2 slot)
        // ============================================================
        private void HienThiCardSanPham(List<HangHoa> ds)
        {
            // Slot 1: panel1
            if (ds.Count >= 1)
            {
                HangHoa sp1 = ds[0];
                label9.Text = sp1.TenHang;
                lbGia.Text = sp1.DonGia.ToString("N0") + " d";
                lbTon.Text = "Ton: " + sp1.SoLuongTon;
                panel1.Tag = sp1;
            }
            else
            {
                label9.Text = "(Khong co san pham)";
                lbGia.Text = "";
                lbTon.Text = "";
                panel1.Tag = null;
            }

            // Slot 2: panel2
            if (ds.Count >= 2)
            {
                HangHoa sp2 = ds[1];
                label6.Text = sp2.TenHang;
                label5.Text = sp2.DonGia.ToString("N0") + " d";
                label1.Text = "Ton: " + sp2.SoLuongTon;
                panel2.Tag = sp2;
            }
            else
            {
                label6.Text = "(Khong co san pham)";
                label5.Text = "";
                label1.Text = "";
                panel2.Tag = null;
            }
        }

        // ============================================================
        // GAN SU KIEN CLICK CHO CARD
        // WinForms: click label con KHONG bubble len panel cha
        // nen phai gan tay cho tung control con
        // ============================================================
        private void GanClickCard(Panel panel)
        {
            panel.Click += CardClick;
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                panel.Controls[i].Click += CardClick;
            }
        }

        private void CardClick(object sender, EventArgs e)
        {
            // Tim panel chua control duoc click
            Control ctrl = sender as Control;
            Panel panel = null;

            if (ctrl is Panel)
            {
                panel = ctrl as Panel;
            }
            else if (ctrl != null && ctrl.Parent is Panel)
            {
                panel = ctrl.Parent as Panel;
            }

            if (panel == null) return;

            HangHoa sp = panel.Tag as HangHoa;
            if (sp != null)
            {
                ThemSanPhamVaoGio(sp, 1);
            }
        }

        // ============================================================
        // TIM KIEM / QUET MA VACH
        // ============================================================
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa) || tuKhoa == PLACEHOLDER_TIM_KIEM)
            {
                _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
                HienThiCardSanPham(_danhSachHienThi);
                return;
            }

            string tuKhoaLower = tuKhoa.ToLower();
            List<HangHoa> ketQua = new List<HangHoa>();

            for (int i = 0; i < _db.DanhSachHang.Count; i++)
            {
                HangHoa h = _db.DanhSachHang[i];
                if (h.MaHH.ToLower().Contains(tuKhoaLower)
                    || h.TenHang.ToLower().Contains(tuKhoaLower))
                {
                    ketQua.Add(h);
                }
            }

            _danhSachHienThi = ketQua;
            HienThiCardSanPham(_danhSachHienThi);

            // Quet ma vach khop dung 1 SP → tu dong them gio
            if (_danhSachHienThi.Count == 1 && tuKhoa.Length >= 4)
            {
                ThemSanPhamVaoGio(_danhSachHienThi[0], 1);
                txtTimKiem.Clear();
            }
        }

        // ============================================================
        // LOC LOAI HANG
        // ============================================================
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
            HienThiCardSanPham(_danhSachHienThi);
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
            HienThiCardSanPham(_danhSachHienThi);
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
            HienThiCardSanPham(_danhSachHienThi);
        }

        // ============================================================
        // THEM SAN PHAM VAO GIO
        // ============================================================
        private void ThemSanPhamVaoGio(HangHoa sp, int soLuong)
        {
            if (_hoaDonHienTai == null)
            {
                MessageBox.Show("Chua co hoa don!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ketQua = _banHangService.ThemChiTietHoaDon(_hoaDonHienTai, sp, soLuong);

            if (ketQua.StartsWith("L"))
            {
                // bat dau bang "L" = "Lỗi" hoac "Loi"
                MessageBox.Show(ketQua, "Khong the them",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CapNhatGioHangUI();
            CapNhatTongTienUI();
            HienThiCardSanPham(_danhSachHienThi);
        }

        // ============================================================
        // XOA DONG TRONG GIO (double-click)
        // ============================================================
        private void dgvGioHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maSP = "";
            if (dgvGioHang.Rows[e.RowIndex].Cells["MaSP"].Value != null)
                maSP = dgvGioHang.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();

            if (string.IsNullOrEmpty(maSP)) return;

            DialogResult confirm = MessageBox.Show(
                "Xoa [" + maSP + "] khoi gio hang?",
                "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _banHangService.XoaChiTietHoaDon(_hoaDonHienTai, maSP);
                CapNhatGioHangUI();
                CapNhatTongTienUI();
                HienThiCardSanPham(_danhSachHienThi);
            }
        }

        // ============================================================
        // CAP NHAT GIO HANG UI
        // ============================================================
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

                dtGioHang.Rows.Add(
                    ct.MaHH,
                    tenHang,
                    (decimal)ct.GiaBan,
                    ct.SoLuongMua,
                    (decimal)ct.ThanhTien);
            }

            DatTieuDeCot();
        }

        // ============================================================
        // CAP NHAT TONG TIEN UI
        // ============================================================
        private void CapNhatTongTienUI()
        {
            if (_hoaDonHienTai == null) return;

            double tong = _hoaDonHienTai.TongTien;
            label2.Text = "Tam tinh: " + tong.ToString("N0") + " d";
            label4.Text = "Tong tien: " + tong.ToString("N0") + " d";

            if (!_hoaDonHienTai.DaApDungVoucher)
                label3.Text = "Giam gia/Voucher: 0 d";
        }

        // ============================================================
        // PLACEHOLDER SDT
        // ============================================================
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == PLACEHOLDER_SDT)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = PLACEHOLDER_SDT;
                textBox1.ForeColor = Color.Gray;
            }
        }

        // ============================================================
        // PLACEHOLDER TIM KIEM
        // ============================================================
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

        // ============================================================
        // TIM KHACH QUA SDT (nhan Enter)
        // ============================================================
        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string sdt = textBox1.Text.Trim();
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

                string info = "Khach: " + khTimThay.HoTen
                            + "  |  Diem: " + khTimThay.DiemTichLuy;

                if (khTimThay.TheTV != null)
                    info += "  |  The: " + khTimThay.TheTV.MaThe;

                Giohang.Text = info;
                MessageBox.Show("Tim thay: " + khTimThay.HoTen, "Khach hang",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _khachHangHienTai = null;
                Giohang.Text = "Khong tim thay khach - tinh tien vang lai";
                MessageBox.Show("Khong tim thay SDT nay.", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ============================================================
        // AP DUNG VOUCHER (click label3)
        // ============================================================
        private void label3_Click(object sender, EventArgs e)
        {
            if (_hoaDonHienTai == null || _hoaDonHienTai.DanhSachChiTiet.Count == 0)
            {
                MessageBox.Show("Gio hang dang trong!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_hoaDonHienTai.DaApDungVoucher)
            {
                MessageBox.Show("Da ap dung voucher roi!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maVoucher = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhap ma Voucher:", "Ap dung Voucher", "");

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
                // "Thanh cong"
                double soTienGiam = tongTruoc - _hoaDonHienTai.TongTien;
                label3.Text = "Giam gia/Voucher: -" + soTienGiam.ToString("N0") + " d";
                label4.Text = "Tong tien: " + _hoaDonHienTai.TongTien.ToString("N0") + " d";
                MessageBox.Show(ketQua, "Voucher",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ketQua, "Voucher",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ============================================================
        // THANH TOAN VA IN BILL
        // ============================================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (_hoaDonHienTai == null || _hoaDonHienTai.DanhSachChiTiet.Count == 0)
            {
                MessageBox.Show("Gio hang dang trong!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputTien = Microsoft.VisualBasic.Interaction.InputBox(
                "Tong tien can thanh toan: "
                    + _hoaDonHienTai.TongTien.ToString("N0") + " d"
                    + "\n\nNhap so tien khach dua:",
                "Thanh toan",
                _hoaDonHienTai.TongTien.ToString("F0"));

            if (string.IsNullOrWhiteSpace(inputTien)) return;

            double tienKhachDua = 0;
            bool hopLe = double.TryParse(inputTien, out tienKhachDua);
            if (!hopLe)
            {
                MessageBox.Show("So tien khong hop le!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ketQua = _banHangService.ThanhToan(
                _hoaDonHienTai, tienKhachDua, _khachHangHienTai, _doiTacService);

            if (ketQua == "Khong du tien" || ketQua == "Không đủ tiền")
            {
                MessageBox.Show("Tien khach dua khong du!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tienThua = 0;
            double.TryParse(ketQua, out tienThua);

            _db.DanhSachHD.Add(_hoaDonHienTai);
            LuuDuLieu();

            string bill = _banHangService.LayNoiDungHoaDon(_hoaDonHienTai);
            bill += "\nTien khach dua : " + tienKhachDua.ToString("N0") + " d";
            bill += "\nTien thua      : " + tienThua.ToString("N0") + " d";
            bill += "\n\n   Cam on quy khach! Hen gap lai!";

            MessageBox.Show(bill, "HOA DON - " + _hoaDonHienTai.MaHD,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset giao dien
            TaoHoaDonMoi();
            textBox1.Text = PLACEHOLDER_SDT;
            textBox1.ForeColor = Color.Gray;
            txtTimKiem.Text = PLACEHOLDER_TIM_KIEM;
            txtTimKiem.ForeColor = Color.Gray;
            _danhSachHienThi = new List<HangHoa>(_db.DanhSachHang);
            HienThiCardSanPham(_danhSachHienThi);
        }

        // ============================================================
        // LUU FILE
        // ============================================================
        private void LuuDuLieu()
        {
            try
            {
                SalesRepository repo = new SalesRepository();
                repo.SaveAll(_db.DanhSachHD, _db.DanhSachTheTV, _db.DanhSachVoucher);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi luu du lieu: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // STUB - giu de khong loi bien dich
        // ============================================================
        private void pB1_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void Giohang_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
    }
}