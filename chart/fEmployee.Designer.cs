
namespace chart
{
    partial class fEmployee
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
            this.btnRank = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNhaCungCap = new System.Windows.Forms.RadioButton();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clBCountry = new System.Windows.Forms.CheckedListBox();
            this.btnLineChart = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRank
            // 
            this.btnRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.Location = new System.Drawing.Point(817, 135);
            this.btnRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(423, 37);
            this.btnRank.TabIndex = 15;
            this.btnRank.Text = "Xem danh sách xếp hạng doanh thu";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNhaCungCap);
            this.groupBox1.Controls.Add(this.rbNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(817, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(423, 93);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn hiển thị";
            // 
            // rbNhaCungCap
            // 
            this.rbNhaCungCap.AutoSize = true;
            this.rbNhaCungCap.Location = new System.Drawing.Point(201, 40);
            this.rbNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNhaCungCap.Name = "rbNhaCungCap";
            this.rbNhaCungCap.Size = new System.Drawing.Size(184, 30);
            this.rbNhaCungCap.TabIndex = 4;
            this.rbNhaCungCap.Text = "Nhà Cung Cấp";
            this.rbNhaCungCap.UseVisualStyleBackColor = true;
            this.rbNhaCungCap.CheckedChanged += new System.EventHandler(this.rbNhaCungCap_CheckedChanged);
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Checked = true;
            this.rbNhanVien.Location = new System.Drawing.Point(6, 40);
            this.rbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(141, 30);
            this.rbNhanVien.TabIndex = 3;
            this.rbNhanVien.TabStop = true;
            this.rbNhanVien.Text = "Nhân Viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            this.rbNhanVien.CheckedChanged += new System.EventHandler(this.rbNhanVien_CheckedChanged);
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(510, 263);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(991, 504);
            this.chart3.TabIndex = 13;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // chart2
            // 
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(32, 4);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(231, 763);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart1
            // 
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.IsClustered = true;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(14, 777);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsValueShownAsLabel = true;
            series3.Label = "#PERCENT\\n#VALX";
            series3.LabelFormat = "#,##%";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1487, 600);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clBCountry);
            this.groupBox2.Controls.Add(this.btnLineChart);
            this.groupBox2.Controls.Add(this.cbYear);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(336, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(515, 141);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tốc độ doanh thu của nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 39);
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
            this.clBCountry.Size = new System.Drawing.Size(235, 120);
            this.clBCountry.TabIndex = 6;
            this.clBCountry.SelectedIndexChanged += new System.EventHandler(this.clBCountry_SelectedIndexChanged);
            // 
            // btnLineChart
            // 
            this.btnLineChart.Location = new System.Drawing.Point(408, 90);
            this.btnLineChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLineChart.Name = "btnLineChart";
            this.btnLineChart.Size = new System.Drawing.Size(114, 32);
            this.btnLineChart.TabIndex = 2;
            this.btnLineChart.Text = "Xem";
            this.btnLineChart.UseVisualStyleBackColor = true;
            this.btnLineChart.Click += new System.EventHandler(this.btnLineChart_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(408, 39);
            this.cbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(114, 33);
            this.cbYear.TabIndex = 0;
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1522, 720);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fEmployee";
            this.Text = "fEmployee";
            this.Load += new System.EventHandler(this.fEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNhaCungCap;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clBCountry;
        private System.Windows.Forms.Button btnLineChart;
        private System.Windows.Forms.ComboBox cbYear;
    }
}