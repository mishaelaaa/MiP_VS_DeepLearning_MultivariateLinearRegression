﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;
using System.Windows.Forms;

namespace MiP_VS_DeepLearning_MultivariateLinearRegression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

#pragma warning disable CS1633 // Unrecognized #pragma directive
#pragma Random 
        Random rand = new Random();
        double[] xCoords;
        double[] yCoords;
#pragma warning restore CS1633 // Unrecognized #pragma directive

        private void PlotLine_Click(object sender, EventArgs e)
        {

        }

        private void PlotData_Click(object sender, EventArgs e)
        {
            xCoords = new double[Convert.ToInt32(NumberPoints.Value)];
            yCoords = new double[Convert.ToInt32(NumberPoints.Value)];

            chart1.Titles.Clear();
            chart1.Series.Clear();

            chart1.Titles.Add("Linear Regression");

            for (int i = 0; i < Math.Floor(xCoords.Length / 2.0); i++)
                xCoords[i] = rand.Next(i - xCoords.Length / 10, i + xCoords.Length / 10);

            for (var i = Convert.ToInt32(Math.Floor(xCoords.GetLength(0) / 2.0)); i < xCoords.GetLength(0); i++)
                xCoords[i] = rand.Next(i + xCoords.Length / 5, i + xCoords.Length / 2);

            for (var i = 0; i < Math.Floor(yCoords.Length / 2.0); i++)
                yCoords[i] = rand.Next(i, i + yCoords.Length / 5);

            for (var i = Convert.ToInt32(Math.Floor(yCoords.GetLength(0) / 2.0)); i < yCoords.GetLength(0); i++)
                yCoords[i] = rand.Next(i - yCoords.GetLength(0) / 10, i);

            chart1.Series.Add("Data Points");
            chart1.Series["Data Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            for (var i = 0; i < xCoords.Length; i++)
                NewMethod(i);
            GetChart1().Series["Data Points"].Color = Color.DarkBlue;

            chart1.Series.Add("QR Line");
            chart1.Series["QR Line"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series["Data Points"].Color = Color.DarkGreen;


        }

        private void NewMethod(int i)
        {
            NewMethod1(i);
        }

        private void NewMethod1(int i)
        {
            chart1.Series["Data Pionts"].Points.AddXY(xCoords[i], yCoords[i]);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart GetChart1()
        {
            return chart1;
        }

        private void NumberPoints_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumberDegree_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataPoints_Click(object sender, EventArgs e)
        {

        }

        private void Degree_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
