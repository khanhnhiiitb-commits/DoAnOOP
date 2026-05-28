using QuanLySieuThi.Data;
using QuanLySieuThi.Models.Products;
using QuanLySieuThi.Models.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Services;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucReports : UserControl
    {
        private BaoCaoThongKe serviceThongKe;

        public ucReports()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = DatePicker1.Value.Date;
            DateTime denNgay = DatePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn Đến ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            serviceThongKe = new BaoCaoThongKe(DataStorage.Instance.DanhSachHD, DataStorage.Instance.DanhSachHang);
            int tongSoHoaDon;
            double tongDoanhThu;
            string tenMatHangBanChay;
            List<HoaDon> dsHoaDonTrongKy;

            serviceThongKe.LapBaoCaoChiTiet(tuNgay, denNgay, out tongSoHoaDon, out tongDoanhThu, out tenMatHangBanChay, out dsHoaDonTrongKy);

            lblTongHD.Text = tongSoHoaDon.ToString();
            lblTongDT.Text = tongDoanhThu.ToString("N0") + " VNĐ";
            lblMathang.Text = tenMatHangBanChay;

            dgvLichSuGD.DataSource = null;
            DataTable dtHienThi = new DataTable();
            dtHienThi.Columns.Add("MaHD", typeof(string));
            dtHienThi.Columns.Add("NgayTao", typeof(string));
            dtHienThi.Columns.Add("TongTien", typeof(string));
            dtHienThi.Columns.Add("TrangThai", typeof(string));

            foreach (HoaDon hd in dsHoaDonTrongKy)
            {
                dtHienThi.Rows.Add(
                    hd.MaHD,
                    hd.NgayTao.ToString("dd/MM/yyyy HH:mm"),
                    hd.TongTien.ToString("N0"),
                    "Thành công"
                );
            }

            dgvLichSuGD.DataSource = dtHienThi;

            if (dgvLichSuGD.Columns.Count > 0)
            {
                dgvLichSuGD.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                dgvLichSuGD.Columns["NgayTao"].HeaderText = "Thời gian";
                dgvLichSuGD.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvLichSuGD.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvLichSuGD.Columns["MaHD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnXuatBC_Click(object sender, EventArgs e)
        {
            if (dgvLichSuGD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu báo cáo nào để xuất!", "Thông báo");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File (*.txt)|*.txt";
            sfd.Title = "Lưu báo cáo doanh thu";
            sfd.FileName = "BaoCao_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("=========================================================");
                        sw.WriteLine("                BÁO CÁO DOANH THU SIÊU THỊ               ");
                        sw.WriteLine("=========================================================");
                        sw.WriteLine("Từ ngày: " + DatePicker1.Value.ToString("dd/MM/yyyy"));
                        sw.WriteLine("Đến ngày: " + DatePicker2.Value.ToString("dd/MM/yyyy"));
                        sw.WriteLine("Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        sw.WriteLine("---------------------------------------------------------");
                        sw.WriteLine("I. TỔNG QUAN:");
                        sw.WriteLine("- Tổng số hóa đơn     : " + lblTongHD.Text);
                        sw.WriteLine("- Tổng doanh thu      : " + lblTongDT.Text);
                        sw.WriteLine("- Mặt hàng bán chạy   : " + lblMathang.Text);
                        sw.WriteLine("---------------------------------------------------------");
                        sw.WriteLine("II. CHI TIẾT GIAO DỊCH:");
                        sw.WriteLine(string.Format("{0,-15} | {1,-20} | {2,-15}", "Mã Hóa Đơn", "Thời Gian", "Tổng Tiền (VNĐ)"));
                        sw.WriteLine("---------------------------------------------------------");

                        for (int i = 0; i < dgvLichSuGD.Rows.Count; i++)
                        {
                            DataGridViewRow row = dgvLichSuGD.Rows[i];
                            if (!row.IsNewRow)
                            {
                                string maHD = row.Cells["MaHD"].Value != null ? row.Cells["MaHD"].Value.ToString() : "";
                                string thoiGian = row.Cells["NgayTao"].Value != null ? row.Cells["NgayTao"].Value.ToString() : "";
                                string tongTien = row.Cells["TongTien"].Value != null ? row.Cells["TongTien"].Value.ToString() : "0";
                                sw.WriteLine(string.Format("{0,-15} | {1,-20} | {2,-15}", maHD, thoiGian, tongTien));
                            }
                        }
                        sw.WriteLine("=========================================================");
                        sw.WriteLine("                    KẾT THÚC BÁO CÁO                     ");
                    }
                    MessageBox.Show("Xuất báo cáo thành công tại:\n" + sfd.FileName, "Hoàn tất");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình xuất file: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}
