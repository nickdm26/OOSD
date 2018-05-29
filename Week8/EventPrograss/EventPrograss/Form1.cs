using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPrograss
{
    public partial class Form1 : Form
    {
        ProgressSubject subjectWithEvent;
        ProgressObserver TrackBar;
        ProgressObserver ProgressBar;
        ProgressObserver UpDown;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subjectWithEvent = new ProgressSubject();
            TrackBar = new ProgressObserver(subjectWithEvent, null, trackBar1, null);
            ProgressBar = new ProgressObserver(subjectWithEvent, null, null, progressBar1);
            UpDown = new ProgressObserver(subjectWithEvent, numericUpDown1, null, null);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(800);
                subjectWithEvent.onClickEvent();
            }
        }
    }
}
