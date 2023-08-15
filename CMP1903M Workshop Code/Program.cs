using CMP1903M_Workshop_Code;
using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 5
            //Challenge: What are the valid pass phrases?
            //
            TextFile codesArray = new TextFile("week5codes.txt");

            try
            {
                codesArray.PrintEachLine();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////\n");

            Dictionary<string, bool> isValid = codesArray.isValid();
            foreach (KeyValuePair<string, bool> kvp in isValid)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(" ");



            //Week 5
            //Task 1: Add a page to the 'history'
            //Task 2: Add exceptions
            //Task 3: Use custom exceptions

            //example of creating a page with a title and URL
            //Test... remove this when you have seen it working
            Page p = new Page("Test Page", "http://www.lincoln.ac.uk");
            //Console.WriteLine(p.Address);
            //.......

            //creating a new, empty history
            History h1 = new History();
            h1.pop();


        }
    }
}