using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    internal class Shop : Property
    {
        public Enums.PType propertyType {  get; set; }
        public Enums.Ttype tenureType { get; set; }
        public float sqaureMetre { get; set; }

        //shop constructor
        //id, address, value, sqm, proptype, tentype

        public Shop(int id, string a, int val, float sqm, int ptype, int ttype)
        {
            ID = id;
            Address = a;
            Value = val;
            sqaureMetre = sqm;

            //set property type
            switch (ptype)
            {
                case 1: propertyType = Enums.PType.Detached; break;
                case 2: propertyType = Enums.PType.SemiDetached; break;
                case 3: propertyType = Enums.PType.Terrace; break;
                case 4: propertyType = Enums.PType.Bungalow; break;
                default: propertyType = Enums.PType.Unknown; break;
            }

            //set tenure type
            switch (ttype)
            {
                case 1: tenureType = Enums.Ttype.Freehold; break;
                case 2: tenureType = Enums.Ttype.Leasehold; break;
                default: tenureType = Enums.Ttype.Unknown; break;
            }
        }


    }
}
