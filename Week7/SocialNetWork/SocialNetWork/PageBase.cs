using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetWork
{
    public abstract class PageBase : IObserver
    {
        protected String text;
        protected RichTextBox displayBox;
        protected SocialNetWorkSubject subject;

        public PageBase(String text, RichTextBox displayBox, SocialNetWorkSubject subject)
        {
            this.text = text;
            this.displayBox = displayBox;
            this.subject = subject;
            subject.AddObserver(this);
        }

        public abstract void Display();

        public abstract void Update(string text);
    }
}
