using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class BasicAccount : AccountBase, IAccount
    {

        //Constructor setting default balance of 0
        public BasicAccount()
        {
            Balance = 0.0M;
            AccountNumber = 0;
            AccountName = "default";
        }

        //constructor setting balance to value
        public BasicAccount(int AccNum, decimal value, string AccName)
        {
            AccountNumber = AccNum;
            Balance = value;
            AccountName = AccName;
        }

        //Deposit method
        public bool Deposit(decimal value)
        {
            Balance += value;
            return true;
        }

        //withdraw method
        public bool Withdraw(decimal value)
        {
            if (Balance >= value)
            {
                //withdraw ok
                Balance -= value;
                return true;
            }
            else
            {
                //Withdraw too much for balance
                return false;
            }
        }

        public override void output()
        {
            Console.WriteLine("Basic Account - {0}\nAccountName - {1}\nBalance Remaining - {2}\n", 
                AccountNumber, AccountName, Balance);

        }
    }
}
