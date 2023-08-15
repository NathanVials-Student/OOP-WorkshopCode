using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Page
    {
        //auto-implemented properties
        public string Title { get; set; }
        public Uri Address { get; set; }

        //constructor
        public Page(string t, string a)
        {
            Title = t;
            Address = new Uri(a);
        }


    }
}