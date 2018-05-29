using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public partial class Form1 : Form
    {
        Computer comp;
        Random rGen;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnGame.Checked)
            {
                comp = new GameComputer(listBox1, rGen);
            }else if (rbtnBusiness.Checked)
            {
                comp = new BusinessComputer(listBox1, rGen);
            }else if(rbtnMultimedia.Checked)
            {
                comp = new MultimediaComputer(listBox1, rGen);
            }else
            {
                comp = new LaptopComputer(listBox1, rGen);
            }
            comp.ChooseSpecs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rGen = new Random();
            comp = new GameComputer(listBox1, rGen);
        }
    }
}
