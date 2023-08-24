using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CMP1903M_Workshop_Code
{
    abstract class AccountBase
    {
        //properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }

        public decimal Balance { get; set; }

        //methods
        public abstract void output();


    }
}
