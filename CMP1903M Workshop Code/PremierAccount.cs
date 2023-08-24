using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class PremierAccount: AccountBase, IAccount
    {
        public decimal OverdraftUsed { get; set; }
        public decimal OverdraftLimit = 1000.0M;

        //Constructor setting default balance of 0
        public PremierAccount()
        {
            Balance = 0.0M;
            AccountNumber = 0;
            AccountName = "default";
            OverdraftUsed = 0.0M;
        }

        //constructor setting balance to value
        public PremierAccount(int AccNum, decimal value, string AccName, decimal oUsed)
        {
            AccountNumber = AccNum;
            Balance = value;
            AccountName = AccName;
            OverdraftUsed = oUsed;
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
                decimal overdraftNeeded = value - Balance;
                decimal overdraftAvailable = OverdraftLimit - OverdraftUsed;

                if (overdraftAvailable >= overdraftNeeded)
                {
                    Balance = 0.0M;
                    OverdraftUsed += overdraftNeeded;
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public override void output()
        {
            Console.WriteLine("Premier Account - {0}\nAccountName - {1}\nBalance Remaining - {2}\nOverdraft Used - {3}\n",
                AccountNumber, AccountName, Balance, OverdraftUsed);
        }
    }
}
