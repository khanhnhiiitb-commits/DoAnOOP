using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View.Inventory
{
    public partial class ucTonKho : UserControl
    {
        public ucTonKho()
        {
            InitializeComponent();

            inventoryRepo = new InventoryRepository();

            danhSachHang = inventoryRepo.GetAll();

            serviceKho = new QuanLyKho(
                danhSachHang,
                new List<KeHang>()
            );
        }
        private InventoryRepository inventoryRepo;

        private List<HangHoa> danhSachHang;

        private QuanLyKho serviceKho;

        private void ucTonKho_Load(object sender, EventArgs e)
        {
            dgvKho.Rows.Clear();

            CapNhatThongKe();

            
        }
        private void HienThiDanhSach(List<HangHoa> ds)
        {
            dgvKho.Rows.Clear();

            foreach (HangHoa hh in ds)
            {
                string loai = "";

                if (hh is HangDienTu)
                {
                    loai = "Điện tử";
                }

                if (hh is HangThucPham)
                {
                    loai = "Thực phẩm";
                }

                string trangThai = "Còn hàng";

                if (hh.SoLuongTon < 10)
                {
                    trangThai = "Sắp hết";
                }

                int rowIndex = dgvKho.Rows.Add(
                    hh.MaHH,
                    hh.TenHang,
                    loai,
                    hh.SoLuongTon,
                    hh.MaKeHang,
                    trangThai
                );

                if (hh.SoLuongTon < 10)
                {
                    dgvKho.Rows[rowIndex]
                        .DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void CapNhatThongKe()
        {
            //TÍNH TỔNG SKU
            int tongSKU = danhSachHang.Count;

            lblTongSKU.Text = tongSKU.ToString();
            //TÍNH HÀNG SẮP HẾT
            int sapHet = 0;

            foreach (HangHoa hh in danhSachHang)
            {
                if (hh.SoLuongTon < 10)
                {
                    sapHet++;
                }
            }

            lblSapHet.Text = sapHet.ToString();
            //TÍNH TỔNG GIÁ TRỊ KHO
            double tongGiaTri = 0;

            foreach (HangHoa hh in danhSachHang)
            {
                tongGiaTri =
                    tongGiaTri +
                    (hh.DonGia * hh.SoLuongTon);
            }

            lblTongGiaTri.Text =
                tongGiaTri.ToString("N0") + " VNĐ";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            string keyword = txtSearch.Text.Trim();

            if (keyword == "")
            {
                HienThiDanhSach(danhSachHang);
            }
            else
            {
                List<HangHoa> ketQua =
                    serviceKho.TimKiemHangHoa(keyword);

                HienThiDanhSach(ketQua);
            }
        }

        private void btnSearchTonKho_Click(object sender, EventArgs e)
        {
            string keyword =
       txtSearch.Text.Trim();

            if (keyword == "")
            {
                HienThiDanhSach(danhSachHang);

                MessageBox.Show(
                    "Vui lòng nhập từ khóa tìm kiếm!"
                );

                return;
            }

            List<HangHoa> ketQua =
                serviceKho.TimKiemHangHoa(keyword);

            HienThiDanhSach(ketQua);

            if (ketQua.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy sản phẩm!"
                );
            }
        }

        private void btnLoadTonKho_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryRepo =
                    new InventoryRepository();

                danhSachHang =
                    inventoryRepo.GetAll();

               

                HienThiDanhSach(danhSachHang);

                CapNhatThongKe();

                MessageBox.Show(
                    "Load dữ liệu thành công!"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load dữ liệu: "
                    + ex.Message
                );
            }
        }
    }
}
