using CMP1903M_Workshop_Code;
using System;
using System.Diagnostics.Metrics;

namespace CMP1903M_Workshop_Code
{
    class Program
    {
        public delegate void delegateWriter(string message);
        public delegate void delegateReader();
        static void Main(string[] args)
        {
            //Week 10
            //Using delegates
            //File is created here in the same dir as the exe
            //Changethe path for somewhere else
            Writer writer = new Writer("C:\\Users\\natha\\Documents\\log.txt");
            delegateWriter writer1 = writer.write;

            writer1("Hello");

            writer.flush();

            writer.close();

            Reader reader = new Reader("C:\\Users\\natha\\Documents\\log.txt");
            delegateReader reader1 = reader.output;
            reader1();

        }
    }
}
