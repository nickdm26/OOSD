using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDemo
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
            for(int k = 0; k < 30; k++)
            {
                int num = ran.Next(100);
                richTextBox1.Text += num + "\n";
                ranNumbers.Add(num);
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ranNumbers = new List<int>();
            ran = new Random();
        }

        private bool isEven(int inputInteger)
        {
            bool isAnEvenNumber = ((inputInteger % 2) == 0);
            return isAnEvenNumber;
        }

        private bool lessThan10(int inputInteger)
        {
            bool isLessThan10 = (inputInteger < 10);
            return isLessThan10;
        }

        private void btnEvenNums_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Predicate<int> isOddPredicate = new Predicate<int>(isEven);
            List<int> oddNumbers = ranNumbers.FindAll(isOddPredicate);
            foreach(int num in oddNumbers)
            {
                richTextBox2.Text += num + "\n";
            }
        }

        private void btnLessThen10_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Predicate<int> isLessThen10Predicate = new Predicate<int>(lessThan10);
            List<int> oddNumbers = ranNumbers.FindAll(isLessThen10Predicate);
            foreach (int num in oddNumbers)
            {
                richTextBox2.Text += num + "\n";
            }
        }
    }
}
