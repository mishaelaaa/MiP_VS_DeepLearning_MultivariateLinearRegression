using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet;
using MathNet.Numerics.LinearAlgebra.Double;

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

        public Random Rand { get => rand; set => rand = value; }

#pragma warning restore CS1633 // Unrecognized #pragma directive

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
                yCoords[i] = rand.Next(i - yCoords.Length / 10, i);

            chart1.Series.Add("Data Points");
            chart1.Series["Data Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series["Data Points"].Color = Color.DarkBlue;

            for (var i = 0; i<xCoords.Length; i++)
                chart1.Series["Data Pionts"].Points.AddXY(xCoords[i], yCoords[i]);

            chart1.Series.Add("QR Line");
            chart1.Series["QR Line"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["QR Line"].Color = Color.DarkGreen;
        }

        private void PlotLine_Click(object sender, EventArgs e)
        {
            chart1.Series["QR Line"].Points.Clear();

            var Degree = Convert.ToInt32(NumberDegree.Value);
            var X = new DenseMatrix(xCoords.Length, Degree + 1);
            X.SetColumn(0, DenseVector.Create(xCoords.Length, i => 1));

            if (Degree != 0)
                X.SetColumn(1, xCoords);

            for (int i = 2; i < Degree; i++)
                X.SetColumn(i, X.Column(1).PointwiseMultiply(X.Column(i - 1)));

            var y = DenseMatrix.OfColumns(yCoords.Length, 1, new[] { new DenseVector(yCoords) });
            var qrTheta = X.QR().Solve(y).ToColumnArrays();

            for (int i = 0; i < xCoords.Length; i++)
            {
                chart1.Series["QR Line"].Points.AddXY(xCoords[i], yPrediction(xCoords[i], qrTheta));
            }
        }

        private double yPrediction(double v, double[][] qrTheta) => throw new NotImplementedException();

        private static double yPrediction(double xPlot, double[] theta)
        {
            var yPlot = 0.0;

            for (var i = 0; i < theta.Length; i++)
                yPlot += theta[i] * Math.Pow(xPlot, i);
            
            return yPlot;
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
