/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULDND1Assignment1.Laplacian_Interface
{
    /*
     * LaplacianFactory is used to help encapsulate the code more. This is so only the  LaplacianFactory needs to know the details of how the Laplacian Function is created.
     */
    public class LaplacianFactory
    {
        /*
         * CreateNewLaplacian takes in a enum representing the Laplacian Function which is wanted.
         * The switch then creates that Laplacian Function and returns it so the Manager class does not need to know how its created.
         */
        public ILaplacian CreateNewLaplacian(ELaplacianFunctions lap)
        {
            ILaplacian newLaplacian = null;
            switch (lap)
            {
                case ELaplacianFunctions.CONVOLUTION:
                    newLaplacian = new Laplacian_Convolution();
                    break;
                case ELaplacianFunctions.DELTA_MEANS:
                    newLaplacian = new Laplacian_DeltaMeans();
                    break;
                case ELaplacianFunctions.PERPENDICULAR_NEIGHBOURS:
                    newLaplacian = new Laplacian_PerpendicularNeighbours();
                    break;
            }
            return newLaplacian;
        }
    }
}
