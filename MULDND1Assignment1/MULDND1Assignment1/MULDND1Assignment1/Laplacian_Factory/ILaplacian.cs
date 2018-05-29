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
     * ILaplacian interface is used to specify which methods must be used when implementing this interface 
     */
    public interface ILaplacian
    {
        double CalculateLaplacianValue_A(Cell cell);

        double CalculateLaplacianValue_B(Cell cell);

        double GetDiffusion_A();

        double GetDiffusion_B();
    }
}
