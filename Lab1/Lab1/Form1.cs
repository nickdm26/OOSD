using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void TwoToOne()
        {
            // You may not declare any more variables here.
            // No counters. None.

            const int columnCount = 4;
            const int rowCount = 2;

            Char[] oneDimensional = new Char[columnCount * rowCount];
            Char[,] twoDimensional = new Char[columnCount, rowCount]
                  { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };

            // convert to one dimension
            for (int c = 0; c < columnCount; c++)
                for (int r = 0; r < rowCount; r++)
                {
                    oneDimensional[]

                    // Add your code here. You may declare local
                    // variables here for computation
                }

            //printing one dimensional array
            for (int i = 0; i < columnCount * rowCount; i++)
                listBox1.Items.Add(oneDimensional[i]);
        }
    }
}
