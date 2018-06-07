using KTE_PMS.Observer;
using KTE_PMS.Singleton;
using System;
using System.Windows.Forms;

namespace KTE_PMS
{


    public sealed class Repository : SingleTonBase<Repository>
    {
        //----------------------------------
        // Modbus TCP Controller - Master
        //----------------------------------
        public MIMIC.BMSViewer bmsviewer;
        public MIMIC.PMDViewer pmdviewer;
        public MIMIC.MainViewer p_main = null;
        public MIMIC.AlarmViewer p_alarm = null;
        public MIMIC.ControlViewer p_control = null;
        public MIMIC.MeasureViewer p_measure { set; get; }
        public MIMIC.MimicViewer p_mimic = null;
        public MIMIC.Setting_PageViewer p_setting = null;
        public MIMIC.TrendViewer p_trend = null;
        //----------------------------------
        // Modbus RTU Controller - Master
        //----------------------------------
        public Modbus_Setup modbus_rtuviewer;

        public sPCS GnEPS_PCS;
        public sPMD pmd;
        public sBCS bsc;
        public sSamsungBCS samsung_bcs;

        public TagManager TagManager { get; set; }
        public DBConnector dbConnector;
        IUpdate observers;

        public ushort remote_power;
        // ---------------------------------------------------------
        // 생성자
        // ---------------------------------------------------------
        private Repository() //단일체로 구현하기 위해 private으로 접근 지정
        {
            GnEPS_PCS = new sPCS();
            pmd = new sPMD();
            samsung_bcs = new sSamsungBCS();

            bmsviewer = new MIMIC.BMSViewer();
            pmdviewer = new MIMIC.PMDViewer();
            //modbus_rtuviewer = new Modbus_Setup();
            p_main = new MIMIC.MainViewer();
            p_alarm = new MIMIC.AlarmViewer();
            p_control = new MIMIC.ControlViewer();
            p_measure = new MIMIC.MeasureViewer();
            p_mimic = new MIMIC.MimicViewer();
            p_trend = new MIMIC.TrendViewer();
            p_setting = new MIMIC.Setting_PageViewer();


            observers = p_measure;
            bmsviewer.AddObserver(observers);

            observers = p_main;
            bmsviewer.AddObserver(observers);

            //-----------------------------
            // // TagManager 생성
            //-----------------------------
            try
            {
                TagManager = new TagManager(this);
                //Thread t_tagmanager = new Thread(new ThreadStart(TagManager.Run ));
                //t_tagmanager.Start();

                //dbConnector = new DBConnector();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Abort");
                throw e;
            }

        }

        // ---------------------------------------------------------
        // 소멸자
        // ---------------------------------------------------------
        ~Repository()
        {
            // 

            if (modbus_rtuviewer != null)
            {
                modbus_rtuviewer.Dispose();
            }

        }

        // ---------------------------------------------------------
        // Controller Tag
        // ---------------------------------------------------------
        public void Set_BSC_Control(byte[] data)
        {
            bsc.Controler_Status = data[0];
            bsc.ReqtoControl_AllContactors = data[1];
            bsc.Reset = data[2];
            bsc.Manual_Mode_Request_Ack = data[3];
            bsc.Request_Sleep = data[4];
            bsc.Request_Connection = data[5];
        }

