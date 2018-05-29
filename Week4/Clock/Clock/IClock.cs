/*
 * Nick Muldrew
 * 8/3/2017
 * IClock is a interface which is used to switch between diffrent clock types using a GUI.
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    interface IClock
    {
        void On();
        void Off();
        void UpdateTimeDisplay();
        void ShowClock();
        void HideClock();
    }
}
