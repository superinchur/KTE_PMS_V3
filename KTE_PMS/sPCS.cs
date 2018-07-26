using System;
using System.Collections.Generic;
using System.Linq;

namespace KTE_PMS
{
    public class sPCS
    {
        //internal short Fault_Battery_Voltage;

        // System Part Control
        
        public int Stand_Grid_Mode { get; set; }
        public int Diesel_Converter_Run_Stop { get; set; }
        public int Wind_Converter_Run_Stop { get; set; }
        public int Solar_Converter_Run_Stop { get; set; }
        public int ESS_Converter_Run_Stop { get; set; }
        public int Inverter_Run_Stop { get; set; }
        public int System_Run_Stop { get; set; }

        public int Mode_Standby { get; set; }
        public int Mode_Peak_cut{ get; set; }
        public int Mode_Charging { get; set; }
        public int Mode_Discharging { get; set; }
        public int Mode_Reset { get; set; }
        public int Mode_ACKED { get; set; }

        public bool PCS_ACK { get; set; }
        public bool Authority_PMS { get; set; }
        
        public int GRID_R_Voltage { get; set; }
        public int GRID_S_Voltage { get; set; }
        public int GRID_T_Voltage { get; set; }
        public int GRID_R_Current { get; set; }
        public int GRID_S_Current { get; set; }
        public int GRID_T_Current { get; set; }
        public int GRID_Power { get; set; }
        public double GRID_Frequency { get; set; }
        public int isTemperatureWarning { get; set; }

        public int LOAD_R_Current { get; set; }
        public int LOAD_S_Current { get; set; }
        public int LOAD_T_Current { get; set; }
        public int LOAD_Power { get; set; }
        public int INVERTER_Power { get; set; }

        public ushort PCS_GRID_Status { get; set; }
        public ushort PCS_Fault_Status { get; set; }
        public ushort PCS_STANDBY { get; set; }

        public int Fault_Battery_Voltage { get; set; }
        public int Fault_Battery_Current { get; set; }
        public int Fault_System_A_Current { get; set; }
        public int Fault_System_B_Current { get; set; }
        public int Fault_System_C_Current { get; set; }
        public int Fault_Inverter_A_Current { get; set; }
        public int Fault_Inverter_B_Current { get; set; }
        public int Fault_Inverter_C_Current { get; set; }
        public int Fault_Inverter_A_Voltage { get; set; }
        public int Fault_Inverter_B_Voltage { get; set; }
        public int Fault_Inverter_C_Voltage { get; set; }
        public int Fault_Active_Power { get; set; }
        public int Control_MODE { get; set; }
        public int Fault_System_CB_Status { get; set; }
        public int Inverter_Current_Reference { get; set; }
        public int Inverter_Q_Current { get; set; }
        public int Inverter_D_Current { get; set; }

        public int Battery_Voltage { get; set; }
        public int Battery_Current { get; set; }


        public bool common_alarm { get; set;  }

        Dictionary<int, string> d;

        public sPCS()
        {
            d = new Dictionary<int, string>();

            //d.Add(0, ByteConverterToUInt16(data, 0));

        }

        /*
    GnEPS_PCS.GRID_R_Voltage = ByteConverterToUInt16(data, 0);
    GnEPS_PCS.GRID_S_Voltage = ByteConverterToUInt16(data, 1);
    GnEPS_PCS.GRID_T_Voltage = ByteConverterToInt16(data, 2);
    GnEPS_PCS.GRID_R_Current = ByteConverterToInt16(data, 3);
    GnEPS_PCS.GRID_S_Current = ByteConverterToInt16(data, 4);
    GnEPS_PCS.GRID_T_Current = ByteConverterToInt16(data, 5);
    GnEPS_PCS.GRID_Power = ByteConverterToInt16(data, 6);
    power.setPCSPower(GnEPS_PCS.GRID_Power);

        GnEPS_PCS.GRID_Frequency = ByteConverterToUInt16(data, 7) * 0.1;
        GnEPS_PCS.isTemperatureWarning = ByteConverterToUInt16(data, 8);

    GnEPS_PCS.LOAD_R_Current = ByteConverterToInt16(data, 11);
    GnEPS_PCS.LOAD_S_Current = ByteConverterToInt16(data, 12);
    GnEPS_PCS.LOAD_T_Current = ByteConverterToInt16(data, 13);
    GnEPS_PCS.LOAD_Power = ByteConverterToUInt16(data, 14);
    GnEPS_PCS.INVERTER_Power = ByteConverterToInt16(data, 15);

    GnEPS_PCS.PCS_GRID_Status = ByteConverterToUInt16(data, 16);
    GnEPS_PCS.PCS_Fault_Status = ByteConverterToUInt16(data, 17);
    GnEPS_PCS.PCS_STANDBY = ByteConverterToUInt16(data, 18);
    GnEPS_PCS.Fault_Battery_Voltage = ByteConverterToInt16(data, 19);
    GnEPS_PCS.Fault_Battery_Current = ByteConverterToInt16(data, 20);
    GnEPS_PCS.Fault_System_A_Current = ByteConverterToInt16(data, 21);
    GnEPS_PCS.Fault_System_B_Current = ByteConverterToInt16(data, 22);
    GnEPS_PCS.Fault_System_C_Current = ByteConverterToInt16(data, 23);
    GnEPS_PCS.Fault_Inverter_A_Current = ByteConverterToInt16(data, 24);
    GnEPS_PCS.Fault_Inverter_B_Current = ByteConverterToInt16(data, 25);
    GnEPS_PCS.Fault_Inverter_C_Current = ByteConverterToInt16(data, 26);
    GnEPS_PCS.Fault_Inverter_A_Voltage = ByteConverterToInt16(data, 27);
    GnEPS_PCS.Fault_Inverter_B_Voltage = ByteConverterToInt16(data, 28);
    GnEPS_PCS.Fault_Inverter_C_Voltage = ByteConverterToInt16(data, 29);
    GnEPS_PCS.Fault_Active_Power = ByteConverterToInt16(data, 30);
    */
    }
}
