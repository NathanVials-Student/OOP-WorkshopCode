using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    public static class Output
    {
        public static void email(Message m)
        {
            Console.WriteLine($"Email: {m.Content}\n");
        }

        public static void txt(Message m)
        {
            Console.WriteLine($"TXT: {m.Content}\n");
        }
    }
}
