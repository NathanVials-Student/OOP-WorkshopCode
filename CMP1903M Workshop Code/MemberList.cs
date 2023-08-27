using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class MemberList
    {
        //properties
        public List<GolfClubMemberBase> AllMembers;

        //constructor
        public MemberList()
        {
            AllMembers = new List<GolfClubMemberBase>();
        }

        //methods
        public void addMember(Member m)
        {
            AllMembers.Add(m);
        }
        public void addJuniorMember(JuniorMember m)
        {
            if (m.IsYoungEnough)
            {
                AllMembers.Add(m);
            }
            else
            {
                Console.WriteLine("Member is too old to be a Junior Member");
            }
        }
        public void addSocialMember(SocialMember m)
        {
            AllMembers.Add(m);
        }
        public void outputList()
        {
            foreach (GolfClubMemberBase m in AllMembers)
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
