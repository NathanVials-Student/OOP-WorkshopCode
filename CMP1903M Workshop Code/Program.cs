using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //(-4, -5) and (-1, -1) describe two points. What is the distance between them?
            int x1 = -4;
            int y1 = -4;

            int x2 = -1;
            int y2 = -1;


            int x3 = x1 - x2;
            int y3 = y1 - y2;

            int x4 = (int)Math.Pow(x3, 2);
            int y4 = (int)Math.Pow(y3, 2);

            int z1 = x4 + y4;

            int answer1 = (int)Math.Sqrt(z1);
            //Console.WriteLine(answer1);

            //Problem 2
            //What is the denominator of the slope between these points?
            //m=(y2-y1)/(x2-x1)

            int answer2 = (y2-y1)/(x2-x1);
            //Console.WriteLine(answer2);

            //Problem 3
            //What is the greatest common divisor (GCD) of 1124 and 136?
            var firstDivisors = new List<int>();
            
            for (int i = 3; i < ((1124/2)+1); i++)
            {
                if (1124 % i == 0)
                {
                    firstDivisors.Add(i);
                    //count++;
                }
            }

            var secondDivisors = new List<int>();

            for (int i = 3; i < ((136/2)+1); i++)
            {
                if (136 % i == 0)
                {
                    secondDivisors.Add(i);
                }
            }

            var commonDivisors = new List<int>();

            foreach (int i in firstDivisors)
            {
                foreach (int j in secondDivisors)
                {
                    if (i == j)
                    {
                        commonDivisors.Add(j);
                    }
                }
            }

            int length = commonDivisors.Count;
            int answer3 = commonDivisors[length - 1];
            Console.WriteLine(answer3);

            //Problem 4
            //What is the remainder, when you divide the square of the sum of the first ten natural numbers by ten?
        }
    }
}
