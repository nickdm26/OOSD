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
     * Laplacian_PerpendicularNeighbours considers only the direct neighbours (perpendicular).
     * It computes a sort of difference between the average of the four neighbours and the current cell.
     * It then multiplies this by some mysterious constant from biology.
     */
    class Laplacian_PerpendicularNeighbours : ILaplacian
    {
        /*
         * CalculateLaplacianValue_A returns the new calculated A value based on the algorthim specs.
         */
        public double CalculateLaplacianValue_A(Cell cell)
        {
            double h = 2.5 / 127.0;
            double rh = 1.0 / h / h;
            //double SumOfNeighbours = cell.Top.A + cell.Left.A + cell.Bottom.A + cell.Right.A;
            double SumOfNeighbours = cell.GetCellneighbour(7).A + cell.GetCellneighbour(1).A + cell.GetCellneighbour(3).A + cell.GetCellneighbour(5).A;
            return rh * ((SumOfNeighbours) - (4 * cell.A));             
        }

        /*
         * CalculateLaplacianValue_B returns the new calculated B value based on the algorthim specs.
         */
        public double CalculateLaplacianValue_B(Cell cell)
        {
            double h = 2.5 / 127.0;
            double rh = 1.0 / h / h;
            //double SumOfNeighbours = cell.Top.B + cell.Left.B + cell.Bottom.B + cell.Right.B;
            double SumOfNeighbours = cell.GetCellneighbour(7).B + cell.GetCellneighbour(1).B + cell.GetCellneighbour(3).B + cell.GetCellneighbour(5).B;
            return rh * ((SumOfNeighbours) - (4 * cell.B));
        }

        /*
         * Returns the Diffusion rate for A as diffrent Laplacian functions have diffrent diffusion rates.
         */
        public double GetDiffusion_A()
        {
            return 0.00002;
        }

        /*
         * Returns the Diffusion rate for B as diffrent Laplacian functions have diffrent diffusion rates.
         */
        public double GetDiffusion_B()
        {
            return 0.00001;
        }
    }
}
