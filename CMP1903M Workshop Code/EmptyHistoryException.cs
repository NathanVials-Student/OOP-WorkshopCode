using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    class EmptyHistoryException: Exception
    {
        public EmptyHistoryException(string message) : base(message)
        {
            //message = "Bad";
        }
    }
}
