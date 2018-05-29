using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Ellipse : ShapeBase
    {
        public Ellipse(Color bg, int startSize) : base(bg, startSize)
        {
            shapeColour = Color.Red;
            shapeBrush = new SolidBrush(shapeColour);
            length = startSize * 2;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.FillEllipse(shapeBrush, xLoc, yLoc, size, length);
        }
    }
}
