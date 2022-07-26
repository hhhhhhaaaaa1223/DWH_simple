using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 60)
            {
                panelLeft.Width = 200;
            }
            else panelLeft.Width = 60;
        }

        private void btnKhuvuc_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            fLocation f = new fLocation();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Doanh thu,doanh số theo khu vực của 21 quốc gia (USD)";
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            lbNameButton.Text = "";
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            fCategory f = new fCategory();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Doanh thu,doanh số theo danh mục sản phẩm";
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            fEmployee f = new fEmployee();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Doanh thu,doanh số theo nhân viên và nhà cung cấp";
            f.Show();
        }
    }
}
