using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Deck cards = new Deck();
            List<Hand> hands = new List<Hand>();
            for(int i = 0; i < 4; i++)
            {
                Hand currentHand = new Hand();
                hands.Add(currentHand);
                hands[i].FillHand(cards);
                hands[i].CalculateHCP();
                hands[i].sort();

                String direction;
                switch(i)
                {
                    case 0:
                        direction = "North";
                        break;
                    case 1:
                        direction = "East";
                        break;
                    case 2:
                        direction = "South";
                        break;
                    default:
                        direction = "West";
                        break;
                }

                richTextBox1.Text += "----------------------------------------------" + "\n" + direction + "\n";
                richTextBox1.Text += " " + hands[i].ToString() + "\n";
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
