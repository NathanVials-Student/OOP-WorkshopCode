//using CMP1903M_Workshop_Code;
using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 3
            //Challenge: Get the message from the encrypted text
            //
            //1. EITHER:    Read in the .txt file into a List of Strings (or anything else?)
            //   OR:        Read in each line one at a timen and get its maximum character 
            //2. For each string:
            //      Count each character in the string
            //      The maximum is the character
            //3. Output the unencrypted message.

            string[] codes = File.ReadAllLines("week3codes.txt");
            foreach (string code in codes)
            {
                //Console.WriteLine(code);
                Dictionary<string, int> letterDic = new Dictionary<string, int>();
                int count = 0;
                while (count < code.Length)
                {
                    //Console.WriteLine(code[count]);
                    if (letterDic.ContainsKey(code[count].ToString()))
                    {
                        letterDic[code[count].ToString()]++;
                    }
                    else
                    {
                        letterDic.Add(code[count].ToString(), 1);
                    }
                    count++;
                }
                foreach (KeyValuePair<string, int> letter in letterDic)
                {
                    //Console.WriteLine("{0} = {1}", letter.Key, letter.Value);
                }
                //Console.WriteLine(" ");
            }

            Console.WriteLine("Enter Message");
            string str = Console.ReadLine();
            Dictionary<string, string> morse = new Dictionary<string, string>()
            { {"A", ".-" },
            {"B", "-..."},
            {"C", "-.-." },
            {"D", "-.." },
            {"E", "." },
            {"F", "..-." },
            {"G", "--." },
            {"H", "...." },
            {"I", ".." },
            {"J", ".---" },
            {"K", "-.-" },
            {"L", ".-.." },
            {"M", "--" },
            {"N", "-." },
            {"O", "---" },
            {"P", ".--." },
            {"Q", "--.-" },
            {"R", ".-." },
            {"S", "..." },
            {"T", "-" },
            {"U", "..-" },
            {"V", "...-" },
            {"W", ".--" },
            {"X", "-..-" },
            {"Y", "-.--" },
            {"z", "--.." }};

            for (int i = 0; i < str.Length; i++)
            {
                string letter = str[i].ToString().ToUpper();
                string morseLetter = morse[letter];
                Console.Write(morseLetter);
                Console.Write(", ");

            }
            Console.WriteLine(" ");

            //Week 3
            //Task 1: create Message object, call the readTextFromInput() method
            //Task 2: create Atbash object Step 1: pass message to encode() method Step 2: put in the encode logic
            //Task 3: put in the decode logic to the decode() method, check if it works
            //Task 4: read text to encode from a file

            Message message = new Message();
            message.readMessageFromInput();
            
            Atbash encoder = new Atbash();
            string encodedMessage = encoder.encode(message.message);
            Console.WriteLine(encodedMessage);
        }
    }
}