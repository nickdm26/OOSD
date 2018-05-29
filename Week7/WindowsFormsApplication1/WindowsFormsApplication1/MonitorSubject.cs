using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    public class MonitorSubject : ISubject
    {
        private List<WeatherObserver> observerList;
        private int currentTemp;
        private int currentHumidity;
        private int currentPressure;

        public MonitorSubject(int currentTemp, int currentHumidity, int currentPressure)
        {
            this.currentTemp = currentTemp;
            this.currentHumidity = currentHumidity;
            this.currentPressure = currentPressure;
            observerList = new List<WeatherObserver>();
        }


        public void AddObserver(WeatherObserver o)
        {
            observerList.Add(o);
        }

        public void NotifyObserveres()
        {
            foreach (WeatherObserver currentObserver in observerList)
            {
                currentObserver.Update(currentTemp, currentHumidity, currentPressure);
            }
        }

        public void RemoveObserver(WeatherObserver o)
        {
            observerList.Remove(o);
        }
    }
}
