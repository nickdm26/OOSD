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
     * GrayScale implements the IShading interface
     * It is using a new Shading alorgthim to calculate what color to return based on the value passed in.
     */
    public class GrayScale : IShading
    {
        /*
         * CalculateColor returns a Color based on what value was passed into the method.
         * converts a number to a value between 0 and 255, making the color range from black to white.
         */
        public Color CalculateColor(double value)
        {
            int val = (int)(value * 255);
            Color color = Color.FromArgb(val, val, val);
            return color;
        }
    }
}
