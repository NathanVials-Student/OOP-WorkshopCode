using CMP1903MWorkshopCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class Print
    {
        public static bool print(string str)
        {
            Console.WriteLine(str);
            return true;
        }

        public static void DTtrack(List<Person> people)
        {
            int listLength = people.Count;
            DateTime CurrentDT = DateTime.Now;

            //string dtString = string.Format("Date and Time - {}", CurrentDT.ToString());
            Console.WriteLine(CurrentDT);
            Console.WriteLine(listLength);
        }
    }
}
