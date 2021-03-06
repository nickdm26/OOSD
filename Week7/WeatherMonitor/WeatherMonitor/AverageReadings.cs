﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public class AverageReadings : WeatherObserver
    {
        public AverageReadings(int currentTemp, int currentHumidity, int currentPressure, RichTextBox displayBox, MonitorSubject subject) : base(currentTemp, currentHumidity, currentPressure, displayBox, subject)
        {
        }

        public override void Display()
        {
            displayBox.Clear();
            displayBox.Text = ("Temperature: " + avgTempTotal / updateCount + "\n");
            displayBox.Text += ("Humidity: " + avgHumidityTotal / updateCount + "\n");
            displayBox.Text += ("Pressure: " + avgPressureTotal / updateCount);
        }

        public override void Update(int currentTemp, int currentHumidity, int currentPressure)
        {
            this.currentTemp = currentTemp;
            this.currentHumidity = currentHumidity;
            this.currentPressure = currentPressure;
            avgTempTotal += currentTemp;
            avgHumidityTotal += currentHumidity;
            avgPressureTotal += currentPressure;
            updateCount++;
        }
    }
}
