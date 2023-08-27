using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    public class GolfClubMemberBase
    {
        //Base class GolfClubMember
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int ID { get; set; }
        public bool Vote { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public GolfClubMemberBase(string name, DateTime bd, string email, string phone)
        {
            Name = name;
            Birthday = bd;
            Email = email;
            Phone = phone;

            //calculate age
            calculateAge();
        }

        void calculateAge()
        {
            //TODO: Does this work for all ages?
            var now = DateTime.Today;
            Age = now.Year - Birthday.Year;
        }

        public virtual void emailAlert(Message m)
        {
            //Default 
            Console.WriteLine("Default email alert");
        }

        public virtual void textAlert(Message m)
        {
            //default
            Console.WriteLine("Default text alert");
        }
    }
}
