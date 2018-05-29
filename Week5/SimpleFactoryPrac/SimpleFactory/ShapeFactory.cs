using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ShapeFactory
    {
        Color backgroundColour;

        public ShapeFactory(Color backgroundColour)
        {
            this.backgroundColour = backgroundColour;
        }

        public ShapeBase CreateNewShape(int ShapeType, int shapeDimension)
        {
            ShapeBase newShape = null;
            switch (ShapeType)
            {
                case 0:
                    newShape = new Square(backgroundColour, shapeDimension);
                    break;
                case 1:
                    newShape = new Circle(backgroundColour, shapeDimension);
                    break;
                case 2:
                    newShape = new Triangle(backgroundColour, shapeDimension);
                    break;
                case 3:
                    newShape = new Ellipse(backgroundColour, shapeDimension);
                    break;
            }
            return newShape;
        }
    }
}
