using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    public interface IObserver
    {
        void Update(int currentTemp, int currentHumidity, int currentPressure);
        void Display();
    }
}
