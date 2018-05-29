using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTester
{
    public class Stack
    {
        private List<String> StackList;

        public Stack()
        {
            StackList = new List<String>();
        }

        public void Push(String newString)
        {
            StackList.Add(newString);
        }

        public String Pop()
        {
            String deleted = StackList[StackList.Count - 1];
            StackList.Remove(StackList[StackList.Count - 1]);
            return deleted;
        }

        public String Peek()
        {
            return StackList[StackList.Count - 1];
        }

        public int Count()
        {
            return StackList.Count;
        }

        public bool IsEmpty()
        {
            if (StackList.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}