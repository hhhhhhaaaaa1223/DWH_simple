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
    public partial class fCategory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SaleDWH;Integrated Security=True");
        public fCategory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawchart1("select * from v_getRevenueCategory", "Doanh thu(USD)");
            drawchart3("select * from v_percentR", "Doanh thu");
            LoadDataIntoCombobox();
            LoadDataIntoCheckListBox();
            //List<string> category = new List<string>() { "Brazil", "Canada" };
            //drawchart2("1996", category);
            //clbCategory.SetItemChecked(3, true);
            //clbCategory.SetItemChecked(4, true);

        }
        private void LoadDataIntoCheckListBox()
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("select distinct CategoryName from DimCategory ", con);
            DataTable dt = new DataTable();
            daSearch.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clbCategory.Items.Add(dt.Rows[i]["CategoryName"].ToString());
            }
        }
        private void LoadDataIntoCombobox()
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_getListYear", con);
            DataSet ds = new DataSet();
            daSearch.Fill(ds, "daSearch");
            cbYear.ValueMember = "Year";//thuộc tính trong truy vấn
            cbYear.DataSource = ds.Tables["daSearch"];
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drawchart1("select * from v_getRevenueCategory", "Doanh thu(USD)");
            drawchart3("select * from v_percentR", "Doanh thu");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drawchart1("select * from v_getQuantityCategory", "Doanh số");
            drawchart3("select * from v_percentQ", "Doanh số");
        }
        private void drawchart1(string query, string titleY)
        {
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Danh mục";

            chart1.Series[0].YValueMembers = "Total";
            chart1.Series[0].XValueMember = "CategoryName";
            chart1.ChartAreas[0].AxisX.Interval = 0.5;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chart1.Series[0].LegendText = titleY;
            chart1.Titles.Clear();
            chart1.Titles.Add("Doanh số và doanh thu của từng loại sản phẩm từ năm 1996-1998");

        }
        private void drawchart2(string year, List<string> category)
        {
            //xóa Series cũ.
            while (chart2.Series.Count > 0) { chart2.Series.RemoveAt(0); }
            foreach (string x in category)
            {
                SqlDataAdapter ad = new SqlDataAdapter();
                try
                {
                    if (radioButton4.Checked == true)
                    { ad = new SqlDataAdapter("select Month, sum(total) as t from v_getRevenueByMonth where Year = " + year + " and CategoryName = '" + x + "' group by Month", con); }
                    if (radioButton3.Checked == true)
                    { ad = new SqlDataAdapter("select Month, sum(total) as t from v_getQuantityByMonth where Year = " + year + " and CategoryName = '" + x + "' group by Month", con); }

                }
                catch { }
                DataTable dt = new DataTable();
                ad.Fill(dt);
                List<string> m = new List<string>();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        m.Add(dt.Rows[i]["Month"].ToString());
                }
                List<string> y = new List<string>();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        y.Add(dt.Rows[i]["t"].ToString());
                }
                //Add Series to the Chart.
                chart2.Series.Add(new Series(x));
                chart2.Series[x].IsValueShownAsLabel = true;
                chart2.Series[x].BorderWidth = 3;
                chart2.Series[x].MarkerColor = Color.Blue;
                chart2.Series[x].MarkerStyle = MarkerStyle.Star10;
                chart2.Series[x].Points.DataBindXY(m, y);
                chart2.Series[x].ChartType = SeriesChartType.Column;
                if (chart2.Series[x].Points.Count < 1)
                {
                    MessageBox.Show(x + " không có giao dịch trong khoảng thời gian này!");
                }
            }
            if (radioButton4.Checked == true)
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu(USD)";
            if (radioButton3.Checked == true)
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chart2.Titles.Clear();
            chart2.Titles.Add("Doanh số và doanh thu của từng loại sản phẩm theo từng năm");
        }
        //biểu đồ tròn
        private void drawchart3(string query, string titleY)
        {
            SqlDataAdapter ad2 = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            ad2.Fill(dt1);
            chart3.DataSource = dt1;
            chart3.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chart3.Series["Series1"].YValueMembers = "percentRQ";
            chart3.Series["Series1"].XValueMember = "Year";
            chart3.Series["Series1"].MarkerColor = Color.Blue;
            chart3.Titles.Clear();
            chart3.Titles.Add("Tỷ lệ " + titleY + " của công ty từ năm 1996-1998");
        }


        private void clbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            foreach (String s in clbCategory.CheckedItems)
            {
                x.Add(s);
            }
            drawchart2(cbYear.SelectedValue.ToString(), x);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            foreach (String s in clbCategory.CheckedItems)
            {
                x.Add(s);
            }
            drawchart2(cbYear.SelectedValue.ToString(), x);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            foreach (String s in clbCategory.CheckedItems)
            {
                x.Add(s);
            }
            drawchart2(cbYear.SelectedValue.ToString(), x);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            foreach (String s in clbCategory.CheckedItems)
            {
                x.Add(s);
            }
            drawchart2(cbYear.SelectedValue.ToString(), x);
        }
    }
}
