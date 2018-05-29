using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetWork
{
    public class Friend2 : PageBase
    {
        public Friend2(string text, RichTextBox displayBox, SocialNetWorkSubject subject) : base(text, displayBox, subject)
        {
        }

        public override void Display()
        {
            String format = "ddd d MMM, yyyy HH:mm:ss";
            DateTime localTime = DateTime.Now;
            displayBox.Text += localTime.ToString(format) + "\n";
            displayBox.Text += text + "\n";
            displayBox.BackColor = System.Drawing.Color.Blue;
        }

        public override void Update(string text)
        {
            this.text = text;
        }
    }
}
