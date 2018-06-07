using System;
using System.Linq;

namespace KTE_PMS
{
    public class sPCS
    {
        // System Part Control
        //Stand/Grid Mode     Deisel Converter RUN/STOP Wind Converter RUN/STOP Solor Converter RUN/STOP ESS Converter RUN/STOP Inverter RUN/STOP System RUN/STOP
        public int Stand_Grid_Mode { get; set; }
        public int Diesel_Converter_Run_Stop { get; set; }
        public int Wind_Converter_Run_Stop { get; set; }
        public int Solar_Converter_Run_Stop { get; set; }
        public int ESS_Converter_Run_Stop { get; set; }
        public int Inverter_Run_Stop { get; set; }
        public int System_Run_Stop { get; set; }

        public int Inverter_Voltage_P { get; set; }
        public int Inverter_Voltage_I { get; set; }
        public int Inverter_Current_P { get; set; }
        public int Inverter_Current_I { get; set; }
        public int ESS1_Voltage_P { get; set; }
        public int ESS1_Voltage_I { get; set; }
        public int ESS1_Current_P { get; set; }
        public int ESS1_Current_I { get; set; }
        public int ESS2_Voltage_P { get; set; }
        public int ESS2_Voltage_I { get; set; }
        public int ESS2_Current_P { get; set; }
        public int ESS2_Current_I { get; set; }
        public int Diesel_Current_P { get; set; }
        public int Diesel_Current_I { get; set; }

        // Inverter Part
        public int Inverter_AC_Voltage_Reference { get; set; }
        public int Inverter_P_Reference { get; set; }
        public int Inverter_Q_Reference { get; set; }
        public int Inverter_Freq_reference { get; set; }
        public int Inverter_OVR_Voltage_Reference { get; set; }
        public int Inverter_UVR_Voltage_Reference { get; set; }
        public int Inverter_OCR_Current_Reference { get; set; }

        // ESS1 Part
        public int ESS1_Master_Slave_Mode { get; set; }
        public int ESS1_Out_Voltage_Reference { get; set; }
        public int ESS1_Power_Reference { get; set; }
        public int ESS1_Bat1_Max_Voltage { get; set; }
        public int ESS1_Bat1_Min_Voltage { get; set; }
        public int ESS1_OUT_OVR_Reference { get; set; }
        public int ESS1_OUT_UVR_Reference { get; set; }
        public int ESS1_IN_OVR_Reference { get; set; }
        public int ESS1_IN_UVR_Reference { get; set; }

        // ESS2 Part
        public int ESS2_Master_Slave_Mode { get; set; }
        public int ESS2_Out_Voltage_Reference { get; set; }
        public int ESS2_Power_Reference { get; set; }
        public int ESS2_Bat1_Max_Voltage { get; set; }
        public int ESS2_Bat1_Min_Voltage { get; set; }
        public int ESS2_OUT_OVR_Reference { get; set; }
        public int ESS2_OUT_UVR_Reference { get; set; }
        public int ESS2_IN_OVR_Reference { get; set; }
        public int ESS2_IN_UVR_Reference { get; set; }

        // Diesel Part

        public int Diesel_AC_VoIltage_Reference { get; set; }
        public int Diesel_Freq_reference { get; set; }
        public int Diesel_Power_Reference { get; set; }
        public int Diesel_OVR_Voltage_Reference { get; set; }
        public int Diesel_UVR_Voltage_Reference { get; set; }
        public int Diesel_OCR_Current_Reference { get; set; }

        // Inverter Part Monitoring

        public int Inverter_OCR_Fault { get; set; }
        public int Inverter_OVR_Fault { get; set; }
        public int Inverter_UVR_Fault { get; set; }
        public int Inverter_OTR_Fault { get; set; }
        public int Inverter_AC_Voltage { get; set; }
        public int Inverter_P { get; set; }
        public int Inverter_Q { get; set; }
        public int Inverter_Frequency { get; set; }

        // ESS1 Part
        public int ESS1_OCR_Fault { get; set; }
        public int ESS1_In_OVR_Fault { get; set; }
        public int ESS1_In_UVR_Fault { get; set; }
        public int ESS1_Out_OVR_Fault { get; set; }
        public int ESS1_Out_UVR_Fault { get; set; }
        public int ESS1_In_OTR_Fault { get; set; }
        public int ESS1_In_Voltage { get; set; }
        public int ESS1_Out_Voltage { get; set; }
        public int ESS1_Current { get; set; }
        public int ESS1_Power { get; set; }

        // ESS2 Part
        public int ESS2_OCR_Fault { get; set; }
        public int ESS2_In_OVR_Fault { get; set; }
        public int ESS2_In_UVR_Fault { get; set; }
        public int ESS2_Out_OVR_Fault { get; set; }
        public int ESS2_Out_UVR_Fault { get; set; }
        public int ESS2_In_OTR_Fault { get; set; }
        public int ESS2_In_Voltage { get; set; }
        public int ESS2_Out_Voltage { get; set; }
        public int ESS2_Current { get; set; }
        public int ESS2_Power { get; set; }

        // Diesel Part
        public int Diesel_OCR_Fault { get; set; }
        public int Diesel_OVR_Fault { get; set; }
        public int Diesel_UVR_Fault { get; set; }
        public int Diesel_OTR_Fault { get; set; }
        public int Diesel_AC_Voltage { get; set; }
        public int Diesel_Current { get; set; }
        public int Diesel_Frequency { get; set; }
        public int Diesel_Power { get; set; }
        public int Diesel_P { get; set; }
        public int Diesel_Q { get; set; }

        // Solar Part
        public int Solar_OCR_Fault { get; set; }
        public int Solar_OVR_Fault { get; set; }
        public int Solar_UVR_Fault { get; set; }
        public int Solar_OTR_Fault { get; set; }
        public int Solar_In_Voltage { get; set; }
        public int Solar_Out_Voltage { get; set; }
        public int Solar_Current { get; set; }
        public int Solar_Power { get; set; }

        // Wind Part
        public int Wind_OCR_Fault { get; set; }
        public int Wind_OVR_Fault { get; set; }
        public int Wind_UVR_Fault { get; set; }
        public int Wind_OTR_Fault { get; set; }
        public int Wind_In_Voltage { get; set; }
        public int Wind_Out_Voltage { get; set; }
        public int Wind_Current { get; set; }
        public int Wind_Power { get; set; }
    }
}
