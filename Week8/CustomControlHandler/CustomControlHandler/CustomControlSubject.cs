using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public class CustomControlSubject
    {
        public delegate void ControlEventHandler(object controlSubject, CustomControlEventArgs ce);
        public event ControlEventHandler CustomEvent;

        public void onClickEvent()
        {
            CustomControlEventArgs ce = new CustomControlEventArgs();

            if (CustomEvent != null)
            {
                CustomEvent(this, ce);
            }
            
        }
    }
}
