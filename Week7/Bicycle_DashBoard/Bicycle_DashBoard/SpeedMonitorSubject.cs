using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_DashBoard
{
    public class SpeedMonitorSubject
    {
        private List<BicycleObserverBase> observerList;
        private int currentRPM;

        public void AddObserver(BicycleObserverBase o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(BicycleObserverBase o)
        {
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach(BicycleObserverBase currentObserver in observerList)
            {
                currentObserver.Update(currentRPM);
            }
        }
    }
}
