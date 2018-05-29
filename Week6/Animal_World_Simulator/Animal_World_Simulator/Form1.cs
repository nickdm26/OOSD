using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_World_Simulator
{
    public partial class Form1 : Form
    {

        Continent continent;
        Random rGen;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {

            continent = new NorthAmerica(ListBox, rGen, 3, canvas);
            continent.runSimulation();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            continent = new Australia(ListBox, rGen, 3, canvas);
            continent.runSimulation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rGen = new Random();
            canvas = panel1.CreateGraphics();
        }
    }
}
