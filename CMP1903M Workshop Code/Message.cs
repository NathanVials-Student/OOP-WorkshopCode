using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshop_Code
{
    public class Message
    {
        //Properties
        public string Content { get; set; }
        public Enums.mtype MessageType { get; set; }
        public Enums.ptype PlatformType { get; set; }

        //Constructor
        public Message(string c, int mt, int pt)
        {
            Content = c;
            
            //set message type
            switch (mt)
            {
                case 1: MessageType = Enums.mtype.Tournament; break;
                case 2: MessageType = Enums.mtype.Weather; break;
                case 3: MessageType = Enums.mtype.Facilities; break;
                case 4: MessageType = Enums.mtype.Voting; break;
                default: MessageType = Enums.mtype.Universal; break;
            }

            //set platfrom type
            switch (pt)
            {
                case 1: PlatformType = Enums.ptype.Email; break;
                case 2: PlatformType = Enums.ptype.Text; break;
                case 3: PlatformType = Enums.ptype.Both; break;
                default: PlatformType = Enums.ptype.Unknown; break;
            }
        }

        //methods
       
        
    }
}
