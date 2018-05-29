using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class BeepObserver : FireAlarmObserverBase
    {
        public BeepObserver(FireAlarmSubject subject) : base(subject)
        {
        }

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            int freq = 0;
            int duration = 1000;
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    freq = 800;
                    break;
                case EFireCategory.SERIOUS:
                    freq = 1200;
                    break;
                case EFireCategory.INFERNO:
                    freq = 2000;
                    break;
            }
            Beep(freq, duration);
        }
    }
}
