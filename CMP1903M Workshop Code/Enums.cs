using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class Enums
    {
        //Property type enum
        public enum PType
        {
            Detached,
            SemiDetached,
            Terrace,
            Bungalow,
            Unknown
        }

        public enum Ttype
        {
            Freehold,
            Leasehold, 
            Unknown
        }

        public enum Itype
        {
            Factory,
            Warehouse,
            Office, 
            Unknown
        }
    }
}
