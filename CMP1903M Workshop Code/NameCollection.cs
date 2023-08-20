using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class NameCollection
    {
        //class Names to hold your list of names and various methods

        //properties
        List<string> _names = new List<string>();

        //methods
        public void addName(string n)
        {
            _names.Add(n);
        }
        public void outputList()
        {
            foreach (string n in _names)
            {
                Console.WriteLine(n);
            }
        }
        public bool isNameInList(string n)
        {
            return _names.Contains(n);
        }
        public bool removeName(string n)
        {
            if (isNameInList(n))
            {
                _names.Remove(n);
                return true;
            }
            return false;
        }
    }
}
