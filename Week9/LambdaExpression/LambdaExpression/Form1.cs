using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaExpression
{
    public partial class Form1 : Form
    {
        public List<int> ranNumbers;
        public Random ran;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRanNumbers_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 30; k++)
            {
                int num = ran.Next(100);
                richTextBox1.Text += num + "\n";
                ranNumbers.Add(num);
            }
        }

        private void btnEvenNums_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Predicate<int> isOddPredicate = new Predicate<int>(n => n % 2 == 0);
            List<int> oddNumbers = ranNumbers.FindAll(isOddPredicate);
            foreach (int num in oddNumbers)
            {
                richTextBox2.Text += num + "\n";
            }
        }

        private void btnLessThen10_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Predicate<int> isLessThen10Predicate = new Predicate<int>(n => n < 10);
            List<int> oddNumbers = ranNumbers.FindAll(isLessThen10Predicate);
            foreach (int num in oddNumbers)
            {
                richTextBox2.Text += num + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ranNumbers = new List<int>();
            ran = new Random();
        }
    }
}
