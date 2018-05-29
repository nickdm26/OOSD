using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public abstract class Computer
    {
        protected ListBox displayBox;
        protected Random rGen;
        protected IComputerFactory computerFactory;

        public Computer(ListBox displayBox, Random rGen)
        {
            this.displayBox = displayBox;
            this.rGen = rGen;
        }

        public void ChooseSpecs()
        {
            displayBox.Items.Clear();

            int processorChoice = rGen.Next(Constants.PROCESSOR_COUNT);
            int graphicsCardChoice = rGen.Next(Constants.GRAPHICSCARD_COUNT);
            int ramChoice = rGen.Next(Constants.RAM_COUNT);
            int monitorChoice = rGen.Next(Constants.MONITOR_COUNT);
            int totalPrice = 0;

            Processor currentProcessor = computerFactory.createProcessor(processorChoice);
            GraphicsCard currentGraphicsCard = computerFactory.createGraphicsCard(graphicsCardChoice);
            Ram currentRam = computerFactory.createRam(ramChoice);
            Monitor currentMonitor = computerFactory.createMonitor(monitorChoice);

            totalPrice += currentProcessor.Price;
            totalPrice += currentGraphicsCard.Price;
            totalPrice += currentRam.Price;
            totalPrice += currentMonitor.Price;

            displayBox.Items.Add("Price    Component");
            displayBox.Items.Add("- - - - - - - - - - - - - - - - - -");
            displayBox.Items.Add(currentProcessor.ToString());
            displayBox.Items.Add(currentGraphicsCard.ToString());
            displayBox.Items.Add(currentRam.ToString());
            displayBox.Items.Add(currentMonitor.ToString());
            displayBox.Items.Add("- - - - - - - - - - - - - - - - - -");
            displayBox.Items.Add("Total Price: " + totalPrice);


        }
    }
}
