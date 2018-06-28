using System;
using System.Linq;

namespace KTE_PMS
{
    public class sPMD
    {
        #region PCS variable declaration
        public byte[] PCS_Request { get; set; }
        public byte[] PCS_Monitoring { get; set; }
        #endregion

        #region PMD variable declaration
        public byte[] Status { get; set; }
        public double DateTime { get; set; }
        public float Frequency { get; set; }
        public byte[] DI_Status { get; set; }
        public float Voltage_A { get; set; }
        public float Voltage_B { get; set; }
        public float Voltage_C { get; set; }
        public float DC_Voltage { get; set; }
        public float Current_A { get; set; }
        public float Current_B { get; set; }
        public float Current_C { get; set; }
        public float DC_Current { get; set; }
        public float Phase_VA { get; set; }
        public float Phase_VB { get; set; }
        public float Phase_VC { get; set; }
        public float Phase_IA { get; set; }
        public float Phase_IB { get; set; }
        public float Phase_IC { get; set; }
        public float ActivePower { get; set; }
        public float ReactivePower { get; set; }
        public float PowerFactor { get; set; }
        public float DCPower { get; set; }

        public float Day_power_passive { get; set; }
        public float Day_power_trans { get; set; }
        public float Month_power_passiver { get; set; }
        public float Month_power_trans { get; set; }
        public float Accumulate_power_passive { get; set; }
        public float Accumulate_power_trans { get; set; }

        #endregion
    }
}
