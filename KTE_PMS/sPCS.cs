using System;
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
    }
}
