namespace logParser1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.LogGridView = new System.Windows.Forms.DataGridView();
            this.NumberOfUserLabel = new System.Windows.Forms.Label();
            this.NumberOfUsersCountLable = new System.Windows.Forms.Label();
            this.PieChartByDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChartByIp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.LogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartByIp)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(660, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 129);
            this.button2.TabIndex = 18;
            this.button2.Text = "Draw All Charts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogGridView
            // 
            this.LogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogGridView.Location = new System.Drawing.Point(27, 40);
            this.LogGridView.Name = "LogGridView";
            this.LogGridView.RowTemplate.Height = 24;
            this.LogGridView.Size = new System.Drawing.Size(617, 221);
            this.LogGridView.TabIndex = 23;
            this.LogGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LogGridView_CellContentClick);
            // 
            // NumberOfUserLabel
            // 
            this.NumberOfUserLabel.AutoSize = true;
            this.NumberOfUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberOfUserLabel.Location = new System.Drawing.Point(22, 12);
            this.NumberOfUserLabel.Name = "NumberOfUserLabel";
            this.NumberOfUserLabel.Size = new System.Drawing.Size(164, 25);
            this.NumberOfUserLabel.TabIndex = 7;
            this.NumberOfUserLabel.Text = "Number Of User :";
            // 
            // NumberOfUsersCountLable
            // 
            this.NumberOfUsersCountLable.AutoSize = true;
            this.NumberOfUsersCountLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberOfUsersCountLable.ForeColor = System.Drawing.Color.Maroon;
            this.NumberOfUsersCountLable.Location = new System.Drawing.Point(192, 12);
            this.NumberOfUsersCountLable.Name = "NumberOfUsersCountLable";
            this.NumberOfUsersCountLable.Size = new System.Drawing.Size(113, 25);
            this.NumberOfUsersCountLable.TabIndex = 24;
            this.NumberOfUsersCountLable.Text = "CountLable";
            // 
            // PieChartByDate
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChartByDate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChartByDate.Legends.Add(legend1);
            this.PieChartByDate.Location = new System.Drawing.Point(650, 267);
            this.PieChartByDate.Name = "PieChartByDate";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "ChartByDate";
            this.PieChartByDate.Series.Add(series1);
            this.PieChartByDate.Size = new System.Drawing.Size(617, 262);
            this.PieChartByDate.TabIndex = 25;
            this.PieChartByDate.Text = "chart1";
            this.PieChartByDate.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // PieChartByIp
            // 
            chartArea2.Name = "ChartArea1";
            this.PieChartByIp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChartByIp.Legends.Add(legend2);
            this.PieChartByIp.Location = new System.Drawing.Point(27, 267);
            this.PieChartByIp.Name = "PieChartByIp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "ChartByIp";
            this.PieChartByIp.Series.Add(series2);
            this.PieChartByIp.Size = new System.Drawing.Size(617, 262);
            this.PieChartByIp.TabIndex = 26;
            this.PieChartByIp.Text = "chart1";
            this.PieChartByIp.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1280, 545);
            this.Controls.Add(this.PieChartByIp);
            this.Controls.Add(this.PieChartByDate);
            this.Controls.Add(this.NumberOfUsersCountLable);
            this.Controls.Add(this.LogGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumberOfUserLabel);
            this.Name = "Form1";
            this.Text = "Web Log Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartByIp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView LogGridView;
        private System.Windows.Forms.Label NumberOfUserLabel;
        private System.Windows.Forms.Label NumberOfUsersCountLable;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChartByDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChartByIp;
    }
}

