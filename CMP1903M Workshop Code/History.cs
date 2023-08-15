using CMP1903M_Workshop_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class History
    {
        //properties
        private Stack<Page> history;

        //constructor
        public History()
        {
            history = new Stack<Page>();
        }

        //methods
        public void push(Page p)
        {
            history.Push(p);
        }


        public void pop()
        {
            if (history.Count == 0)
            {
                throw new EmptyHistoryException("Bad");
            }
            history.Pop();
        }
    }
}
