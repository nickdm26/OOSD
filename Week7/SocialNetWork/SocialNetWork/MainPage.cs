using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetWork
{
    public class MainPage : PageBase
    {
        public MainPage(string text, RichTextBox displayBox, SocialNetWorkSubject subject) : base(text, displayBox, subject)
        {
        }

        public override void Display()
        {
            String format = "ddd:HH:mm:ss";
            DateTime localTime = DateTime.Now;
            displayBox.Text = text + " Hi";
        }

        public override void Update(string text)
        {
            this.text = text;
        }
    }
}
