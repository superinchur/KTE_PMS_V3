namespace KTE_PMS
{
    public class Samsung_BMS_Rack
    {

        public double Rack_Voltage { get; set; }
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
        public double Rack_Discharge_Current_Limit_of_Rack { get; set; }
        public double Rack_Charge_Current_Limit_of_Rack { get; set; }

        public double Rack_Switch_Control_Info { get; set; }
        public double Rack_Switch_Sensor_Info { get; set; }
        public double Rack_External_Sensor_Info { get; set; }
        public double Module_Comm_Fault_Position { get; set; }
    }
}
