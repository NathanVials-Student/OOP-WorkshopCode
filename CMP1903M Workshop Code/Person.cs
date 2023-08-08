using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CMP1903MWorkshopCode
{
    class Person
    {
        //fields
        private string _firstName;
        private string _secondName;
        private string _email;
        private string _screenName; 

        //properties



        //constructors
        public Person()
        {
            _firstName = "DefaultFirstName";
            _secondName = "DefaultSecondName";
            _email = "EmailNotSet";
            _screenName = "DD0000";
        }

        public Person(string fname, string sname)
        {
            _firstName= fname;
            _secondName= sname;
            _email = "EmailNotSet";

            _screenName = fname[0].ToString() + sname[0];

            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                string randomNumber = rnd.Next(0, 9).ToString();
                _screenName+= randomNumber;
            }
        }

        public Person(string fname, string sname, string ename)
        {
            _firstName = fname;
            _secondName= sname;
            _email = ename;

            _screenName = fname[0].ToString() + sname[0];

            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                string randomNumber = rnd.Next(0, 9).ToString();
                _screenName += randomNumber;
            }
        }


        //methods
        public static string output(Person p)
        {
            string str =  string.Format("First Name - {0}, Second Name - {1}, Screen Name - {2}", p._firstName, p._secondName, p._screenName);
            return str;
        }

        public static List<Person> addPersonToList(List<Person> people, Person p)
        {
            people.Add(p);
            return people;
        }
    }
}
