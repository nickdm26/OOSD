using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("Tick tock");
        }
    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end Beeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;
        private Thread demoThread;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;            
        }

        delegate void ArgReturningVoidDelegate();

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            this.demoThread = new Thread(new ThreadStart(this.setControl));
            this.demoThread.Start();

            //spinBox.Value++;
        }

        public void setControl()
        {
            if (this.spinBox.InvokeRequired)
            {
                ArgReturningVoidDelegate ar = new ArgReturningVoidDelegate(setControl);
                spinBox.Invoke(ar);
            }
            else
            {
                this.spinBox.Value++;
            }
        }
    } // end Counter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;
        private Thread TimeThread;
        private DateTime currDateTime;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            this.TimeThread = new Thread(new ThreadStart(this.setControl));
            this.TimeThread.Start();

            currDateTime = e.currentTime;

           // listBox.Items.Add(currDateTime.ToString());
        }

        delegate void ArgReturningVoidDelegate();

        public void setControl()
        {
            if (this.listBox.InvokeRequired)
            {
                ArgReturningVoidDelegate ar = new ArgReturningVoidDelegate(setControl);
                listBox.Invoke(ar);
            }
            else
            {
                //DateTime currDateTime = e.currentTime;
                listBox.Items.Add(currDateTime.ToString());
            }
        }
    } // end TimeDisplay
}
