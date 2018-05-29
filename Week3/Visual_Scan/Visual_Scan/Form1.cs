using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Scan
{
    public partial class Form1 : Form
    {
        Graphics Canvas;
        Manager manager;
        Color ResponseColor;
        Rectangle ScreenDimensions;
        int NoGoRate = 95;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Height = (this.Height / 100) * 75;
            panel2.Height = (this.Height / 100) * 25;
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, panel1.Height);
            Canvas = panel1.CreateGraphics();
            ScreenDimensions = new Rectangle(0, 0, panel1.Width, panel1.Height);
            ResponseColor = Color.FromName("Red");
            manager = new Manager(trkbWidth.Value, trkbHeight.Value, NoGoRate, ScreenDimensions, ResponseColor, Canvas);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            this.KeyPreview = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            manager.Stop();
        }

        private void trkbWidth_Scroll(object sender, EventArgs e)
        {
            manager.UpDateSettings(trkbWidth.Value, trkbHeight.Value, ResponseColor, NoGoRate);
        }

        private void trkbHeight_Scroll(object sender, EventArgs e)
        {
            manager.UpDateSettings(trkbWidth.Value, trkbHeight.Value, ResponseColor, NoGoRate);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            manager.ApplicationCycle();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            manager.Recated();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            manager.Recated();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            manager.Recated();
        }                

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            manager.Recated();
        }
    }
}
