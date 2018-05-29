using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public class LaptopComputer : Computer
    {
        public LaptopComputer(ListBox displayBox, Random rGen) : base(displayBox, rGen)
        {
            computerFactory = new LaptopComputerFactory();
        }
    }
}
