using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_VIEWER
{
    public class PropertyName
    {

        public string[] Networks_Name = new string[] {"이름","프로토콜","코멘트","멀티플렉싱","BUS_TYPE"};
        public string[] ECU_Name = new string[] { "이름","코멘트","","","","","",""};
        public string[] Messages_Name = new string[] {"이름","ID 포맷","DLC[Byte]","Tx_Method","Cycle_Time","Transmitter","Comment" };
        public string[] SigNal_Name= new string[] { "이름", "ID 포맷", "DLC[Byte]", "Tx_Method", "Cycle_Time", "Transmitter", "Comment" };
       
    }
}
