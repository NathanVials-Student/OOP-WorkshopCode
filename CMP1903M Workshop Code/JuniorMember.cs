using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class JuniorMember : GolfClubMemberBase
    {
        //Golf Club membership for under 18s
        //properties
        public bool IsYoungEnough = true;

        //constructor
        public JuniorMember(string n, DateTime b, string e, string p) : base(n, b, e, p)
        {
            if (Age > 18)
            {
                Console.WriteLine("Too Old");
                IsYoungEnough = false;
            }
        }

        //methods
        public override void emailAlert(Message m)
        {
            //no voting(4)
            if (m.MessageType != Enums.mtype.Voting)
            {
                Console.WriteLine(Name);
                Output.email(m);
            }
            
        }

        public override void textAlert(Message m)
        {
            if (m.MessageType != Enums.mtype.Voting)
            {
                Console.WriteLine(Name);
                Output.txt(m);
            }
            
        }
    }
}
