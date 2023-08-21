using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class Property
    {
        //auto-implemented properties
        public string Address { get; set; }
        public int Value { get; set; }
        public int ID { get; set; }

        public List<Property> search(List<Property> properties, int maxVal)
        {
            var result = from p in properties
                         where p.Value < maxVal
                         select p;

            List<Property> output = new List<Property>();
            foreach (var p in result)
            {
                output.Add(p);
            }
            return output;
        }
    }
}
