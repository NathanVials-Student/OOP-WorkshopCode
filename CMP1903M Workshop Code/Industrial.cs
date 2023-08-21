using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class Industrial : Property
    {
        public Enums.Ttype tenureType { get; set; }
        public Enums.Itype industryType { get; set; }
        public float squareMetre { get; set; }

        //industrial constructor
        //id, add, val, sqm, itype, ttype
        public Industrial(int id, string add, int val, float sqm ,int itype, int ttype)
        {
            ID = id;
            Address = add;
            Value = val;
            squareMetre = sqm;

            //set tenure type
            switch (ttype)
            {
                case 1: tenureType = Enums.Ttype.Freehold; break;
                case 2: tenureType = Enums.Ttype.Leasehold; break;
                default: tenureType = Enums.Ttype.Unknown; break;
            }

            //set industry type
            switch (itype)
            {
                case 1: industryType = Enums.Itype.Factory; break;
                case 2: industryType = Enums.Itype.Warehouse; break;
                case 3: industryType = Enums.Itype.Office; break;
                default: industryType = Enums.Itype.Unknown; break;
            }
        }
    }
}
