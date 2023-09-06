using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class Reader
    {
        //properties
        string[] Text;

        //constructor
        public Reader(string path)
        {
            //var lines = File.ReadAllLines(path);
            Text = File.ReadAllLines(path);
        }

        //methods
        public void output()
        {
            foreach (string line in Text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