        public void Get_UMD(byte[] data)
        {
            pmd.Voltage_A = BitConverter.ToSingle(data, 16);
            pmd.Voltage_B = BitConverter.ToSingle(data, 20);
            pmd.Voltage_C = BitConverter.ToSingle(data, 24);
            pmd.DC_Voltage = BitConverter.ToSingle(data, 28);
            pmd.Current_A = BitConverter.ToSingle(data, 32);
            pmd.Current_B = BitConverter.ToSingle(data, 36);
            pmd.Current_C = BitConverter.ToSingle(data, 40);
            pmd.DC_Current = BitConverter.ToSingle(data, 44);
            pmd.Phase_VA = BitConverter.ToSingle(data, 48);
            pmd.Phase_VB = BitConverter.ToSingle(data, 52);
            pmd.Phase_VC = BitConverter.ToSingle(data, 56);
            pmd.Phase_IA = BitConverter.ToSingle(data, 60);
            pmd.Phase_IB = BitConverter.ToSingle(data, 64);
            pmd.Phase_IC = BitConverter.ToSingle(data, 68);
            pmd.ActivePower = BitConverter.ToSingle(data, 72);
            pmd.ReactivePower = BitConverter.ToSingle(data, 76);
            pmd.PowerFactor = BitConverter.ToSingle(data, 80);
            pmd.DCPower = BitConverter.ToSingle(data, 84);

            pmd.Day_power_passive = BitConverter.ToSingle(data, 88);
            pmd.Day_power_trans = BitConverter.ToSingle(data, 92);
            pmd.Month_power_passiver = BitConverter.ToSingle(data, 96);
            pmd.Month_power_trans = BitConverter.ToSingle(data, 100);
            pmd.Accumulate_power_passive = BitConverter.ToSingle(data, 104);
            pmd.Accumulate_power_trans = BitConverter.ToSingle(data, 108);

            /*
        */

            // F050
            //순시 사고 개수 
            //페이저 사고 개수 
            //순시 사고 인덱스 페이저 사고 인덱스 
            //보드 개수(F050-1)
            //상태정보1(F050 - 2)
            //상태정보2(F050 - 3)
            //예약
            //PMD_Status
            // F051
            //년/월/일 시/분/초 를 초 단위로 표시함.
            //0: 2014 / 01 / 01 00:00:00 의미, 86399: 2014 / 01 / 01 23:59:59

            DateTime baseTime = new DateTime(2014, 4, 1, 0, 0, 0);
            TimeSpan timeDiff = DateTime.Now.Subtract(baseTime);
            pmd.DateTime = timeDiff.TotalSeconds;

            pmd.Frequency = BitConverter.ToInt16(data, 8) / 1000;

            // F052
            //PMD_DI_Status
        }


