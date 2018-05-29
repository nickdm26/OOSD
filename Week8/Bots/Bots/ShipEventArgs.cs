using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bots
{
    public class ShipEventArgs : EventArgs
    {
        public int XPos { get; set; }
        public int YPos { get; set; }

        public ShipEventArgs(int xPos, int yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
        }
    }
}
