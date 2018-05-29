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
    public class MultimediaComputerFactory : IComputerFactory
    {
        public GraphicsCard createGraphicsCard(int graphicCode)
        {
            GraphicsCard newGraphics = null;

            switch (graphicCode)
            {
                case 0:
                    newGraphics = new GTX970();
                    break;
                case 1:
                    newGraphics = new GTX660();
                    break;
                case 2:
                    newGraphics = new Radeon_R7();
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
                    newProcessor = new A4_7300();
                    break;
                case 1:
                    newProcessor = new i3_6100();
                    break;
                case 2:
                    newProcessor = new Pentium_G4400();
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
                    newRam = new _2GB();
                    break;
                case 1:
                    newRam = new _4GB();
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
                    newMonitor = new LG_24MP88HV_S_24();
                    break;
            }
            return newMonitor;
        }
    }
}
