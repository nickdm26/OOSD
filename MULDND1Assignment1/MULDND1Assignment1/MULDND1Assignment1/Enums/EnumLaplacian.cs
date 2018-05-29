using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ELaplacianFunctions { CONVOLUTION, DELTA_MEANS, PERPENDICULAR_NEIGHBOURS }

namespace MULDND1Assignment1
{
    public class EnumLaplacian
    {
        public ELaplacianFunctions LaplacianFunction { get; set; }
    }
}
