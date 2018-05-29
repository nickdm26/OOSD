using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetWork
{
    public class Friend1 : PageBase
    {
        public Friend1(string text, RichTextBox displayBox, SocialNetWorkSubject subject) : base(text, displayBox, subject)
        {
        }

        public override void Display()
        {
            //displayBox.Clear();
            String format = "ddd d MMM, yyyy HH:mm:ss";
            DateTime localTime = DateTime.Now;
            //displayBox.SelectionFont = new FontStyle.Bold;
            displayBox.Text += localTime.ToString(format) + "\n";
            displayBox.Text += text + "\n";
            displayBox.BackColor = System.Drawing.Color.Red;
            
        }

        public override void Update(string text)
        {
            this.text = text;
        }
    }
}
