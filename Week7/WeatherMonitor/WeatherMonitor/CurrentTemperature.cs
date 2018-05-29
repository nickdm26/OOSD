using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public class CurrentTemperature : WeatherObserver
    {
        public CurrentTemperature(int currentTemp, int currentHumidity, int currentPressure, RichTextBox displayBox, MonitorSubject subject) : base(currentTemp, currentHumidity, currentPressure, displayBox, subject)
        {

        }

        public override void Display()
        {
            displayBox.Clear();
            displayBox.Text = ("Temperature: " + currentTemp + "\n");
            displayBox.Text += ("Humidity: " + currentHumidity + "\n");
            displayBox.Text += ("Pressure: " + currentPressure);
        }

        public override void Update(int currentTemp, int currentHumidity, int currentPressure)
        {
            this.currentTemp = currentTemp;
            this.currentHumidity = currentHumidity;
            this.currentPressure = currentPressure;
        }
    }
}
