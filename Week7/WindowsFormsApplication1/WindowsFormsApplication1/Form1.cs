using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherMonitor;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MonitorSubject subject;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBTemp.Text = "0";
            txtBHumidity.Text = "cat";
            txtBPressure.Text = "0";
            //subject = new MonitorSubject(int.Parse(txtBTemp.Text), int.Parse(txtBHumidity.Text), int.Parse(txtBPressure.Text));
            subject = new MonitorSubject(0, 0, 0);
            WeatherObserver obCurrentTemp = new CurrentTemperature(int.Parse(txtBTemp.Text), int.Parse(txtBHumidity.Text), int.Parse(txtBPressure.Text), listBoxTemp, subject);
            //WeatherObserver obAverageReading = new AverageReadings(int.Parse(txtBTemp.Text), int.Parse(txtBHumidity.Text), int.Parse(txtBPressure.Text), listBoxAverage, subject);
            //WeatherObserver obForcast = new Forcast(int.Parse(txtBTemp.Text), int.Parse(txtBHumidity.Text), int.Parse(txtBPressure.Text), listBoxForcast, subject);
            //subject.AddObserver(obCurrentTemp);
            //subject.AddObserver(obAverageReading);
            //subject.AddObserver(obForcast);
        }
    }
}
