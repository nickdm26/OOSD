using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_DashBoard
{
    public abstract class BicycleObserverBase : IObserver
    {
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SpeedMonitorSubject bikeSubject;

        public BicycleObserverBase(Label displayLabel, SpeedMonitorSubject bikeSubject)
        {
            this.displayLabel = displayLabel;
            currentRPM = 0;
            currentComputedValue = 0;
            this.bikeSubject = bikeSubject;
            bikeSubject.AddObserver(this);
        }

        public abstract void Update(int currentRPM);

        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
