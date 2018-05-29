using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPrograss
{
    public class ProgressObserver
    {
        protected ProgressSubject subject;
        private NumericUpDown updown;
        private TrackBar bar;
        private ProgressBar pbar;

        public ProgressObserver(ProgressSubject subject, NumericUpDown updown, TrackBar bar, ProgressBar pbar)
        {
            this.updown = updown;
            this.bar = bar;
            this.pbar = pbar;
            this.subject = subject;
            ProgressSubject.ProgressEventHandler handler = new ProgressSubject.ProgressEventHandler(ProgressHandlerMethod);
            subject.progressEvent += handler;
        }

        public void ProgressHandlerMethod(object progressSubject, EventArgs e)
        {
            if(updown != null)
            {
                updown.Value++;
            }
            if(bar != null)
            {
                bar.Value++;
            }
            if(pbar != null)
            {
                pbar.Value++;
            }

        }
    }
}
