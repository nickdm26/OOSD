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
     * IShading interface is used to specify which method must be implemented when using this interface.
     */
    public interface IShading
    {
        Color CalculateColor(double value);
    }
}
