using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Message
    {
        //private field
        private string _message;

        //public property hiding private field
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        //read the message to encrypt from a file
        public void readMessageFromFile(string filename)
        {
            //Read text from a file
            //Could we do this any better?
            message = File.ReadAllText(filename);
        }

        //read the message to encrypt from input
        public void readMessageFromInput()
        {
            Console.WriteLine("Enter your message to encode...");
            message = Console.ReadLine();
        }
    }
}
