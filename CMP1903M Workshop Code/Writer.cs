using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class Writer
    {
        //properties
        StreamWriter sw;
        //string FileName;

        //constructor
        public Writer(string path)
        {
            sw = File.CreateText(path);
        }

        public void write(string text)
        {
            sw.WriteLine(text);
        }

        public void flush()
        {
            sw.Flush();

        }

        public void close()
        {
            sw.Close();
        }

    }
}
