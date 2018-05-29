using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public class CustomControlObserver
    {
        protected CustomControlSubject subject;
        protected Random ran;
        protected int code;
        private Button btn;

        public CustomControlObserver(CustomControlSubject subject, Button btn, Random ran)
        {
            this.ran = ran;
            code = ran.Next(100);
            this.subject = subject;
            this.btn = btn;
            CustomControlSubject.ControlEventHandler handler = new CustomControlSubject.ControlEventHandler(CustomHandlerMethod);
            subject.CustomEvent += handler;
        }

        public void CustomHandlerMethod(object customSubject, CustomControlEventArgs ce)
        {
            String message = "This is a custom handler." + "\n";
            message += "My code number is " + code + "\n";
            message += "My Type is " + this.GetType() + "\n";
            message += "I am responding to button: " + btn.Name;
            MessageBox.Show(message); 
        }
    }
}
