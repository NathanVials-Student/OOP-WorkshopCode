using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Atbash
    {
        public string encode(string text)
        {
            string output = "";
            for (int x = text.Length - 1; x > -1; x--)
            {
                output = output + text[x];
            }
            return output;
        }

        public string decode(string text)
        {
            string output = "";
            for ( int x = text.Length - 1; x > -1; x--)
            {
                output = output + text[x];
            }
            return output;
        }
    }
}