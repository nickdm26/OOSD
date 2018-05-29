/*
 * Nick Muldrew
 * 8/3/2017
 * DigitalClock holds the logic for displaying and a making a Digital Clock appear on a form.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    class DigitalClock : IClock
    {
        //DataFields
        Label Clock;
        Timer ClockTimer;

        /*
         * DigitalClock Constructer takes a Label and a timer and instalises them.
         * The Label is used to display the time on the form while the timer is used to Update The display at a specfic interval.
         */
        public DigitalClock(Label clock, Timer timer)
        {
            Clock = clock;
            ClockTimer = timer;
        }

        /*
         * HideClock simply hides the label the time is being displayed on.
         */
        public void HideClock()
        {
            Clock.Hide();
        }

        /*
         * Off simply stops the timer causing the UpdateTimeDisplay to stop being called.
         */
        public void Off()
        {
            ClockTimer.Stop();
        }

        /*
         * On Starts the timer again so UpdateTimeDisplay can be called.
         */
        public void On()
        {
            ClockTimer.Start();
        }

        /*
         * ShowClock Shows the label the time is being displayed on in the form.
         */
        public void ShowClock()
        {
            Clock.Show();
        }

        /*
         * UpdateTimeDisplay sets a format for the date then gets the current time and displays that in the label.
         */
        public void UpdateTimeDisplay()
        {
            String format = "HH:mm:ss";
            DateTime localDate = DateTime.Now;
            Clock.Text = localDate.ToString(format);
        }
    }
}
