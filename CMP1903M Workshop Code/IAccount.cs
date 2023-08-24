using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    interface IAccount 
    {
        //Interface to allow getting the balance, depositing and withdrawing
        bool Deposit(decimal value);
        bool Withdraw(decimal value);
    }
}
