using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CMP1903M_Workshop_Code
{
    class Member : GolfClubMemberBase
    {
        //'Normal' member of Golf Club
        //properties
        Queue<int> Scores = new Queue<int>();


        //Constructor
        public Member(string n, DateTime b, string e, string p) : base(n, b, e, p) { }

        //methods
        public override void emailAlert(Message m)
        {
            Console.WriteLine(Name);
            Output.email(m);
            
            if (m.MessageType == Enums.mtype.Voting)
            {
                vote();
            }
        }

        public override void textAlert(Message m)
        {
            Console.WriteLine(Name);
            Output.txt(m);
        }

        public bool vote()
        {
            Console.WriteLine("Vote y/n");
            string choice = Console.ReadLine().ToString();

            if (choice == "y")
            {
                return true;
            }

            return false;
        }

        public void recordScore(int s)
        {
            if (Scores.Count < 20)
            {
                Scores.Enqueue(s);
            }
            else
            {
                Scores.Dequeue();
                Scores.Enqueue(s);
            }
            
        }

        public void recordScore(int s, string m)
        {
            if (Scores.Count < 20) 
            {
                Console.WriteLine(m);
                Scores.Enqueue(s);
            }
            else
            {
                Console.WriteLine(m);
                Scores.Dequeue();
                Scores.Enqueue(s);
            }

        }

        public void outputScores()
        {
            Console.WriteLine("{0} Recent Scores:", Name);
            foreach (var s in Scores)
            {
                Console.WriteLine(s);
            }
        }
    }
}
