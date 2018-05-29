using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetWork
{
    public class SocialNetWorkSubject : ISubject
    {
        private List<PageBase> observerList;
        private String text;

        public SocialNetWorkSubject(String text)
        {
            this.text = text;
            observerList = new List<PageBase>();
        }

        public void AddObserver(PageBase o)
        {
            observerList.Add(o);
        }

        public void NotifyObserver(String text)
        {
            this.text = text;

            foreach (PageBase currentObserver in observerList)
            {
                currentObserver.Update(text);
                currentObserver.Display();
            }
        }

        public void RemoveObserver(PageBase o)
        {
            observerList.Remove(o);
        }
    }
}
