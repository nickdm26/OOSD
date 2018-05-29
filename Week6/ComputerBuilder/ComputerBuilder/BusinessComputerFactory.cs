using ComputerBuilder.GraphicsCardComponents;
using ComputerBuilder.Processors;
using ComputerBuilder.RamComponents;
using ComputerBuilder.MonitorComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class BusinessComputerFactory : IComputerFactory
    {
        public GraphicsCard createGraphicsCard(int graphicCode)
        {
            GraphicsCard newGraphics = null;

            switch (graphicCode)
            {
                case 0:
                    newGraphics = new HD_Graphics__4000();
                    break;
                case 1:
                    newGraphics = new HD_Graphics_6000();
                    break;
                case 2:
                    newGraphics = new Quadro_K2000();
                    break;
            }
            return newGraphics;
        }

        public Processor createProcessor(int processorCode)
        {
            Processor newProcessor = null;

            switch (processorCode)
            {
                case 0:
                    newProcessor = new i5_3570K();
                    break;
                case 1:
                    newProcessor = new i5_7600K();
                    break;
                case 2:
                    newProcessor = new FX_8350();
                    break;
            }
            return newProcessor;
        }

        public Ram createRam(int ramCode)
        {
            Ram newRam = null;

            switch (ramCode)
            {
                case 0:
                    newRam = new _6GB();
                    break;
                case 1:
                    newRam = new _8GB();
                    break;
            }
            return newRam;
        }

        public Monitor createMonitor(int monitorCode)
        {
            Monitor newMonitor = null;

            switch (monitorCode)
            {
                case 0:
                    newMonitor = new Dell_UltraSharp__U2412M();
                    break;
            }
            return newMonitor;
        }
    }
}
