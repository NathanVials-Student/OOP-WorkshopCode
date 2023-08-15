using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class TextFile
    {
        //properties
        public string[] _codes;

        //constructors
        public TextFile(string fileName)
        {
            try
            {
                _codes = File.ReadAllLines(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        //methods
        public void PrintEachLine()
        {
            if (_codes == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (string code in _codes)
                {
                    Console.WriteLine($"{code}");
                }
            }
            
        }

        public Dictionary<string, bool> isValid()
        {
            bool valid = false;
            Dictionary<string, bool> validDic = new Dictionary<string, bool>();
            List<string> words = new List<string>();
            
            foreach (string code in _codes)
            {
                valid = true;
                foreach (string word in code.Split())
                {
                    foreach(string item in words)
                    {
                        if(word == item)
                        {
                            valid = false;
                        }
                    }
                    words.Add(word);
                }
                words.Clear();
                validDic.Add(code, valid);
            }
            return validDic;
        }
    }
}
