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
    public partial class ucKhoPanel : UserControl
    {
        public ucKhoPanel()
        {
            InitializeComponent();
        }

        // Gán sự kiện cho button
        private void GanSuKien()
        {
            btnThem.Click += btnThem_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnXoa.Click += btnXoa_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnTonKho.Click += btnTonKho_Click;
        }

        // Hàm load panel
        private void LoadPanel(Control control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadPanel(CreateFormThem());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadPanel(CreateFormThem());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoadPanel(CreateDanhSach());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadPanel(CreateDanhSach());
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            LoadPanel(CreateDanhSach());
        }
        // ====== UI HIỂN THỊ ======

        // Form nhập liệu (panel)
        private Panel CreateFormThem()
        {
            Panel p = new Panel();

            Label lbl = new Label()
            {
                Text = "THÊM / CẬP NHẬT HÀNG",
                Top = 20,
                Left = 20,
                AutoSize = true
            };

            TextBox txtTen = new TextBox() { PlaceholderText = "Tên hàng", Top = 60, Left = 20, Width = 200 };
            TextBox txtGia = new TextBox() { PlaceholderText = "Giá", Top = 100, Left = 20, Width = 200 };
            TextBox txtSL = new TextBox() { PlaceholderText = "Số lượng", Top = 140, Left = 20, Width = 200 };

            Button btnSave = new Button()
            {
                Text = "Lưu",
                Top = 180,
                Left = 20,
                Width = 100
            };

            btnSave.Click += (s, e) =>
            {
                MessageBox.Show("Đã lưu (demo)");
            };

            p.Controls.Add(lbl);
            p.Controls.Add(txtTen);
            p.Controls.Add(txtGia);
            p.Controls.Add(txtSL);
            p.Controls.Add(btnSave);

            return p;
        }

        // Danh sách hàng (dùng panel)
        private FlowLayoutPanel CreateDanhSach()
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.AutoScroll = true;

            // fake data
            AddItem(flow, "HH01", "Sữa", 5);
            AddItem(flow, "HH02", "Bánh", 50);
            AddItem(flow, "HH03", "Nước", 2);

            return flow;
        }

        private void AddItem(FlowLayoutPanel flow, string ma, string ten, int sl)
        {
            Panel item = new Panel();
            item.Width = 200;
            item.Height = 100;
            item.BorderStyle = BorderStyle.FixedSingle;
            item.Margin = new Padding(10);

            // cảnh báo tồn kho
            if (sl < 10)
                item.BackColor = System.Drawing.Color.LightCoral;
            else
                item.BackColor = System.Drawing.Color.LightGreen;

            Label lblMa = new Label() { Text = "Mã: " + ma, Top = 10, Left = 10 };
            Label lblTen = new Label() { Text = "Tên: " + ten, Top = 30, Left = 10 };
            Label lblSL = new Label() { Text = "SL: " + sl, Top = 50, Left = 10 };

            Button btnXoa = new Button() { Text = "Xóa", Top = 70, Left = 10, Width = 60 };

            btnXoa.Click += (s, e) =>
            {
                flow.Controls.Remove(item);
            };

            item.Controls.Add(lblMa);
            item.Controls.Add(lblTen);
            item.Controls.Add(lblSL);
            item.Controls.Add(btnXoa);

            flow.Controls.Add(item);
        }
    }
}

