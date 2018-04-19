using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiP_VS_DeepLearning_MultivariateLinearRegression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        double[] xCoords;
        double[] yCoords;

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

            for (var i = 0; i < Math.Floor(xCoords.GetLength(0) / 2.0); i++)
                xCoords[i] = rand.Next(i - xCoords.Length / 10, i + xCoords.Length / 10);

            /*for (var i = Convert.ToUInt32(Math.Floor(xCoords.GetLength(0) / 2.0)); i < xCoords.GetLength(0);)
                xCoords[i] = rand.Next(i + xCoords.Length/ 5, i + xCoords / 2);
                */
            for (var i = 0; i < Math.Floor(yCoords.GetLength(0) / 2.0); i++)
                yCoords[i] = rand.Next(i, i + yCoords.Length / 5);

            /* for (var i = Convert.ToUInt32(Math.Floor(yCoords.GetLength(0) / 2.0)); i < yCoords)
                 yCoords[i] = rand.Next(i - yCoords / 10, i);

         */
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
    }
}
