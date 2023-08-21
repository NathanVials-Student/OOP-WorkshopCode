//using CMP1903M_Workshop_Code;
using System;

namespace CMP1903M_Workshop_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 7
            //Challenge: Find the train station gate passcodes
            //
            //range = 147981(147,999) – 691423(689,999)
            //valid if - any two adjacent numbers are the same, numbers always increase or stay the same
            









            //Week 7
            //Detached = 1, semi = 2, terrace = 3, unknown = 4
            List<House> houses = new List<House>();
            houses.Add(new House(1, "1, The Street, Lincoln, Lincolnshire, LN1 0AB", 100000, 4, true, 2));
            houses.Add(new House(2, "5, The Street, Lincoln, Lincolnshire, LN1 0AB", 130000, 4, true, 1));
            houses.Add(new House(3, "58 Christopher Drive", 300000, 4, false, 4));

        

            var result = from h in houses
                         where h.propertyType == Enums.PType.SemiDetached
                         select h;

            

            List<Property> properties = new List<Property>();
            foreach (House h in houses)
            {
                properties.Add(h);
            }

            properties.Add(new Shop(4, "Primark", 500000, 300.8785F, 1, 1));
            properties.Add(new Industrial(5, "Bean Factory", 400000, 500.45F, 1, 2));

            foreach (Property p in properties)
            {
                Console.WriteLine($"Address: {p.Address}");
                Console.WriteLine($"Value: {p.Value}");
                //Console.WriteLine($"Type of Property: {p.propertyType}");
                //if (p.GetType() == typeof(House))
                Console.WriteLine();
            }
        }
    }
}
