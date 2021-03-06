﻿/*
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
     * ShortRainbow implements the IShading interface
     * It is using a new Shading alorgthim to calculate what color to return based on the value passed in.
     */
    public class ShortRainbow : IShading
    {
        /*
         * CalculateColor returns a Color based on what value was passed into the method.
         * converts a number into a rainbow. The number is divided into four groups then based on what group its in it creates a diffrent color set.
         */
        public Color CalculateColor(double value)
        {
            double val = (1 - value) / 0.25;
            int X = (int)Math.Floor(val);
            int Y = (int)Math.Floor(255*(val - X));

            Color color = Color.White;

            switch (X)
            {
                case 0:
                    color = Color.FromArgb(255, Y, 0);
                    break;
                case 1:
                    color = Color.FromArgb(255 - Y, 255, 0);
                    break;
                case 2:
                    color = Color.FromArgb(0, 255, Y);
                    break;
                case 3:
                    color = Color.FromArgb(0, 255 - Y, 255);
                    break;
                case 4:
                    color = Color.FromArgb(0, 0, 255);
                    break;
            }
            
            return color;
        }
    }
}
