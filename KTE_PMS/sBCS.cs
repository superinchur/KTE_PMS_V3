using System;
using System.Linq;

namespace KTE_PMS
{
    public class sBCS
    {

        #region BSC variable declaration
        // BSC -> Controller (Monitoring)
        // Address 40000 ~ 40049

        public byte Controler_Status { get; set; }
        public byte ReqtoControl_AllContactors { get; set; }
        public byte Reset { get; set; }
        public byte Manual_Mode_Request_Ack { get; set; }
        public byte Request_Sleep { get; set; }
        public byte Request_Connection { get; set; }
        #endregion


    }
}
