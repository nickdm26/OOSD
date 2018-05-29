using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public interface IComputerFactory
    {
        Processor createProcessor(int processorCode);
        GraphicsCard createGraphicsCard(int graphicCode);
        Ram createRam(int ramCode);
        Monitor createMonitor(int monitorCode);
    }
}
