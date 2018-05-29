using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public abstract class WeatherObserver : IObserver
    {
        protected int currentTemp;
        protected int currentHumidity;
        protected int currentPressure;
        protected int avgTempTotal;
        protected int avgHumidityTotal;
        protected int avgPressureTotal;
        protected int updateCount;
        protected RichTextBox displayBox;
        protected MonitorSubject subject;

        public WeatherObserver(int currentTemp, int currentHumidity, int currentPressure, RichTextBox displayBox, MonitorSubject subject)
        {
            this.currentTemp = currentTemp;
            this.currentHumidity = currentHumidity;
            this.currentPressure = currentPressure;
            avgTempTotal = currentTemp;
            avgHumidityTotal = currentHumidity;
            avgPressureTotal = currentPressure;
            updateCount = 1;
            this.displayBox = displayBox;
            this.subject = subject;
            subject.AddObserver(this);
        }

        public abstract void Update(int currentTemp, int currentHumidity, int currentPressure);

        public abstract void Display();
    }
}
