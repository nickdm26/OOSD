using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bots
{
    public class PetrolBot
    {
        protected Ship subject;
        private Color color;
        private Graphics canvas;

        public int XPos { get; set; }
        public int YPos { get; set; }
        public int HomeXPos { get; set; }
        public int HomeYPos { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }        

        public PetrolBot(Ship subject, Graphics canvas, int HomeXPos, int HomeYPos, Color color)
        {
            this.subject = subject;
            this.canvas = canvas;
            this.HomeXPos = HomeXPos;
            this.HomeYPos = HomeYPos;
            this.color = color;
            Ship.ShipDelegate handler = new Ship.ShipDelegate(OutOfFuelEventHandler);
            Ship.ShipDelegate fullShipHandler = new Ship.ShipDelegate(FuelFullEventHandler);
            subject.ShipFullEvent += fullShipHandler;
            subject.ShipEmptyEvent += handler;
            Height = 15;
            Width = 15;
            XPos = HomeXPos;
            YPos = HomeYPos;
        }

        public void FuelFullEventHandler(object shipSubject, ShipEventArgs se)
        {
            XPos = HomeXPos;
            YPos = HomeYPos;
        }

        public void OutOfFuelEventHandler(object shipSubject, ShipEventArgs se)
        {
            XPos = se.XPos;
            YPos = se.YPos;
        }

        public void Draw()
        {
            Brush pink = new SolidBrush(color);
            canvas.FillEllipse(pink, XPos, YPos, Width, Height);
        }

        public void Erase()
        {
            Brush black = new SolidBrush(Color.Black);
            canvas.FillEllipse(black, XPos, YPos, Width, Height);
        }
    }
}
