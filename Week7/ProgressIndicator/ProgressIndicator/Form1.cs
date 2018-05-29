using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        FeedbackDelegate feedbackdelegateInstance;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void rbtnProgress_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTrack_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnSpin.Checked)
            {
                feedbackdelegateInstance = new FeedbackDelegate(updateSpinBox);
                slowMethod(feedbackdelegateInstance);
            }else if (rbtnProgress.Checked)
            {
                feedbackdelegateInstance = new FeedbackDelegate(updateProgressBar);
                slowMethod(feedbackdelegateInstance);
            }else
            {
                feedbackdelegateInstance = new FeedbackDelegate(updateTrackBar);
                slowMethod(feedbackdelegateInstance);
            }
            
        }

        public void slowMethod(FeedbackDelegate feedbackDelegate)
        {
            for(int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(40);
                feedbackdelegateInstance();
            }
                     
        }

        public delegate void FeedbackDelegate();

        public void updateSpinBox()
        {
            numericUpDown1.Value++;
        }

        public void updateProgressBar()
        {
            progressBar1.PerformStep();
        }

        public void updateTrackBar()
        {
            trackBar1.Value++;
        }

        
    }
}
