namespace KTE_PMS
{
    public class sSamsungBCS
    {

        #region BSC variable declaration
        // BSC -> Controller (Monitoring)
        // Address 40000 ~ 40049

        public ushort Controler_Status { get; set; }
        public ushort ReqtoControl_AllContactors { get; set; }
        public ushort Reset { get; set; }
        public ushort Manual_Mode_Request_Ack { get; set; }
        public ushort Request_Sleep { get; set; }
        public ushort Request_Connection { get; set; }

        public ushort Protocol_Version { get; set; } //0
        public double System_Voltage { get; set; }  // 1 0.1
        public short System_Current { get; set; } // 2 Signed /256
        public double System_SOC { get; set; }  // 3 Resolution  0.1
        public double System_SOH { get; set; }  // 4 Resolution 0.1
        public ushort System_Mode { get; set; } // 5 
        public double System_Max_Voltage { get; set; } // 6
        public double System_Min_Voltage { get; set; } // 7
        public double System_Max_Temp { get; set; }  //8
        public double System_Min_Temp { get; set; } // 9
        public int Mode_Charging { get; set; }
        public int Mode_Discharging { get; set; }
        public int Mode_Offline { get; set; } 
        public int Mode_Idle { get; set; } 
        public int Mode_Ready { get; set; }
        public int Mode_InputSignal4 { get; set; }
        public int Mode_InputSignal3 { get; set; }
        public int Mode_InputSignal2 { get; set; }
        public int Mode_InputSIgnal1 { get; set; }
        public int Mode_OutputControl2 { get; set; }
        public int Mode_OutputControl1 { get; set; }

        public ushort Protection_Summary4 { get; set; } // 14
        public ushort Protection_Summary3 { get; set; } // 15
        public ushort Protection_Summary2 { get; set; } // 16
        public ushort Protection_Summary1 { get; set; } // 17
        public ushort Alarm_Summary4 { get; set; } // 18
        public ushort Alarm_Summary3 { get; set; } // 19
        public ushort Alarm_Summary2 { get; set; } // 20
        public ushort Alarm_Summary1 { get; set; } // 21

        public double Discharge_Current_Limit_of_Rack { get; set; } // 22
        public double Charge_Current_Limit { get; set; } // 23
        public short Watchdog_Response { get; set; } // 24
        public ushort System_Heartbit { get; set; } // 25
        public ushort Connecting_Status { get; set; } // 26

        public double Service_Voltage { get; set; } // 27
        public double Service_SOC { get; set; } // 28
        public double Ambient_Temp { get; set; } // 30
        public ushort System_Alarm_Status { get; set; } // 31
        public double System_Power { get; set; } // calculated

        public double Rack_Voltage{ get; set; }
        public double String1_Rack_Voltage { get; set; }
        public double String2_Rack_Voltage { get; set; }
        public double String1_Cell_Summation_Voltage { get; set; }
        public double String2_Cell_Summation_Voltage { get; set; }
        public double Rack_Current { get; set; }
        public double String1_Rack_Current { get; set; }
        public double String2_Rack_Current { get; set; }
        public double Rack_Current_Average { get; set; }
        public ushort Rack_Mode { get; set; }
        public double Rack_SOC { get; set; }
        public double Rack_SOH { get; set; }


        public double Max1_Cell_Voltage_Value { get; set; }
        public int Max1_Cell_Voltage_Position { get; set; }
        public double Min1_Cell_Voltage_Value { get; set; }
        public int Min1_Cell_Voltage_Position { get; set; }
        public double Max2_Cell_Voltage_Value { get; set; }
        public int Max2_Cell_Voltage_Position { get; set; }
        public double Min2_Cell_Voltage_Value { get; set; }
        public int Min2_Cell_Voltage_Position { get; set; }
        public double Max1_Cell_Temp_Value { get; set; }
        public int Max1_Cell_Temp_Position { get; set; }
        public double Min1_Cell_Temp_Value { get; set; }
        public int Min1_Cell_Temp_Position { get; set; }
        public double Max2_Cell_Temp_Value { get; set; }
        public int Max2_Cell_Temp_Position { get; set; }
        public double Min2_Cell_Temp_Value { get; set; }
        public int Min2_Cell_Temp_Position { get; set; }
        public double Average_Cell_Voltage_Value { get; set; }
        public double Average_Cell_Temp_Value { get; set; }
        public double Discharge_Current_limit_of_Rack { get; set; }
        public double Charge_Current_Limit_of_Rack { get; set; }

        public double Rack_Switch_Control_Info { get; set; }
        public double Rack_Switch_Sensor_Info { get; set; }
        public double Rack_External_Sensor_Info { get; set; }
        public double Module_Comm_Fault_Position { get; set; }

        #endregion


    }
}
