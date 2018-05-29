using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Scan
{
    class Trial
    {
        private Random Ran;
        private Color White;
        private Color Black;
        private Color ResponseColor;
        private Rectangle ScreenDimensions;
        private Graphics Canvas;

        public int XPos { get; set; }
        public int YPos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NoGoRate { get; set; }
        public bool GoTrial { get; set; }
        public bool Response { get; set; }

        public Trial(int Width, int Height, int NoGoRate, Rectangle ScreenDimensions, Color ResponseColor, Graphics Canvas)
        {
            Ran = new Random();
            White = Color.FromName("White");
            Black = Color.FromName("Black");
            this.ResponseColor = ResponseColor;
            this.ScreenDimensions = ScreenDimensions;
            this.Width = Width;
            this.Height = Height;
            this.NoGoRate = NoGoRate;
            this.Canvas = Canvas;

            XPos = Ran.Next(ScreenDimensions.Width - Width);
            YPos = Ran.Next(ScreenDimensions.Height - Height);

            SolidBrush myBrush;
            int NoGoRateTemp = Ran.Next(100 - NoGoRate);
            if(NoGoRateTemp == 1)
            {
                GoTrial = true;
                myBrush = new SolidBrush(Black);
            }
            else
            {
                GoTrial = false;
                myBrush = new SolidBrush(White);
            }

            Response = false;
            
            Canvas.FillRectangle(myBrush, new Rectangle(XPos, YPos, Width, Height));
                    
        }

        public override String ToString()
        {
            return XPos.ToString() + ", " + YPos.ToString() + ", " + Width + ", " + Height + ", " + NoGoRate + ", " + GoTrial + ", " + Response;
        }

        public String DataFieldsToString()
        {
            return "XPostion, YPostion, Width, Height, NoGo_Trial%, Trial, Response";
        }

        public void Recated()
        {
            if (!GoTrial)
            {
                SolidBrush myBrush = new SolidBrush(ResponseColor);
                Canvas.FillRectangle(myBrush, new Rectangle(XPos, YPos, Width, Height));
            }            
            Response = true;
        }

        public void Delete()
        {
            SolidBrush myBrush = new SolidBrush(Black);
            Canvas.FillRectangle(myBrush, new Rectangle(XPos, YPos, Width, Height));
        }

    }
}
