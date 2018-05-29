using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metronome
{

    public partial class Form1 : Form
    {
        private Metronome mainMetronome;
        private Beeper mainBeeper;
        private Counter mainCounter;
        private TimeDisplay mainTimeDisplay;
        private Thread tmainMetronome;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMetronome = new Metronome(1000, this);
            mainBeeper = new Beeper(mainMetronome, "blip1.wav");
            mainCounter = new Counter(mainMetronome, numericUpDown1);
            mainTimeDisplay = new TimeDisplay(mainMetronome, listBox1);

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmainMetronome = new Thread(mainMetronome.start);
            int currInterval = Convert.ToInt16(textBox1.Text);
            mainMetronome.Interval = currInterval;
            //mainMetronome.start();
            tmainMetronome.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        public void clearBuffer()
        {
            Application.DoEvents();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmainMetronome.Abort();
            listBox1.Items.Clear();
            numericUpDown1.Value = 0;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            // Code needed here to stop the metronome
        }
    } // end Form
} // end namespace
