using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 2
            //EITHER:
            //Read in the text file if you want (or are able) [HINT: read into a list of strings]
            //Split the first four numbers
            //List<string> streets = new List<string>();

            string[] streets = File.ReadAllLines("StreetCodes.txt");

            foreach (string street in streets)
            {
                Console.WriteLine(street);

                //multply first 4 digits together
                int count = 0;
                int firstResult = 1;

                while (count < 4)
                {
                    string strDigit = street[count].ToString();
                    int digit = int.Parse(strDigit);

                    firstResult = firstResult * digit;
                    count++;
                }
                Console.WriteLine(firstResult);
                
                //add up digits of first result
                string strResult = firstResult.ToString();
                count = 0;
                int secondResult = 0;

                while (count < strResult.Length)
                {
                    string strDigit = strResult[count].ToString();
                    int digit = int.Parse(strDigit);

                    secondResult = secondResult + digit;
                    count++;
                }
                //Console.WriteLine(secondResult);

                //if second result is 2 digits
                string strSecondResult = secondResult.ToString();
                if (strSecondResult.Length > 1)
                {
                    int digit1 = strSecondResult[0];
                    int digit2 = strSecondResult[1];
                    secondResult = digit1 + digit2;
                }
                Console.WriteLine(secondResult);
               


                //check against checksum
                int checksum = int.Parse(street[5].ToString());
                Console.WriteLine(checksum);

                if (checksum == secondResult)
                {
                    Console.WriteLine("Same");
                }

                Console.WriteLine(" ");
            }


            
            //Multiply all the numbers together in the 4 digit code (7*7*7*8)
            //Can do it by using the mod '%' operator and the divide '/' operator
            //Reduce streetCode by 1 digit each time through the loop
            


            //Add the digits of the multiplication total together
            //infinite loop until the total gets to one digit - the checksum
            //Use 'break;' to break out of the loop
            

            //Check if the final checksum is the same as the checksum in the street code.


        }
    }
}
