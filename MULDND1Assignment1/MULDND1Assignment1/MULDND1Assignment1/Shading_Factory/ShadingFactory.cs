/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULDND1Assignment1.Shading_Factory
{
    /*
     * ShadingFactory is used to help encapsulate the code more. This is so only the ShadingFactory needs to know the details of how the ShadingAlgorthim is created.
     */
    public class ShadingFactory
    {
        /*
         * CreateNewShadeing takes in a enum representing the ShadingAlgorthim which is wanted.
         * The switch then creates that ShadingAlgorthim and returns it so the GridDrawer class does not need to know how its created.
         */
        public IShading CreateNewShadeing(EShadingAlgorthims shade)
        {
            IShading newShade = null;
            switch (shade)
            {
                case EShadingAlgorthims.GRAYSCALE:
                    newShade = new GrayScale();
                    break;
                case EShadingAlgorthims.SHORT_RAINBOW:
                    newShade = new ShortRainbow();
                    break;
                case EShadingAlgorthims.LONG_RAINBOW:
                    newShade = new LongRainbow();
                    break;
                case EShadingAlgorthims.YELLOW_TO_RED:
                    newShade = new YellowToRed();
                    break;
            }
            return newShade;
        }
    }
}
