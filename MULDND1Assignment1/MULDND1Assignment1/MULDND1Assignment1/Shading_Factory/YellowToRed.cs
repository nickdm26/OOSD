/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULDND1Assignment1.Shading_Factory
{
    /*
     * YellowToRed implements the IShading interface
     * It is using a new Shading alorgthim to calculate what color to return based on the value passed in.
     */
    public class YellowToRed : IShading
    {
        /*
         * CalculateColor returns a Color based on what value was passed into the method.
         * Basically a coloured varient of grayscale.
         */
        public Color CalculateColor(double value)
        {
            int val = (int)(value * 255);
            Color color = Color.FromArgb(255, val, 0);
            return color;
        }
    }
}
