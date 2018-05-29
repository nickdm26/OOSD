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
    public class GameComputerFactory : IComputerFactory
    {
        public GraphicsCard createGraphicsCard(int graphicCode)
        {
            GraphicsCard newGraphics = null;

            switch (graphicCode)
            {
                case 0:
                    newGraphics = new GTX1080Ti();
                    break;
                case 1:
                    newGraphics = new GTX980();
                    break;
                case 2:
                    newGraphics = new Radeon_R9_Fury_X();
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
                    newProcessor = new i7_7700K();
                    break;
                case 1:
                    newProcessor = new i7_6700();
                    break;
                case 2:
                    newProcessor = new Ryzen_7_1800X();
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
                    newRam = new _16GB();
                    break;
                case 1:
                    newRam = new _32GB();
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
                    newMonitor = new Acer_Predator_XB241H();
                    break;
            }
            return newMonitor;
        }
    }
}
