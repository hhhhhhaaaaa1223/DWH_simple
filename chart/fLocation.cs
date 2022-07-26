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
    public partial class fLocation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SaleDWH;Integrated Security=True");
        public fLocation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            par_chart("select * from v_getRevenueCountry", "Doanh Thu");
            pie_chart("select * from v_percentRevenueCountry", "Doanh Thu");
            dumpDataIntoCombobox();//danh sách năm
            dumpDataIntoCheckListBox();//danh sách tên quốc gia
            List<string> countries = new List<string>() { "Brazil","Canada" };
            line_chart("1996", countries);
            clBCountry.SetItemChecked(3, true);
            clBCountry.SetItemChecked(4, true);

        }
        private void line_chart( string year, List<string> countries)
        {
            //xóa Series cũ.
            while (chart3.Series.Count > 0) { chart3.Series.RemoveAt(0); }
            foreach (string country in countries)
            {
                SqlDataAdapter adx = new SqlDataAdapter("select Month, sum(total) as t from v_getRevenueMonth where Year = " + year + " and Country = '" + country + "' group by Month", con);
                DataTable dtx = new DataTable();
                adx.Fill(dtx);
                List<string> x = new List<string>();
                if (dtx.Rows.Count > 0)
                {
                    for (int i = 0; i < dtx.Rows.Count; i++)
                        x.Add(dtx.Rows[i]["Month"].ToString());
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
                if (chart3.Series[country].Points.Count <1)
                {
                    MessageBox.Show("Rất tiếc, "+ country+" khoảng thời gian này không có giao dịch!");
                }
            }
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Revenue";
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Month";//label
            chart3.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;//bỏ lưới(grid) ngang
            chart3.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            
        }
        private void dumpDataIntoCheckListBox()
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_getListCountry", con);
            DataTable dt = new DataTable();
            daSearch.Fill(dt);
            for (int i =0;i< dt.Rows.Count;i++)
            {
                clBCountry.Items.Add(dt.Rows[i]["country"].ToString());
            }
        }
        //biểu đồ tròn
        private void pie_chart(string query, string titleY)
        {
            SqlDataAdapter ad2 = new SqlDataAdapter(query, con);
            DataTable dt2 = new DataTable();
            ad2.Fill(dt2);
            chart2.DataSource = dt2;
            chart2.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên quốc gia";

            //format chart 
            chart2.Series["Series1"].YValueMembers = "PhanTram";//lấy tên thuột tính từ DB
            chart2.Series["Series1"].XValueMember = "Country";
            chart2.Titles.Clear();
            chart2.Titles.Add("Tỷ lệ "+ titleY+" trên tổng công ty");
        }
        //biểu đồ cột ngang
        private void par_chart(string query, string titleY)
        {
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = titleY;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên quốc gia";//label

            //format chart 

            chart1.Series[0].YValueMembers = "Total";//tên thuột tính lấy ở DB
            chart1.Series[0].XValueMember = "Country";
            //chart1.Series["Doanh Thu"].IsValueShownAsLabel = true; //hiển thị doanh thu cụ thể ở mỗi nước
            chart1.ChartAreas[0].AxisX.Interval = 1; //khoảng cách label(tên các nước)
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;//bỏ lưới(grid) ngang
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            // Assign the legend to Series.
            chart1.Series[0].LegendText = titleY;
        }

        private void rbDoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            par_chart("select * from v_getRevenueCountry", "Doanh Thu");
            pie_chart("select * from v_percentRevenueCountry", "Doanh Thu");

        }

        private void rbDoanhSo_CheckedChanged(object sender, EventArgs e)
        {
            par_chart("select * from v_getQuantityCountry", "Doanh Số");
            pie_chart("select * from v_percentQuantityCountry", "Doanh Số");

        }
        private void dumpDataIntoCombobox()
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_getListYear", con);
            DataSet ds = new DataSet();
            daSearch.Fill(ds, "daSearch");
            cbYear.ValueMember = "Year";//thuộc tính trong truy vấn
            cbYear.DataSource = ds.Tables["daSearch"];
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT *  FROM v_rankRenvenueCountry", con);
            string result = new String('-', 50);
            string message = "Thứ tự" + "\t" + "Tên quốc gia" +"\t"+"Doanh Thu"+"\n" + result + "\n";
            DataTable dt1 = new DataTable();
            daSearch.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                message += row["tt"] + "\t" + row["Country"] + "\t" +"\t" + row["total"] + "\n" + result + "\n";
            }
            MessageBox.Show(message,"Bảng xếp hạng");
        }

        private void btnLineChart_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            //if (clBCountry.CheckedItems.Count > 0)
            //{
                foreach (String s in clBCountry.CheckedItems)
                {
                    x.Add(s);
                }
                line_chart(cbYear.SelectedValue.ToString(), x);
            //}
        }
    }
}
