using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        public int LinqCount;
        public int PrimeCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Task LinqMethod = Task.Run(() => DisplayLinqPrimes());

            TaskAwaiter awaiter = LinqMethod.GetAwaiter();
            awaiter.OnCompleted(() => listBox1.Items.Add(LinqCount.ToString()));

            
        }

        public void DisplayLinqPrimes()
        {
            int num = (int)numericUpDown1.Value;
            int whatAmI = Enumerable.Range(2, num).Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));
            LinqCount = whatAmI;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            //Task<string> primeCountTask = DisplayPrimes();
           // string output = await primeCountTask;
            //DisplayPrimes();

            listBox2.Items.Add(PrimeCount);
        }

        public string  DisplayPrimes()
        {
            int num = (int)numericUpDown1.Value;
            int count = 0;

            for (int i = 2; i < num; i++)
            {
                if (isPrimeNum(i))
                {
                    count++;
                }
            }

            PrimeCount = count;
            return count.ToString();
        }

        public bool isPrimeNum(int num)
        {
            bool isPrime = false;

            for (int k = 2; k < num; k++)
            {
                if(num == k)
                {
                    break;
                }else if (k == num -1)
                {
                    isPrime = true;
                }else if ((num % k) == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }

            return isPrime;
        }
    }
}
