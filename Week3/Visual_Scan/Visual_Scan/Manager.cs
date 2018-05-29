using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;

namespace Visual_Scan
{
    class Manager
    {
        private List<Trial> trials;
        private Trial trial;
        private Graphics Canvas;
        private int Width;
        private int Height;
        private int NoGoRate;
        private Rectangle ScreenDimensions;
        private Color ResponseColor;

        public Manager(int Width, int Height, int NoGoRate, Rectangle ScreenDimensions, Color ResponseColor, Graphics Canvas)
        {
            this.Width = Width;
            this.Height = Height;
            this.NoGoRate = NoGoRate;
            this.ScreenDimensions = ScreenDimensions;
            this.ResponseColor = ResponseColor;
            this.Canvas = Canvas;
            trials = new List<Trial>();
            //this.timer = timer;
        }

        public void ApplicationCycle()
        {
            if (trials.Count >= 1)
            {
                trials[trials.Count - 1].Delete();
            }
            trial = new Trial(Width, Height, NoGoRate, ScreenDimensions, ResponseColor, Canvas);
            trials.Add(trial);
        }

        public void Stop()
        {
            for (int i = 0; i < trials.Count; i++)
            {
                trials[i].Delete();
            }
            WriteToFile();
        }

        public void Recated()
        {
            if (trials.Count >= 1)
            {
                trials[trials.Count - 1].Recated();
            }
        }

        public void UpDateSettings(int Width, int Height, Color ResponseColor, int NoGoRate)
        {
            this.Width = Width;
            this.Height = Height;
            this.ResponseColor = ResponseColor;
            this.NoGoRate = NoGoRate;
        }

        public void WriteToFile()
        {
            String[] lines = new String[trials.Count + 1];
            lines[0] = trials[0].DataFieldsToString();

            for (int i = 0; i < trials.Count; i++)
            {
                lines[i+1] = trials[i].ToString();
            }
            System.IO.File.WriteAllLines(@"H:\OOSD\Test.csv", lines);            
        }
    }
}
