/*
 * Nick Muldrew
 * 8/3/2017
 * AnalogClockclass holds the logic for displaying and a making a Analog Clock appear on a form.
 */

using AnalogClockControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    class AnalogClockclass : IClock
    {
        //DataField
        AnalogClock Clock;

        /*
         * The AnalogClockclass Constructer takes a AnalogClock and saves it as a datafield.
         */
        public AnalogClockclass(AnalogClock clock)
        {
            Clock = clock;
        }
        /*
         * HideClock simply hides the AnalogClock on the form.
         */
        public void HideClock()
        {
            Clock.Hide();
        }

        /*
         * Off Simply stops the Analog Clock from updating.
         */
        public void Off()
        {
            Clock.Stop();
        }

        /*
         * On Starts the Analog clock and allows it to automatically update.
         */
        public void On()
        {
            Clock.Start();
        }

        /*
         * ShowClock shows the Analog Clock on the Form.
         */
        public void ShowClock()
        {
            Clock.Show();
        }

        /*
         * UpdateTimeDisplay is not used in this class, It automatacially updates.
         */
        public void UpdateTimeDisplay()
        {
        }
    }
}
