using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace chart
{
    public partial class fEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SaleDWH;Integrated Security=True");
        public fEmployee()
        {
            InitializeComponent();
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            pie_chart_nv("select * from v_phantramdoanhthu", "Doanh Thu");
            par_chart_nv("select * from v_tongsanphamnv", "Doanh Số");
            List<string> countries = new List<string>() { "1", "2" };
            line_chart("1996", countries);
            dumpDataIntoCombobox();//danh sách năm
            dumpDataIntoCheckListBox();//danh sách tên quốc gia
            clBCountry.SetItemChecked(3, true);
            clBCountry.SetItemChecked(4, true);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void pie_chart(string query, string titleY)
        {
            SqlDataAdapter ad2 = new SqlDataAdapter(query, con);
            DataTable dt2 = new DataTable();
            ad2.Fill(dt2);
            chart1.DataSource = dt2;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "id nhân viên";

            //format chart 
            chart1.Series["Series1"].YValueMembers = "PhanTram";//lấy tên thuột tính từ DB
            chart1.Series["Series1"].XValueMember = "SupplierID";
            chart1.Titles.Clear();
            chart1.Titles.Add("Tỷ lệ " + titleY + " trên sản phẩm");
            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }
        private void pie_chart_nv(string query, string titleY)
        {
            SqlDataAdapter ad2 = new SqlDataAdapter(query, con);
            DataTable dt2 = new DataTable();
            ad2.Fill(dt2);
            chart1.DataSource = dt2;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên nhân viên";

            //format chart 
            chart1.Series["Series1"].YValueMembers = "PhanTram";//lấy tên thuột tính từ DB
            chart1.Series["Series1"].XValueMember = "EmployeeID";
            chart1.Titles.Clear();
            chart1.Titles.Add("Tỷ lệ " + titleY + " trên sản phẩm");
            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private void par_chart(string query, string titleY)
        {
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            chart2.DataSource = dt;
            chart2.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên nhà cung cấp";//label

            //format chart 

            chart2.Series[0].YValueMembers = "total";//tên thuột tính lấy ở DB
            chart2.Series[0].XValueMember = "CompanyName";
            //chart1.Series["Doanh Thu"].IsValueShownAsLabel = true; //hiển thị doanh thu cụ thể ở mỗi nước
            chart2.ChartAreas[0].AxisX.Interval = 1; //khoảng cách label(tên các nước)
            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;//bỏ lưới(grid) ngang
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            // Assign the legend to Series.
            chart2.Series[0].LegendText = titleY;
        }
        private void par_chart_nv(string query, string titleY)
        {
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            chart2.DataSource = dt;
            chart2.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên nhân viên";//label

            //format chart 

            chart2.Series[0].YValueMembers = "Revenue";//tên thuột tính lấy ở DB
            chart2.Series[0].XValueMember = "EmployeeID";
            //chart1.Series["Doanh Thu"].IsValueShownAsLabel = true; //hiển thị doanh thu cụ thể ở mỗi nước
            chart2.ChartAreas[0].AxisX.Interval = 1; //khoảng cách label(tên các nước)
            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;//bỏ lưới(grid) ngang
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            // Assign the legend to Series.
            chart2.Series[0].LegendText = titleY;
        }

        private void line_chart(string year, List<string> countries)
        {
            //xóa Series cũ.
            while (chart3.Series.Count > 0) { chart3.Series.RemoveAt(0); }
            foreach (string country in countries)
            {
                SqlDataAdapter adx = new SqlDataAdapter("select Year, sum(total) as t from v_thangnhacc where Year = " + year + " and EmployeeID = '" + country + "' group by Year", con);
                DataTable dtx = new DataTable();
                adx.Fill(dtx);
                List<string> x = new List<string>();
                if (dtx.Rows.Count > 0)
                {
                    for (int i = 0; i < dtx.Rows.Count; i++)
                        x.Add(dtx.Rows[i]["Year"].ToString());
                }
                List<string> y = new List<string>();
                if (dtx.Rows.Count > 0)
                {
                    for (int i = 0; i < dtx.Rows.Count; i++)
                        y.Add(dtx.Rows[i]["t"].ToString());
                }
                //Add Series to the Chart.
                chart3.Series.Add(new Series(country));
                chart3.Series[country].IsValueShownAsLabel = true;
                chart3.Series[country].BorderWidth = 3;
                chart3.Series[country].MarkerColor = Color.OrangeRed;
                chart3.Series[country].MarkerStyle = MarkerStyle.Star10;
                chart3.Series[country].Points.DataBindXY(x, y);
                chart3.Series[country].ChartType = SeriesChartType.Line;
                if (chart3.Series[country].Points.Count < 1)
                {
                    MessageBox.Show("Rất tiếc, " + country + " khoảng thời gian này không có giao dịch!");
                }
            }
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";//label
            chart3.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;//bỏ lưới(grid) ngang
            chart3.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

        }
        private void btnRank_Click(object sender, EventArgs e)
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_ranknhacungcap", con);
            string result = new String('-', 50);
            string message = "Thứ tự" + "\t" + "Tên nha cung cap" + "\t" + "Doanh Thu" + "\n" + result + "\n";
            DataTable dt1 = new DataTable();
            daSearch.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                message += row["tt"] + "\t" + row["CompanyName"] + "\t" + "\t" + row["total"] + "\n" + result + "\n";
            }
            MessageBox.Show(message, "Bảng xếp hạng");
        }

        private void dumpDataIntoCombobox()
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_getListYear", con);
            DataSet ds = new DataSet();
            daSearch.Fill(ds, "daSearch");
            cbYear.ValueMember = "Year";//thuộc tính trong truy vấn
            cbYear.DataSource = ds.Tables["daSearch"];
        }

        private void dumpDataIntoCheckListBox()
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_tennhacc", con);
            DataTable dt = new DataTable();
            daSearch.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clBCountry.Items.Add(dt.Rows[i]["EmployeeID"].ToString());
            }
        }
        private void rbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            par_chart_nv("select * from v_tongsanphamnv", "Doanh Số");
            pie_chart_nv("select * from v_phantramnv", "Doanh Số");
        }

        private void rbNhaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            par_chart("select * from v_tongsanphamncc", "Doanh Số");
            pie_chart("select * from  v_phantramnhacc", "Doanh Số");
        }

        private void btnLineChart_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            foreach (String s in clBCountry.CheckedItems)
            {
                x.Add(s);
            }
            line_chart(cbYear.SelectedValue.ToString(), x);
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void clBCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
}
