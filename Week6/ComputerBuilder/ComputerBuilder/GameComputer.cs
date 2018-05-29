using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public class GameComputer : Computer
    {
        public GameComputer(ListBox displayBox, Random rGen) : base (displayBox, rGen)
        {
            computerFactory = new GameComputerFactory();
        }
    }
}
