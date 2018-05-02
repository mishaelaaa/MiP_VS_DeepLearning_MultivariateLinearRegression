namespace MiP_VS_DeepLearning_MultivariateLinearRegression
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
            this.DataPoints = new System.Windows.Forms.Label();
            this.Degree = new System.Windows.Forms.Label();
            this.PlotData = new System.Windows.Forms.Button();
            this.PlotLine = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumberPoints = new System.Windows.Forms.NumericUpDown();
            this.NumberDegree = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberDegree)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPoints
            // 
            this.DataPoints.AutoSize = true;
            this.DataPoints.Location = new System.Drawing.Point(47, 16);
            this.DataPoints.Name = "DataPoints";
            this.DataPoints.Size = new System.Drawing.Size(85, 17);
            this.DataPoints.TabIndex = 0;
            this.DataPoints.Text = "DataPoints :";
            this.DataPoints.Click += new System.EventHandler(this.DataPoints_Click);
            // 
            // Degree
            // 
            this.Degree.AutoSize = true;
            this.Degree.Location = new System.Drawing.Point(47, 66);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(63, 17);
            this.Degree.TabIndex = 1;
            this.Degree.Text = "Degree :";
            this.Degree.Click += new System.EventHandler(this.Degree_Click);
            // 
            // PlotData
            // 
            this.PlotData.Location = new System.Drawing.Point(424, 13);
            this.PlotData.Name = "PlotData";
            this.PlotData.Size = new System.Drawing.Size(86, 23);
            this.PlotData.TabIndex = 2;
            this.PlotData.Text = "Plot Data :";
            this.PlotData.UseVisualStyleBackColor = true;
            this.PlotData.Click += new System.EventHandler(this.PlotData_Click);
            // 
            // PlotLine
            // 
            this.PlotLine.Location = new System.Drawing.Point(424, 63);
            this.PlotLine.Name = "PlotLine";
            this.PlotLine.Size = new System.Drawing.Size(86, 23);
            this.PlotLine.TabIndex = 3;
            this.PlotLine.Text = "Plot Line :";
            this.PlotLine.UseVisualStyleBackColor = true;
            this.PlotLine.Click += new System.EventHandler(this.PlotLine_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 110);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(495, 400);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // NumberPoints
            // 
            this.NumberPoints.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberPoints.Location = new System.Drawing.Point(145, 14);
            this.NumberPoints.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumberPoints.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberPoints.Name = "NumberPoints";
            this.NumberPoints.Size = new System.Drawing.Size(120, 22);
            this.NumberPoints.TabIndex = 5;
            this.NumberPoints.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberPoints.ValueChanged += new System.EventHandler(this.NumberPoints_ValueChanged);
            // 
            // NumberDegree
            // 
            this.NumberDegree.Location = new System.Drawing.Point(145, 64);
            this.NumberDegree.Name = "NumberDegree";
            this.NumberDegree.Size = new System.Drawing.Size(120, 22);
            this.NumberDegree.TabIndex = 6;
            this.NumberDegree.ValueChanged += new System.EventHandler(this.NumberDegree_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 517);
            this.Controls.Add(this.NumberDegree);
            this.Controls.Add(this.NumberPoints);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PlotLine);
            this.Controls.Add(this.PlotData);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.DataPoints);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberDegree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataPoints;
        private System.Windows.Forms.Label Degree;
        private System.Windows.Forms.Button PlotData;
        private System.Windows.Forms.Button PlotLine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown NumberPoints;
        private System.Windows.Forms.NumericUpDown NumberDegree;
    }
}

