using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Sales;
using QuanLySieuThi.Models.Systems;
using QuanLySieuThi.Services;
using QuanLySieuThi.DataAccess; 

namespace ChuongtrinhQuanlybanhangsieuthi.View.Admin
{
    public partial class ucKM : UserControl
    {
        QuanLyKhuyenMai serviceKM = new QuanLyKhuyenMai(
            DataStorage.Instance.DanhSachKhuyenMai,
            DataStorage.Instance.DanhSachVoucher
        );
        VoucherRepository voucherRepo = new VoucherRepository();

        public ucKM()
        {
            InitializeComponent();
        }


        private void ucKM_Load(object sender, EventArgs e)
        {
            // 1. Nạp dữ liệu từ File lên RAM và hiển thị bảng (code cũ)
            DataStorage.Instance.DanhSachVoucher = voucherRepo.GetAll();
            HienThiLenBang();

            // 2. Thêm lựa chọn cho ComboBox Mức giảm
            cbLoaiGiam.Items.Clear(); // Xóa dữ liệu rác nếu có
            cbLoaiGiam.Items.Add("%");
            cbLoaiGiam.Items.Add("VNĐ");

            // 3. Cho nó chọn sẵn dòng đầu tiên (%) để ô không bị trống
            if (cbLoaiGiam.Items.Count > 0)
            {
                cbLoaiGiam.SelectedIndex = 0;
            }
        }

        private void HienThiLenBang()
        {
            dgvKM.DataSource = null;
            var dsHienThi = new List<object>();

            foreach (Voucher v in serviceKM.LayDanhSachVoucher())
            {
                string chuoiMucGiam = "";
                if (v is VoucherTienMat vTm)
                {
                    chuoiMucGiam = vTm.SoTienGiamCoDinh.ToString("N0") + " VNĐ";
                }
                else if (v is VoucherPhanTram vPt)
                {
                    chuoiMucGiam = vPt.PhanTramGiam.ToString() + " %";
                }

                dsHienThi.Add(new
                {
                    MaKM = v.MaVoucher,
                    TenKM = v.TenVoucher,
                    MucGiam = chuoiMucGiam,
                    TuNgay = v.NgayBatDau,
                    DenNgay = v.NgayKetThuc,
                    TrangThai = v.TrangThai ? "Đang hoạt động" : "Đã vô hiệu hóa"
                });
            }

            dgvKM.DataSource = dsHienThi;
        }

        private void btnDoiTrangThai_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem có chọn dòng chưa, và dòng đó CÓ PHẢI LÀ DÒNG TRỐNG cuối cùng không
                if (dgvKM.CurrentRow == null || dgvKM.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Vui lòng chọn một Voucher hợp lệ từ bảng!");
                    return;
                }

                // 2. Lấy mã an toàn (kiểm tra null trước khi biến thành String)
                var cellValue = dgvKM.CurrentRow.Cells["MaKM"].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("Dòng được chọn không có Mã Voucher!");
                    return;
                }
                string maDaChon = cellValue.ToString();

                // 3. Dùng trực tiếp biến serviceKM đã khai báo ở tít trên đầu Class
                // (Xóa dòng new QuanLyKhuyenMai... cũ đi để tránh dư thừa và lỗi đồng bộ)
                bool thanhCong = serviceKM.DoiTrangThaiVoucher(maDaChon);

                if (thanhCong)
                {
                    // Lưu xuống File txt
                    voucherRepo.Save(DataStorage.Instance.DanhSachVoucher);

                    // Cập nhật lại giao diện
                    HienThiLenBang();

                    MessageBox.Show("Đã thay đổi trạng thái Voucher thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Voucher trong hệ thống để đổi trạng thái!");
                }
            }
            catch (ArgumentException)
            {
                // Lỗi này xảy ra nếu DataGridView của Nhi thiết kế tay và đặt tên cột khác với "MaKM"
                MessageBox.Show("Lỗi: Không tìm thấy cột 'MaKM' trong bảng. Hãy kiểm tra lại tên cột (Name) trong phần Design của DataGridView nhé!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatePicker2.Value.Date < DatePicker1.Value.Date)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi nhập liệu");
                    return;
                }

                string loaiGiam = cbLoaiGiam.Text;
                double mucGiam = double.Parse(txtMucGiam.Text);
                Voucher vMoi = null;

                if (loaiGiam == "%")
                {
                    VoucherPhanTram vPt = new VoucherPhanTram();
                    vPt.PhanTramGiam = (float)mucGiam;
                    vPt.GiamToiDa = 500000;
                    vMoi = vPt;
                }
                else
                {
                    VoucherTienMat vTm = new VoucherTienMat();
                    vTm.SoTienGiamCoDinh = mucGiam;
                    vMoi = vTm;
                }

                vMoi.MaVoucher = txtMaKM.Text.Trim();
                vMoi.TenVoucher = txtTenKM.Text.Trim();
                vMoi.NgayBatDau = DatePicker1.Value.Date;
                vMoi.NgayKetThuc = DatePicker2.Value.Date;
                vMoi.TrangThai = true;

                serviceKM.ThemVoucher(vMoi);

                // BỔ SUNG 5: Lưu Voucher mới tạo xuống File
                voucherRepo.Save(DataStorage.Instance.DanhSachVoucher);

                HienThiLenBang();
                MessageBox.Show("Tạo Voucher thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: Vui lòng nhập số cho mức giảm. " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}