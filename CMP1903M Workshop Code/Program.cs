using CMP1903M_Workshop_Code;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 6
            //Challenge: What are the valid barcode numbers on passenger's tickets?
            //

            //step 1 - sum all digits in odd positions
            //step 2 - sum all digits in even positions and multiply result by 3
            //step 3 - add two results, take final digit, take it away from 10, compare with check digit
            string[] barcodes = File.ReadAllLines("barcodes.txt");
            foreach (string barcode in barcodes)
            {
                //initialise useful collections/variables
                bool even = false;
                List<string> evens = new List<string>();
                List<string> odds = new List<string>();

                string strCheckDigit = barcode[12].ToString();
                int checkDigit = int.Parse(strCheckDigit);

                //populate lists of numbers at even and odd indexes
                for (int count = 0; count < 12;  count++)
                {
                    if (even)
                    {
                        evens.Add(barcode[count].ToString());
                        even = false;
                    }
                    else
                    {
                        odds.Add(barcode[count].ToString());
                        even = true;
                    }
                }

                //initialise result variables
                int evenResult = 0;
                int oddResult = 0;
                int result = 0;

                //calculate results
                foreach (string x  in evens)
                {
                    int num = int.Parse(x);
                    evenResult += num;
                }
                evenResult = evenResult * 3;

                foreach (string x in odds)
                {
                    int num = int.Parse(x);
                    oddResult += num;
                }

                result = evenResult + oddResult;
                string strResult = result.ToString();

                //find digit to compare to checkdigit from result
                int length = strResult.Length;
                string strLastDigit = strResult[length - 1].ToString();
                int lastDigit = int.Parse(strLastDigit);
                lastDigit = 10 - lastDigit;
                if (lastDigit == 10)
                {
                    lastDigit = 0;
                }

                //valid/invalid
                if (lastDigit == checkDigit)
                {
                    //Console.WriteLine("Valid\n");
                }
                else
                {
                    //Console.WriteLine("Invalid\n");
                }

            }



            //Week 6
            //Task 1: Using a List object
            //List called 'names' to hold a list of names
            static bool contains(List<string> names, string name)
            {
                foreach (string n in names)
                {
                    if (n == name)
                    {
                        Console.WriteLine("True");
                        return true;
                    }
                }

                Console.WriteLine("False");
                return false;
            }

            //Olivia, Oliver, Amelia, George, Isla, Harry, Ava, Noah, Emily, Jack 
            NameCollection names = new NameCollection();
            names.addName("Olivia");
            names.addName("Oliver");
            names.addName("Amelia");
            names.addName("George");
            names.addName("Isla");
            names.addName("Harry");
            names.addName("Ava");
            names.addName("Noah");
            names.addName("Emily");
            names.addName("Jack");

            names.outputList();
            Console.WriteLine(names.isNameInList("barbs"));
            Console.WriteLine(names.isNameInList("Jack"));

            Console.WriteLine(names.removeName("barbs"));
            Console.WriteLine(names.removeName("Jack"));
            names.outputList();

            Wait nameQueue = new Wait();
            nameQueue.addToQueue("Olivia", names);
            nameQueue.addToQueue("Amelia", names);
            nameQueue.status();

            names.outputList();


            //Check to see if some names are in the list...?
            //Create a simple search method to check if a name is in the list - don't use LINQ!
            //What about a simple sequential search (check each name in turn)
            //Add the names in the workshop task sheet to the list
            //Use 'Add()' or a list initialiser (List<string> names = new List<string>(){"Olivia", "Oliver", "etc"};)


            //Task 2: Use a class to hold your List
            //Task 3: Create a 'Wait' class to hold a Queue<> collection
            //Task 4: Use LINQ queries on your collection




        }
    }
}
