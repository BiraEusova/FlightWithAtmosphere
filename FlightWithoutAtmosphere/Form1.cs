using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightWithoutAtmosphere
{
    public partial class Form1 : Form
    {

        private FlightAnalyticalModel flightModel;
        private bool pause = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                Initialization();

                chart1.ChartAreas[0].AxisX.Maximum = flightModel.XMax;
                chart1.ChartAreas[0].AxisY.Maximum = flightModel.YMax;

                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(flightModel.X, flightModel.Y);
                outputTimeLabel.Text = flightModel.GetTime() + " sec";
            }

            timer1.Start();
        }

        private void Initialization()
        {
            double a = (double)angelNumericUpDown.Value * Math.PI / 180;
            double v0 = (double)speedNumericUpDown.Value;
            double y0 = (double)heightNumericUpDown.Value;
            double S = (double)areaNumericUpDown.Value / 10000;
            double m = (double)massNumericUpDown.Value;
            
            flightModel = new FlightAnalyticalModel(a, v0, y0, S, m);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pause = false;

            flightModel.ChangeValues();

            chart1.Series[0].Points.AddXY(flightModel.X, flightModel.Y);           
            outputTimeLabel.Text = flightModel.GetTime() + " sec";

            if (flightModel.Y <= 0) timer1.Stop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            pause = true;
            timer1.Stop();
        }
    }
}
