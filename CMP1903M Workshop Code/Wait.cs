using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class Wait
    {
        //properties
        Queue<string> nameQ = new Queue<string>();


        //methods
        public void addToQueue(string n, NameCollection names)
        {
            if (names.removeName(n))
            {
                nameQ.Enqueue(n);
            }
        }
        public void removeFromQueue()
        {
            nameQ.Dequeue();
        }
        public void status()
        {
            string queueLength = nameQ.Count.ToString();
            Console.WriteLine("{0} Names in Q:", queueLength);

            foreach (string n in nameQ)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}
