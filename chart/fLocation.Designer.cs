
namespace chart
{
    partial class fLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDoanhSo = new System.Windows.Forms.RadioButton();
            this.rbDoanhThu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clBCountry = new System.Windows.Forms.CheckedListBox();
            this.btnLineChart = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnRank = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(11, 277);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "value";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(687, 535);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(31, 897);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#PERCENT\\n#VALX";
            series2.LabelFormat = "#,##%";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1279, 758);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDoanhSo);
            this.groupBox1.Controls.Add(this.rbDoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(371, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn hiển thị";
            // 
            // rbDoanhSo
            // 
            this.rbDoanhSo.AutoSize = true;
            this.rbDoanhSo.Location = new System.Drawing.Point(201, 40);
            this.rbDoanhSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDoanhSo.Name = "rbDoanhSo";
            this.rbDoanhSo.Size = new System.Drawing.Size(131, 30);
            this.rbDoanhSo.TabIndex = 4;
            this.rbDoanhSo.Text = "Doanh Số";
            this.rbDoanhSo.UseVisualStyleBackColor = true;
            this.rbDoanhSo.CheckedChanged += new System.EventHandler(this.rbDoanhSo_CheckedChanged);
            // 
            // rbDoanhThu
            // 
            this.rbDoanhThu.AutoSize = true;
            this.rbDoanhThu.Checked = true;
            this.rbDoanhThu.Location = new System.Drawing.Point(28, 40);
            this.rbDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDoanhThu.Name = "rbDoanhThu";
            this.rbDoanhThu.Size = new System.Drawing.Size(147, 30);
            this.rbDoanhThu.TabIndex = 3;
            this.rbDoanhThu.TabStop = true;
            this.rbDoanhThu.Text = "Doanh Thu";
            this.rbDoanhThu.UseVisualStyleBackColor = true;
            this.rbDoanhThu.CheckedChanged += new System.EventHandler(this.rbDoanhThu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clBCountry);
            this.groupBox2.Controls.Add(this.btnLineChart);
            this.groupBox2.Controls.Add(this.cbYear);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(734, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(627, 199);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem tốc độ doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Năm:";
            // 
            // clBCountry
            // 
            this.clBCountry.FormattingEnabled = true;
            this.clBCountry.Location = new System.Drawing.Point(24, 29);
            this.clBCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clBCountry.Name = "clBCountry";
            this.clBCountry.Size = new System.Drawing.Size(235, 149);
            this.clBCountry.TabIndex = 6;
            // 
            // btnLineChart
            // 
            this.btnLineChart.Location = new System.Drawing.Point(484, 77);
            this.btnLineChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLineChart.Name = "btnLineChart";
            this.btnLineChart.Size = new System.Drawing.Size(108, 32);
            this.btnLineChart.TabIndex = 2;
            this.btnLineChart.Text = "Xem";
            this.btnLineChart.UseVisualStyleBackColor = true;
            this.btnLineChart.Click += new System.EventHandler(this.btnLineChart_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(484, 26);
            this.cbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(108, 33);
            this.cbYear.TabIndex = 0;
            // 
            // btnRank
            // 
            this.btnRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.Location = new System.Drawing.Point(183, 167);
            this.btnRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(371, 37);
            this.btnRank.TabIndex = 7;
            this.btnRank.Text = "Xem danh sách xếp hạng doanh thu";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // chart3
            // 
            chartArea3.Area3DStyle.Inclination = 20;
            chartArea3.Area3DStyle.IsClustered = true;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea3.Area3DStyle.PointGapDepth = 0;
            chartArea3.Area3DStyle.Rotation = 0;
            chartArea3.Area3DStyle.WallWidth = 1;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.White;
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(703, 277);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.Points.Add(dataPoint1);
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(729, 517);
            this.chart3.TabIndex = 8;
            this.chart3.Text = "chart3";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(692, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 522);
            this.label3.TabIndex = 9;
            // 
            // fLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 840);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDoanhSo;
        private System.Windows.Forms.RadioButton rbDoanhThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnLineChart;
        private System.Windows.Forms.CheckedListBox clBCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label3;
    }
}

