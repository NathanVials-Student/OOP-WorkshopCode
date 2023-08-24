using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    interface IAccountReport
    {
        //Interface for just account reporting
        int AccountNumber { get; set; }
        string AccountName { get; set; }
        decimal Balance { get; set; }
    }
}
