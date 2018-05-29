/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULDND1Assignment1
{
    /*
     * Laplacian_DeltaMeans is a simple function.
     * It simply calculates the diffrence between the average of all the neighbours and the concentration of the current cell.
     */
    class Laplacian_DeltaMeans : ILaplacian
    {
        /*
         * CalculateLaplacianValue_A returns the new calculated A value based on the algorthim specs.
         */
        public double CalculateLaplacianValue_A(Cell cell)
        {
            //double neighboursAverage = (cell.Top.A + cell.TopLeft.A + cell.Left.A + cell.BottomLeft.A + cell.Bottom.A + cell.BottomRight.A + cell.Right.A + cell.TopRight.A) / 8;
            double neighboursAverage = (cell.GetCellneighbour(7).A + cell.GetCellneighbour(0).A + cell.GetCellneighbour(1).A + cell.GetCellneighbour(2).A + cell.GetCellneighbour(3).A + cell.GetCellneighbour(4).A + cell.GetCellneighbour(5).A + cell.GetCellneighbour(6).A) / 8;
            return neighboursAverage - cell.A;
        }

        /*
         * CalculateLaplacianValue_B returns the new calculated A value based on the algorthim specs.
         */
        public double CalculateLaplacianValue_B(Cell cell)
        {
            //double neighboursAverage = (cell.Top.B + cell.TopLeft.B + cell.Left.B + cell.BottomLeft.B + cell.Bottom.B + cell.BottomRight.B + cell.Right.B + cell.TopRight.B) / 8;
            double neighboursAverage = (cell.GetCellneighbour(7).B + cell.GetCellneighbour(0).B + cell.GetCellneighbour(1).B + cell.GetCellneighbour(2).B + cell.GetCellneighbour(3).B + cell.GetCellneighbour(4).B + cell.GetCellneighbour(5).B + cell.GetCellneighbour(6).B) / 8;
            return neighboursAverage - cell.B;
        }

        /*
         * Returns the Diffusion rate for A as diffrent Laplacian functions have diffrent diffusion rates.
         */
        public double GetDiffusion_A()
        {
            return 1;
        }

        /*
         * Returns the Diffusion rate for B as diffrent Laplacian functions have diffrent diffusion rates.
         */
        public double GetDiffusion_B()
        {
            return 0.5;
        }
    }
}
