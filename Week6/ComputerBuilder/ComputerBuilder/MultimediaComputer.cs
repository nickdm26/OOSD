using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public class MultimediaComputer : Computer
    {
        public MultimediaComputer(ListBox displayBox, Random rGen) : base(displayBox, rGen)
        {
            computerFactory = new MultimediaComputerFactory();
        }
    }
}
