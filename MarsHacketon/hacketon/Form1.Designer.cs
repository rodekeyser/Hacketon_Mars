namespace hacketon
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartTemperture = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWindSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartInParticleSize = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewDATA = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWindSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInParticleSize)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTemperture
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemperture.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperture.Legends.Add(legend1);
            this.chartTemperture.Location = new System.Drawing.Point(33, 25);
            this.chartTemperture.Name = "chartTemperture";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.chartTemperture.Series.Add(series1);
            this.chartTemperture.Size = new System.Drawing.Size(569, 310);
            this.chartTemperture.TabIndex = 0;
            this.chartTemperture.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Temperature in Kelvin";
            this.chartTemperture.Titles.Add(title1);
            // 
            // chartWindSpeed
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWindSpeed.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWindSpeed.Legends.Add(legend2);
            this.chartWindSpeed.Location = new System.Drawing.Point(617, 25);
            this.chartWindSpeed.Name = "chartWindSpeed";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "WindSpeed";
            this.chartWindSpeed.Series.Add(series2);
            this.chartWindSpeed.Size = new System.Drawing.Size(608, 310);
            this.chartWindSpeed.TabIndex = 1;
            this.chartWindSpeed.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Wind speed in m/s";
            this.chartWindSpeed.Titles.Add(title2);
            // 
            // chartInParticleSize
            // 
            chartArea3.Name = "ChartArea1";
            this.chartInParticleSize.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartInParticleSize.Legends.Add(legend3);
            this.chartInParticleSize.Location = new System.Drawing.Point(33, 377);
            this.chartInParticleSize.Name = "chartInParticleSize";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Particle Size";
            this.chartInParticleSize.Series.Add(series3);
            this.chartInParticleSize.Size = new System.Drawing.Size(569, 309);
            this.chartInParticleSize.TabIndex = 2;
            this.chartInParticleSize.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Particle Size in µm";
            this.chartInParticleSize.Titles.Add(title3);
            // 
            // listViewDATA
            // 
            this.listViewDATA.Location = new System.Drawing.Point(617, 377);
            this.listViewDATA.Name = "listViewDATA";
            this.listViewDATA.Size = new System.Drawing.Size(634, 309);
            this.listViewDATA.TabIndex = 3;
            this.listViewDATA.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 778);
            this.Controls.Add(this.listViewDATA);
            this.Controls.Add(this.chartInParticleSize);
            this.Controls.Add(this.chartWindSpeed);
            this.Controls.Add(this.chartTemperture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWindSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInParticleSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperture;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWindSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInParticleSize;
        private System.Windows.Forms.ListView listViewDATA;
    }
}

