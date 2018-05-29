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
        public CurrentTemperature(int currentTemp, int currentHumidity, int currentPressure, ListBox displayBox, MonitorSubject subject) : base(currentTemp, currentHumidity, currentPressure, displayBox, subject)
        {

        }

        public override void Display()
        {
            displayBox.Items.Clear();
            //displayBox.Items.Add("Temperature: " + currentTemp);
            //displayBox.Items.Add("Humidity: " + currentHumidity);
            //displayBox.Items.Add("Pressure: " + currentPressure);
        }

        public override void Update(int currentTemp, int currentHumidity, int currentPressure)
        {
            this.currentTemp = currentTemp;
            this.currentHumidity = currentHumidity;
            this.currentPressure = currentPressure;
        }
    }
}
