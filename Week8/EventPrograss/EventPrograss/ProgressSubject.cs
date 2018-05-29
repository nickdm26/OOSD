using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPrograss
{
    public class ProgressSubject
    {
        public delegate void ProgressEventHandler(object progressSubject, EventArgs e);
        public event ProgressEventHandler progressEvent;

        public void onClickEvent()
        {
            EventArgs e = new EventArgs();

            if(progressEvent != null)
            {
                progressEvent(this, e);
            }
        }


    }
}
