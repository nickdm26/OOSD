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
     * Laplacian_Convolution computes a convolution of the cell and its neighbours.
     * multiples the diagonal neighbours by 0.05
     * multiples the direct neighbours by 0.2
     * the cell by -1
     * Then sum the results from the neighbours and cell.
     */
    class Laplacian_Convolution : ILaplacian
    {
        /*
         * CalculateLaplacianValue_A returns the new calculated A value based on the algorthim specs.
         */
        public double CalculateLaplacianValue_A(Cell cell)
        {
            //double cornerSum = (cell.TopLeft.A + cell.TopRight.A + cell.BottomLeft.A + cell.BottomRight.A) * 0.05;
            double cornerSum = (cell.GetCellneighbour(0).A + cell.GetCellneighbour(6).A + cell.GetCellneighbour(2).A +cell.GetCellneighbour(4).A) *0.05;
            //double perpendicularSum = (cell.Top.A + cell.Left.A + cell.Bottom.A + cell.Right.A) * 0.2;
            double perpendicularSum = (cell.GetCellneighbour(7).A + cell.GetCellneighbour(1).A + cell.GetCellneighbour(3).A + cell.GetCellneighbour(5).A) * 0.2;
            double middle = cell.A * -1;
            return cornerSum + perpendicularSum + middle;            
        }

        /*
         * CalculateLaplacianValue_B returns the new calculated A value based on the algorthim specs.
         */
        public double CalculateLaplacianValue_B(Cell cell)
        {
            //double cornerSum = (cell.TopLeft.B + cell.TopRight.B + cell.BottomLeft.B + cell.BottomRight.B) * 0.05;
            double cornerSum = (cell.GetCellneighbour(0).B + cell.GetCellneighbour(6).B + cell.GetCellneighbour(2).B + cell.GetCellneighbour(4).B) * 0.05;
            //double perpendicularSum = (cell.Top.B + cell.Left.B + cell.Bottom.B + cell.Right.B) * 0.2;
            double perpendicularSum = (cell.GetCellneighbour(7).B + cell.GetCellneighbour(1).B + cell.GetCellneighbour(3).B + cell.GetCellneighbour(5).B) * 0.2;
            double middle = cell.B * -1;
            return cornerSum + perpendicularSum + middle;
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
