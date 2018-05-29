using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public enum EShipState { Full, Empty};

namespace Bots
{
    public class Ship
    {
        private int height;
        private int width;
        private Color color;
        private int fuel;
        private Random ran;
        private Rectangle Dimensions;
        private bool refuelCalled;
        public EShipState state { get; set; }
        public int XVel { get; set; }
        public int YVel { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        private Graphics canvas;

        public delegate void ShipDelegate(object ShipSubject, ShipEventArgs se);
        public event ShipDelegate ShipFullEvent;
        public event ShipDelegate ShipEmptyEvent;

        public Ship(Graphics canvas, Random ran, Rectangle Dimensions)
        {
            this.ran = ran;
            this.Dimensions = Dimensions;
            this.canvas = canvas;
            int ranVel = ran.Next(2);
            int ranVel2 = ran.Next(2);
            if (ranVel == 0)
            {
                XVel = -4;
            }else if(ranVel == 1){
                XVel = 4;
            }

            if (ranVel2 == 0)
            {
                YVel = -4;
            }
            else if (ranVel2 == 1)
            {
                YVel = 4;
            }

            height = 50;
            width = 50;
            fuel = ran.Next(50) + 50;
            state = EShipState.Full;
            XPos = ran.Next(Dimensions.Width - width);
            YPos = ran.Next(Dimensions.Height - height -10);
            refuelCalled = false;
        }

        public void Move()
        {
            int tempX = XPos + XVel;
            int tempY = YPos + YVel;

            AtBoundsBounce(tempX, tempY);
            XPos += XVel;
            YPos += YVel;
        }

        public void AtBoundsBounce(int TempXPos, int TempYPos)
        {
            if(TempXPos < Dimensions.Left)
            {
                XVel *= -1;
            }
            if((TempXPos + width) > Dimensions.Right)
            {
                XVel *= -1;
            }
            if(TempYPos < Dimensions.Top)
            {
                YVel *= -1;
            }
            if((TempYPos + height) > Dimensions.Bottom)
            {
                YVel *= -1;
            }
        }

        public void Draw()
        {
            color = Color.FromArgb((255 / 100) * fuel, 0, 0);
            Brush redb = new SolidBrush(color);            
            Rectangle rect = new Rectangle(XPos, YPos, width, height);            
            canvas.FillRectangle(redb, rect);            
        }

        public void DrawBottom()
        {
            Brush black = new SolidBrush(Color.Black);
            Rectangle bottom = new Rectangle(0, Dimensions.Height, Dimensions.Width, 100);
            canvas.FillRectangle(black, bottom);
        }

        public void shipFull()
        {
            refuelCalled = false;
            state = EShipState.Full;
            ShipEventArgs se = new ShipEventArgs(XPos, YPos);
            if(ShipFullEvent != null)
            {
                ShipFullEvent(this, se);
            }
        }

        public void Refuel()
        {
            if (!refuelCalled)
            {
                refuelCalled = true;
                ShipEventArgs se = new ShipEventArgs(XPos, YPos);
                if (ShipEmptyEvent != null)
                {
                    ShipEmptyEvent(this, se);
                }
            }else
            {
                if(fuel < 100)
                {
                    fuel += 2;
                }else
                {
                    shipFull();
                }
                
            }
        }

        public void Erase()
        {
            color = Color.FromArgb(255, 255, 255);
            Brush white = new SolidBrush(color);
            canvas.FillRectangle(white, XPos, YPos, width, height);
        }

        public void LoseFuel()
        {
            if(fuel != 0)
            {
                fuel--;
            }else
            {
                state = EShipState.Empty;
            }      
        }

        
        public void RunCycle()
        {           
            Erase();
            
            if(state == EShipState.Full)
            {
                LoseFuel();
                Move();
            }else if(state == EShipState.Empty)
            {
                Refuel();     
            }
            
            Draw();
            DrawBottom();
        }
    }
}
