using CMP1903M_Workshop_Code;
using System;
using System.Diagnostics.Metrics;

namespace CMP1903M_Workshop_Code
{
    class Program
    {

        static void sendMessage(Message m, MemberList ml)
        {
            foreach (GolfClubMemberBase member in ml.AllMembers)
            {
                //Console.WriteLine(member.Name);

                if (m.PlatformType == Enums.ptype.Email)
                {
                    //mem.emailAlert();
                    member.emailAlert(m);
                  
                }
                if (m.PlatformType == Enums.ptype.Text)
                {
                    member.textAlert(m);
             
                }
                if (m.PlatformType == Enums.ptype.Both)
                {
                    member.emailAlert(m);
                    member.textAlert(m);
                   
                }
                //Console.WriteLine("Message to {0} Failed", member.Name);
                //return false;
            }
            
            
        }


        static void Main(string[] args)
        {
            //Week 9
            //Golf Club Management
            Console.WriteLine("**Welcome to the Golf Club Membership App**");

            //create list from member list class
            MemberList memberList = new MemberList();
            memberList.addMember(new Member("Fred", new DateTime(1995, 01, 01), "Fred@gmail", "0116"));
            //memberList.addJuniorMember(new JuniorMember("Freda", new DateTime(2004, 01, 01), "Freda@gmail", "0117"));
            memberList.addSocialMember(new SocialMember("Freds", new DateTime(1970, 10, 10), "Freds@gmail", "0118"));
            memberList.addJuniorMember(new JuniorMember("Fredaa", new DateTime(2009, 01, 01), "Fredaa@gmail", "0119"));
            //memberList.outputList();
            //Console.WriteLine(" ");

            //messages t, w, f, v
            Message m1 = new Message("Tournament", 1, 1);
            Message m2 = new Message("Weather", 2, 2);
            Message m3 = new Message("Facilities", 3, 3);
            Message m4 = new Message("Voting", 4, 1);

            List<Message> messages = new List<Message> { m1, m2, m3, m4};

            //sendMessage(m3, memberList);
            foreach (Message m in messages)
            {
                sendMessage(m, memberList);
            }

            Member Nathan = new Member("Nathan", new DateTime(2004, 05, 10), "nathanvials4@gmail.com", "0759");
            Nathan.recordScore(1);
            Nathan.recordScore(2);
            Nathan.recordScore(3);
            Nathan.recordScore(4);
            Nathan.recordScore(5);
            Nathan.recordScore(6);
            Nathan.recordScore(7);
            Nathan.recordScore(8);
            Nathan.recordScore(9);
            Nathan.recordScore(10);
            Nathan.recordScore(11);
            Nathan.recordScore(12);
            Nathan.recordScore(13);
            Nathan.recordScore(14);
            Nathan.recordScore(15);
            Nathan.recordScore(16);
            Nathan.recordScore(17);
            Nathan.recordScore(18);
            Nathan.recordScore(19);
            Nathan.recordScore(20);
            Nathan.recordScore(21);
            Nathan.recordScore(22);

            Nathan.outputScores();

        }
    }
}
