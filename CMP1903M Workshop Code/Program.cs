using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 4
            //Challenge:  Determine what the value of the accumulator will be when the code is finished running
            //
            //Read each line of the input.
            //Determine whether it is a 'acc' or 'jmp' command for each line
            //Determine the value on each line
            //Find the value of 'acc' at the end
            //HINT: We can read each line as an array (or List) of strings; check [0] for 'a' or 'j', then check [4] and [5] for the values
            //OR: we could split each string at the space into an operation string and a value string
            //Can we read line by line instead of storing in a collection?
            string[] codes = File.ReadAllLines("week4codes.txt");
            int fileLength = codes.Length;

            int acc = 0;
            int count = 0;
            bool stop = false;

            while (stop != true)
            {
                string code = codes[count]; 
                Console.WriteLine(code);

                int length = code.Length;
                string op = code.Substring(0, 3);
                string plusMinus = code[4].ToString();
                string amount = code.Substring(5);
                int intAmount = int.Parse(amount);

                if (op == "acc")
                {
                    if (plusMinus == "+")
                    {
                        acc = acc + intAmount;
                    }
                    if (plusMinus == "-")
                    {
                        acc = acc - intAmount;
                    }
                    Console.WriteLine(acc);
                }
                if (op == "jmp")
                {
                    count = count + intAmount;
                    Console.WriteLine(acc);
                }
                if(op == "nop")
                {
                    Console.WriteLine(acc);
                }
                Console.WriteLine("");

                count++;
                if (count == fileLength)
                {
                    stop = true; 
                }
            }

            string str = "Hello there";
            string subStr = str.Substring(0, 5);
            Console.WriteLine(subStr);




            //Week 4
            //Task 1: Add constructors to the Person() class
            //Task 2: create a 'screenName' field within Person
            //Task 3: Create a 'collection' of Person, iterate (i.e. loop) through the collection outputting data for each Person


        }
    }
}
