using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
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
            subject.NotifyObserveres(Convert.ToInt16(txtBTemp.Text), Convert.ToInt16(txtBHumidity.Text), Convert.ToInt16(txtBPressure.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtBTemp.Text = "32";
            txtBHumidity.Text = "90";
            txtBPressure.Text = "560";
            //subject = new MonitorSubject(int.Parse(txtBTemp.Text), int.Parse(txtBHumidity.Text), int.Parse(txtBPressure.Text));
            subject = new MonitorSubject(0, 0, 0);
            WeatherObserver obCurrentTemp = new CurrentTemperature(Convert.ToInt16(txtBTemp.Text), Convert.ToInt16(txtBHumidity.Text), Convert.ToInt16(txtBPressure.Text), richTextBoxTemp, subject);
            WeatherObserver obAverageReading = new AverageReadings(Convert.ToInt16(txtBTemp.Text), Convert.ToInt16(txtBHumidity.Text), Convert.ToInt16(txtBPressure.Text), richTextBoxAverage, subject);
            WeatherObserver obForcast = new Forcast(Convert.ToInt16(txtBTemp.Text), Convert.ToInt16(txtBHumidity.Text), Convert.ToInt16(txtBPressure.Text), richTextBoxForcast, subject);
            subject.AddObserver(obCurrentTemp);
            subject.AddObserver(obAverageReading);
            subject.AddObserver(obForcast);
            
        }
    }
}
