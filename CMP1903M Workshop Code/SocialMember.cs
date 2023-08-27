using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class SocialMember : GolfClubMemberBase
    {
        //social member of the golf club
        //constructor
        public SocialMember(string n, DateTime b, string e, string p) : base(n, b, e, p) { }

        //methods
        public override void emailAlert(Message m)
        {
            //no tounaments, no weather, no voting, fac(3) only 
            if (m.MessageType == Enums.mtype.Facilities)
            {
                Console.WriteLine(Name);
                Output.email(m);
            }
            
        }

        public override void textAlert(Message m)
        {
            if (m.MessageType == Enums.mtype.Facilities)
            {
                Console.WriteLine(Name);
                Output.txt(m);
            }
            
        }
    }
}
