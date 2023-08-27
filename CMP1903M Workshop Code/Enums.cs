using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    public class Enums
    {
        //message type Enum
        public enum mtype
        {
            Tournament, 
            Weather, 
            Facilities,
            Voting,
            Universal
        }

        //Platform type enum
        public enum ptype
        {
            Email,
            Text,
            Both,
            Unknown
        }
    }
}
