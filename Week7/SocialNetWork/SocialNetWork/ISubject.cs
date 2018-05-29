using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetWork
{
    public interface ISubject
    {
        void AddObserver(PageBase o);
        void RemoveObserver(PageBase o);
        void NotifyObserver(String text);
    }
}
