using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    public interface ISubject
    {
        void AddObserver(WeatherObserver o);
        void RemoveObserver(WeatherObserver o);
        void NotifyObserveres();
    }
}
