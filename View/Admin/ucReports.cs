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
using QuanLySieuThi.Models.Sales;

namespace ChuongtrinhQuanlybanhangsieuthi.View
{
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {

            // Từ ngày: Lấy mốc 00:00:00
            DateTime tuNgay = DatePicker1.Value.Date;


            DateTime denNgay = DatePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn Đến ngày!");
                return;
            }

            int tongSoHoaDon = 0;
            double tongDoanhThu = 0;
            List<HoaDon> dsHoaDonTrongKy = new List<HoaDon>();
            Dictionary<string, int> boDemSanPham = new Dictionary<string, int>();


            foreach (var hd in DataStorage.Instance.DanhSachHD)
            {
                if (hd.NgayTao >= tuNgay && hd.NgayTao <= denNgay && hd.TrangThaiTT == true)
                {
                    tongSoHoaDon++;
                    tongDoanhThu += hd.TongTien;
                    dsHoaDonTrongKy.Add(hd);
                    foreach (var ct in hd.DanhSachChiTiet)
                    {
                        if (boDemSanPham.ContainsKey(ct.MaHH))
                        {
                            boDemSanPham[ct.MaHH] += ct.SoLuongMua;
                        }
                        else
                        {
                            boDemSanPham.Add(ct.MaHH, ct.SoLuongMua);
                        }
                    }
                }
            }
            string maBanChayNhat = "";
            int maxSoLuong = 0;

            foreach (var item in boDemSanPham)
            {
                if (item.Value > maxSoLuong)
                {
                    maxSoLuong = item.Value;
                    maBanChayNhat = item.Key;
                }
            }
            string tenMatHangBanChay = "Chưa có dữ liệu";
            if (maxSoLuong > 0)
            {
                foreach (var hh in DataStorage.Instance.DanhSachHang)
                {
                    if (hh.MaHH == maBanChayNhat)
                    {
                        tenMatHangBanChay = hh.TenHang;
                        break;
                    }
                }
            }
            lblTongHD.Text = tongSoHoaDon.ToString();
            lblTongDT.Text = tongDoanhThu.ToString("N0") + " VNĐ";
            lblMathang.Text = tenMatHangBanChay;
            dgvLichSuGD.DataSource = null;
            var dsHienThi = new List<object>();

            foreach (var hd in dsHoaDonTrongKy)
            {
                dsHienThi.Add(new
                {
                    MaHD = hd.MaHD,
                    NgayTao = hd.NgayTao.ToString("dd/MM/yyyy HH:mm"),
                    TongTien = hd.TongTien.ToString("N0"),
                    TrangThai = "Thành công"
                });
            }

            dgvLichSuGD.DataSource = dsHienThi;

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
                            var row = dgvLichSuGD.Rows[i];

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