        public void Get_PCS(byte[] data)
        {
            GnEPS_PCS.Stand_Grid_Mode = (BitConverter.ToInt16(data, 0) & 0x80) >> 7;
            GnEPS_PCS.Diesel_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x10) >> 5;
            GnEPS_PCS.Wind_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x0F) >> 4;
            GnEPS_PCS.Solar_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x08) >> 3;
            GnEPS_PCS.ESS_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x04) >> 2;
            GnEPS_PCS.Inverter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x02) >> 1;
            GnEPS_PCS.System_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x01) >> 0;

            Console.WriteLine(GnEPS_PCS.Wind_Converter_Run_Stop);
            GnEPS_PCS.Inverter_Voltage_P = BitConverter.ToInt16(data, 1);
            GnEPS_PCS.Inverter_Voltage_I = BitConverter.ToInt16(data, 2);
            GnEPS_PCS.Inverter_Current_P = BitConverter.ToInt16(data, 3);
            GnEPS_PCS.Inverter_Current_I = BitConverter.ToInt16(data, 4);
            GnEPS_PCS.ESS1_Voltage_P = BitConverter.ToInt16(data, 5);
            GnEPS_PCS.ESS1_Voltage_I = BitConverter.ToInt16(data, 6);
            GnEPS_PCS.ESS1_Current_P = BitConverter.ToInt16(data, 7);
            GnEPS_PCS.ESS1_Current_I = BitConverter.ToInt16(data, 8);
            GnEPS_PCS.ESS2_Voltage_P = BitConverter.ToInt16(data, 9);
            GnEPS_PCS.ESS2_Voltage_I = BitConverter.ToInt16(data, 10);
            GnEPS_PCS.ESS2_Current_P = BitConverter.ToInt16(data, 11);
            GnEPS_PCS.ESS2_Current_I = BitConverter.ToInt16(data, 12);
            GnEPS_PCS.Diesel_Current_P = BitConverter.ToInt16(data, 13);
            GnEPS_PCS.Diesel_Current_I = BitConverter.ToInt16(data, 14);

            GnEPS_PCS.Inverter_AC_Voltage_Reference = BitConverter.ToInt16(data, 30);
            GnEPS_PCS.Inverter_P_Reference = BitConverter.ToInt16(data, 31);
            GnEPS_PCS.Inverter_Q_Reference = BitConverter.ToInt16(data, 32);
            GnEPS_PCS.Inverter_Freq_reference = BitConverter.ToInt16(data, 33);
            GnEPS_PCS.Inverter_OVR_Voltage_Reference = BitConverter.ToInt16(data, 34);
            GnEPS_PCS.Inverter_UVR_Voltage_Reference = BitConverter.ToInt16(data, 35);
            GnEPS_PCS.Inverter_OCR_Current_Reference = BitConverter.ToInt16(data, 36);

            GnEPS_PCS.ESS1_Master_Slave_Mode = BitConverter.ToInt16(data, 50);
            GnEPS_PCS.ESS1_Out_Voltage_Reference = BitConverter.ToInt16(data, 51);
            GnEPS_PCS.ESS1_Power_Reference = BitConverter.ToInt16(data, 52);
            GnEPS_PCS.ESS1_Bat1_Max_Voltage = BitConverter.ToInt16(data, 53);
            GnEPS_PCS.ESS1_Bat1_Min_Voltage = BitConverter.ToInt16(data, 54);
            GnEPS_PCS.ESS1_OUT_OVR_Reference = BitConverter.ToInt16(data, 55);
            GnEPS_PCS.ESS1_OUT_UVR_Reference = BitConverter.ToInt16(data, 56);
            GnEPS_PCS.ESS1_IN_OVR_Reference = BitConverter.ToInt16(data, 57);
            GnEPS_PCS.ESS1_IN_UVR_Reference = BitConverter.ToInt16(data, 58);

            GnEPS_PCS.ESS2_Master_Slave_Mode = BitConverter.ToInt16(data, 70);
            GnEPS_PCS.ESS2_Out_Voltage_Reference = BitConverter.ToInt16(data, 71);
            GnEPS_PCS.ESS2_Power_Reference = BitConverter.ToInt16(data, 72);
            GnEPS_PCS.ESS2_Bat1_Max_Voltage = BitConverter.ToInt16(data, 73);
            GnEPS_PCS.ESS2_Bat1_Min_Voltage = BitConverter.ToInt16(data, 74);
            GnEPS_PCS.ESS2_OUT_OVR_Reference = BitConverter.ToInt16(data, 75);
            GnEPS_PCS.ESS2_OUT_UVR_Reference = BitConverter.ToInt16(data, 76);
            GnEPS_PCS.ESS2_IN_OVR_Reference = BitConverter.ToInt16(data, 77);
            GnEPS_PCS.ESS2_IN_UVR_Reference = BitConverter.ToInt16(data, 78);

            GnEPS_PCS.Diesel_AC_VoIltage_Reference = BitConverter.ToInt16(data, 90);
            GnEPS_PCS.Diesel_Freq_reference = BitConverter.ToInt16(data, 91);
            GnEPS_PCS.Diesel_Power_Reference = BitConverter.ToInt16(data, 92);
            GnEPS_PCS.Diesel_OVR_Voltage_Reference = BitConverter.ToInt16(data, 93);
            GnEPS_PCS.Diesel_UVR_Voltage_Reference = BitConverter.ToInt16(data, 94);
            GnEPS_PCS.Diesel_OCR_Current_Reference = BitConverter.ToInt16(data, 95);

            GnEPS_PCS.Inverter_OCR_Fault = (BitConverter.ToInt16(data, 100) & 0x80) >> 7;
            GnEPS_PCS.Inverter_OVR_Fault = (BitConverter.ToInt16(data, 100) & 0x40) >> 6;
            GnEPS_PCS.Inverter_UVR_Fault = (BitConverter.ToInt16(data, 100) & 0x20) >> 5;
            GnEPS_PCS.Inverter_OTR_Fault = (BitConverter.ToInt16(data, 100) & 0x10) >> 4;
            GnEPS_PCS.Inverter_AC_Voltage = BitConverter.ToInt16(data, 101);
            GnEPS_PCS.Inverter_P = BitConverter.ToInt16(data, 102);
            GnEPS_PCS.Inverter_Q = BitConverter.ToInt16(data, 103);
            GnEPS_PCS.Inverter_Frequency = BitConverter.ToInt16(data, 104);

            GnEPS_PCS.ESS1_OCR_Fault = (BitConverter.ToInt16(data, 120) & 0x80) >> 7;
            GnEPS_PCS.ESS1_In_OVR_Fault = (BitConverter.ToInt16(data, 120) & 0x40) >> 6;
            GnEPS_PCS.ESS1_In_UVR_Fault = (BitConverter.ToInt16(data, 120) & 0x20) >> 5;
            GnEPS_PCS.ESS1_Out_OVR_Fault = (BitConverter.ToInt16(data, 120) & 0x10) >> 4;
            GnEPS_PCS.ESS1_Out_UVR_Fault = (BitConverter.ToInt16(data, 120) & 0x08) >> 3;
            GnEPS_PCS.ESS1_In_OTR_Fault = (BitConverter.ToInt16(data, 120) & 0x04) >> 2;
            GnEPS_PCS.ESS1_In_Voltage = BitConverter.ToInt16(data, 121);
            GnEPS_PCS.ESS1_Out_Voltage = BitConverter.ToInt16(data, 122);
            GnEPS_PCS.ESS1_Current = BitConverter.ToInt16(data, 123);
            GnEPS_PCS.ESS1_Power = BitConverter.ToInt16(data, 124);

            GnEPS_PCS.ESS2_OCR_Fault = (BitConverter.ToInt16(data, 140) & 0x80) >> 7;
            GnEPS_PCS.ESS2_In_OVR_Fault = (BitConverter.ToInt16(data, 140) & 0x40) >> 6;
            GnEPS_PCS.ESS2_In_UVR_Fault = (BitConverter.ToInt16(data, 140) & 0x20) >> 5;
            GnEPS_PCS.ESS2_Out_OVR_Fault = (BitConverter.ToInt16(data, 140) & 0x10) >> 4;
            GnEPS_PCS.ESS2_Out_UVR_Fault = (BitConverter.ToInt16(data, 140) & 0x08) >> 3;
            GnEPS_PCS.ESS2_In_OTR_Fault = (BitConverter.ToInt16(data, 140) & 0x04) >> 2;
            GnEPS_PCS.ESS2_In_Voltage = BitConverter.ToInt16(data, 141);
            GnEPS_PCS.ESS2_Out_Voltage = BitConverter.ToInt16(data, 142);
            GnEPS_PCS.ESS2_Current = BitConverter.ToInt16(data, 143);
            GnEPS_PCS.ESS2_Power = BitConverter.ToInt16(data, 144);

            GnEPS_PCS.Diesel_OCR_Fault = (BitConverter.ToInt16(data, 160) & 0x80) >> 7;
            GnEPS_PCS.Diesel_OVR_Fault = (BitConverter.ToInt16(data, 160) & 0x40) >> 6;
            GnEPS_PCS.Diesel_UVR_Fault = (BitConverter.ToInt16(data, 160) & 0x20) >> 5;
            GnEPS_PCS.Diesel_OTR_Fault = (BitConverter.ToInt16(data, 160) & 0x10) >> 4;
            GnEPS_PCS.Diesel_AC_Voltage = BitConverter.ToInt16(data, 161);
            GnEPS_PCS.Diesel_Current = BitConverter.ToInt16(data, 162);
            GnEPS_PCS.Diesel_Frequency = BitConverter.ToInt16(data, 163);
            GnEPS_PCS.Diesel_Power = BitConverter.ToInt16(data, 164);
            GnEPS_PCS.Diesel_P = BitConverter.ToInt16(data, 165);
            GnEPS_PCS.Diesel_Q = BitConverter.ToInt16(data, 166);

            GnEPS_PCS.Solar_OCR_Fault = (BitConverter.ToInt16(data, 170) & 0x80) >> 7;
            GnEPS_PCS.Solar_OVR_Fault = (BitConverter.ToInt16(data, 170) & 0x40) >> 6;
            GnEPS_PCS.Solar_UVR_Fault = (BitConverter.ToInt16(data, 170) & 0x20) >> 5;
            GnEPS_PCS.Solar_OTR_Fault = (BitConverter.ToInt16(data, 170) & 0x10) >> 4;
            GnEPS_PCS.Solar_In_Voltage = BitConverter.ToInt16(data, 171);
            GnEPS_PCS.Solar_Out_Voltage = BitConverter.ToInt16(data, 172);
            GnEPS_PCS.Solar_Current = BitConverter.ToInt16(data, 173);
            GnEPS_PCS.Solar_Power = BitConverter.ToInt16(data, 174);

            GnEPS_PCS.Wind_OCR_Fault = (BitConverter.ToInt16(data, 180) & 0x80) >> 7;
            GnEPS_PCS.Wind_OVR_Fault = (BitConverter.ToInt16(data, 180) & 0x40) >> 6;
            GnEPS_PCS.Wind_UVR_Fault = (BitConverter.ToInt16(data, 180) & 0x20) >> 5;
            GnEPS_PCS.Wind_OTR_Fault = (BitConverter.ToInt16(data, 180) & 0x10) >> 4;
            GnEPS_PCS.Wind_In_Voltage = BitConverter.ToInt16(data, 181);
            GnEPS_PCS.Wind_Out_Voltage = BitConverter.ToInt16(data, 182);
            GnEPS_PCS.Wind_Current = BitConverter.ToInt16(data, 183);
            GnEPS_PCS.Wind_Power = BitConverter.ToInt16(data, 184);
        }

        public void Get_BSC(byte[] data)
        {
            int addr;
            addr = 0;
            byte[] temp_byte = new byte[2];

            samsung_bcs.Protocol_Version = BitConverter.ToUInt16(swapbyte(data, 0),0);


            samsung_bcs.System_Voltage = BitConverter.ToUInt16(swapbyte(data,2 * 1),0) * 0.1;
            samsung_bcs.System_Current = BitConverter.ToInt16(swapbyte(data, 2 * 2), 0);
            samsung_bcs.System_Power = samsung_bcs.System_Voltage * samsung_bcs.System_Current / 1000;

            
            // SOC
            Repository.Instance.pmdviewer.WriteSOCBuffers[0] = data[6];
            Repository.Instance.pmdviewer.WriteSOCBuffers[1] = data[7];

            // 전압
            Repository.Instance.pmdviewer.WriteVoltageBuffers[0] = data[2];
            Repository.Instance.pmdviewer.WriteVoltageBuffers[1] = data[3];

            // 전류
            Repository.Instance.pmdviewer.WriteCurrentBuffers[0] = data[4];
            Repository.Instance.pmdviewer.WriteCurrentBuffers[1] = data[5];

            // Heartbit
            Repository.Instance.pmdviewer.WriteHeartBitBuffers[0] = data[50];
            Repository.Instance.pmdviewer.WriteHeartBitBuffers[1] = data[51];

            samsung_bcs.System_SOC = BitConverter.ToUInt16(swapbyte(data, 3 * 2), 0) * 0.1;
            samsung_bcs.System_SOH = BitConverter.ToUInt16(swapbyte(data, 4 * 2), 0) * 0.1;
            samsung_bcs.System_Mode = BitConverter.ToUInt16(swapbyte(data, 5 * 2), 0);
            samsung_bcs.System_Max_Voltage = BitConverter.ToUInt16(swapbyte(data, 6 * 2), 0) * 0.01;
            samsung_bcs.System_Min_Voltage = BitConverter.ToUInt16(swapbyte(data, 7 * 2), 0) ;
            samsung_bcs.System_Max_Temp = BitConverter.ToInt16(swapbyte(data, 8 * 2), 0);
            samsung_bcs.System_Min_Temp = BitConverter.ToInt16(swapbyte(data, 9 * 2), 0);
            samsung_bcs.Protection_Summary4 = BitConverter.ToUInt16(swapbyte(data, 14 * 2), 0);
            samsung_bcs.Protection_Summary3 = BitConverter.ToUInt16(swapbyte(data, 15 * 2), 0);
            samsung_bcs.Protection_Summary2 = BitConverter.ToUInt16(swapbyte(data, 16 * 2), 0);
            samsung_bcs.Protection_Summary1 = BitConverter.ToUInt16(swapbyte(data, 17 * 2), 0);
            samsung_bcs.Alarm_Summary4 = BitConverter.ToUInt16(swapbyte(data, 18 * 2), 0);
            samsung_bcs.Alarm_Summary3 = BitConverter.ToUInt16(swapbyte(data, 19 * 2), 0);
            samsung_bcs.Alarm_Summary2 = BitConverter.ToUInt16(swapbyte(data, 20 * 2), 0);
            samsung_bcs.Alarm_Summary1 = BitConverter.ToUInt16(swapbyte(data, 21 * 2), 0);

            samsung_bcs.Discharge_Current_Limit = BitConverter.ToUInt16(swapbyte(data, 22 * 2), 0);
            samsung_bcs.Charge_Current_Limit = BitConverter.ToUInt16(swapbyte(data, 23 * 2), 0);
            samsung_bcs.Watchdog_Response = BitConverter.ToInt16(swapbyte(data, 24 * 2), 0);

            samsung_bcs.System_Heartbit = BitConverter.ToUInt16(swapbyte(data, 25 * 2), 0);
            samsung_bcs.Connecting_Status = BitConverter.ToUInt16(swapbyte(data, 26 * 2), 0);

            samsung_bcs.Service_Voltage = BitConverter.ToUInt16(swapbyte(data, 27 * 2), 0);
            samsung_bcs.Service_SOC = BitConverter.ToUInt16(swapbyte(data, 28 * 2), 0);

            samsung_bcs.System_Alarm_Status = BitConverter.ToUInt16(swapbyte(data, 30 * 2), 0);
            //samsung_bcs.System_Power = BitConverter.ToUInt16(data, 0);

        }


        private byte[] swapbyte(byte[] word, int offset)
        {
            //BSC_Controller_Data[0]  =   BSC1[0] * 256 + data[1];
            byte[] data = new Byte[2];

            data[0] = word[offset + 1];
            data[1] = word[offset];

            return data;
        }


        private byte[] HostToNetworkOrder(int word)
        {
            //BSC_Controller_Data[0]  =   BSC1[0] * 256 + data[1];
            byte[] data = new Byte[2];
            byte[] dat = BitConverter.GetBytes(System.Net.IPAddress.HostToNetworkOrder((short)word));
            data[0] = dat[0];
            data[1] = dat[1];

            return data;
        }




        private void BT_Connect_Click(object sender, EventArgs e)
        {
            //Connect_to_BSC();
        }
    }
}

