//using CMP1903M_Workshop_Code;
using System;

namespace CMP1903M_Workshop_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 8
            //Challenge: Get a Luber to find your friends for the night out..!
            //
            var captcha = File.ReadAllLines("captcha.txt");
            string strCode = captcha[0];
            //Console.WriteLine(strCode);


            int count = 0;
            int total = 0;
            while (count < strCode.Length - 1)
            {
                string strNum = strCode[count].ToString();
                int num = int.Parse(strNum);

                string strNextNum = strCode[count + 1].ToString();
                int nextNum = int.Parse(strNextNum);

                //Console.WriteLine(num);
                if (num == nextNum)
                {
                    total += num;
                }

                count++;
            }

            string strFirstNum = strCode[0].ToString(); 
            string strLastNum = strCode[strCode.Length - 1].ToString();
            
            int firstNum = int.Parse(strFirstNum);
            int lastNum = int.Parse(strLastNum);
            if (firstNum == lastNum)
            {
                total += lastNum;
            }
        //Console.WriteLine(total);




        //Week 8
        // Bank Accounts
        //AccountNumber: 012345 AccountName: aaaa Balance: 0  AccountNumber: 012346 AccountName: bbbb Balance: 10
        //AccountNumber: 012347 AccountName: cccc Balance: 125 AccountNumber: 012348 AccountName: dddd Balance: 0
        //AccountNumber: 012349 AccountName: eeee Balance: 10

            //basic accounts
            BasicAccount account1 = new BasicAccount(012345, 0.0M, "aaaa");
            BasicAccount account2 = new BasicAccount(012346, 10.0M, "bbbb");
            BasicAccount account3 = new BasicAccount(012347, 125.0M, "cccc");
            BasicAccount account4 = new BasicAccount(012348, 0.0M, "aaaa");
            BasicAccount account5 = new BasicAccount(012349, 10.0M, "eeee");

            //AccountNumber: 012350 AccountName: ffff Balance: 0 Overdraft: 0 AccountNumber: 012351 AccountName: gggg Balance: 100 Overdraft: 100
            //AccountNumber: 012352 AccountName: hhhh Balance: 125 Overdraft: 50 AccountNumber: 012353 AccountName: iiii Balance: 0 Overdraft: 0
            //AccountNumber: 012354 AccountName: jjjj Balance: 10 Overdraft: 0

            //premier accounts
            PremierAccount Paccount1 = new PremierAccount(012350, 0.0M, "ffff", 0.0M);
            PremierAccount Paccount2 = new PremierAccount(012351, 100.0M, "gggg", 100.0M);
            PremierAccount Paccount3 = new PremierAccount(012352, 125.0M, "hhhh", 50.0M);
            PremierAccount Paccount4 = new PremierAccount(012353, 0.0M, "iiii", 0.0M);
            PremierAccount Paccount5 = new PremierAccount(012354, 10.0M, "jjjj", 0.0M);

            //create list
            List<AccountBase> allAccounts = new List<AccountBase> { account1, account2, account3, account4, account5, Paccount1, 
                                                                Paccount2, Paccount3, Paccount4, Paccount5};

            var list = from account in allAccounts
                       where account.Balance is 0.0M
                       select account;

            foreach (var account in list)
            {
                //Console.WriteLine("{0}, {1}", account.AccountName, account.AccountNumber);
                account.output();
            }
        }
    }
}
