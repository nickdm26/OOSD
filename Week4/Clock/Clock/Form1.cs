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
    public partial class Form1 : Form
    {
        IClock Clock;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Clock.On();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Clock.Off();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets the Clock to analog so it can then be hidden, then Sets the clock to digital at the start.
            Clock = new AnalogClockclass(analogClock1);
            Clock.HideClock();
            Clock = new DigitalClock(lblDigital, timer1);
        }

        private void rbtnAnalog_CheckedChanged(object sender, EventArgs e)
        {
            //Hides the previous clock which was the Digital Clock, then Sets the Clock to Analog and shows it.
            Clock.HideClock();            
            Clock = new AnalogClockclass(analogClock1);
            Clock.ShowClock();
        }

        private void rbtnDigital_CheckedChanged(object sender, EventArgs e)
        {
            //Hides the previous clock which was the Analog Clock, then Sets the Clock to Digital and shows it.
            Clock.HideClock();
            Clock = new DigitalClock(lblDigital, timer1);
            Clock.ShowClock();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.UpdateTimeDisplay();
        }
    }
}
