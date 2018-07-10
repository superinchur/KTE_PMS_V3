﻿using KTE_PMS.Observer;
using KTE_PMS.Singleton;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS
{
    public sealed class Repository : SingleTonBase<Repository>
    {
        #region Variable Initialize
        //----------------------------------
        // Modbus TCP Controller - Master
        //----------------------------------
        public MIMIC.BMSViewer bmsviewer;
        public MIMIC.PMDViewer pmdviewer;
        public MIMIC.MainViewer p_main = null;
        public MIMIC.AlarmViewer p_alarm = null;
        public MIMIC.HistoryViewer p_history = null;
        public MIMIC.ControlViewer p_control = null;
        public MIMIC.MeasureViewer p_measure { set; get; }
        public MIMIC.MeasureViewer2 p_measure_BMS_Rack { set; get; }
        public MIMIC.MeasureViewer3 p_measure_PCS_Fault { set; get; }
        public MIMIC.MeasureViewer4 p_measure_PCS { set; get; }
        public MIMIC.MeasureViewerV2 p_measure_PCSV2 { set; get; }
        public MIMIC.MimicViewer p_mimic = null;
        public MIMIC.Setting_PageViewer p_setting = null;
        public TrendViewer p_trend = null;
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
        public ushort current_pcs_mode;

        //세파포어 선언 
        private static Semaphore bms_resourcePool; //한번에 허용할 수 있는 최대 쓰레드 수 
        private static int bms_maximumThreads = 1;

        private static Semaphore pcs_resourcePool; //한번에 허용할 수 있는 최대 쓰레드 수 
        private static int pcs_maximumThreads = 1;

        public int user_level;

        public string password;
        public string first_password;

        public int[] scheduler;

        public DataTable Tag_Data_Table = new DataTable();

        #endregion 

        // ---------------------------------------------------------
        // 생성자
        // ---------------------------------------------------------
        private Repository() //단일체로 구현하기 위해 private으로 접근 지정
        {
            // 20180628
            // 해당 SW에서 사용하는 항목은 GnEPS PCS, pCS 그리고 삼성 BCS가 있다.
            // 각각의 장비에서 받아온 데이터값들을 저장 할 Structure 선언하는 항목들.
            GnEPS_PCS = new sPCS();         // GnEPS_PCS
            pmd = new sPMD();               // GnEPS_PCS
            samsung_bcs = new sSamsungBCS(); // Samsung BCS

            // 20180628 
            // BMSViewer 할당
            // BMS Viewer는 BMS 통신과 관련된 모든 행위를 하는 Class이다.
            // 선언하는 순간, BMS와 통신을 하고 Structure samsung_bcs에 데이터를 집어 넣는다.
            bmsviewer = new MIMIC.BMSViewer();

            // 20180628 
            // PMDViewer 할당
            // PMD Viewer는 PCS 통신과 관련된 모든 행위를 하는 Class이다.
            // 선언하는 순간, PCS와 통신을 하고 Structure GnEPS_PCS에 데이터를 집어 넣는다.
            pmdviewer = new MIMIC.PMDViewer();

            // 20180628
            // Mimic Panel들을 Initialize 하는 항목
            Initialize_Mimic();

            // 20180628 
            // 현재 시작 시 Password의 값은 0000이다. 변경된 DB값을 유지하기 위해서는 
            // File이나 DB에 password를 저장하고, 이를 읽어오도록 한다.
            password = "0000";

            // 20180628 Observer 할당
            // BMS값을 받아올 경우 갱신이 되어야 할 항목들,과
            // PMS 값을 받아올 경우 갱신이 되어야 할 항목들을 OBserver에 넣는다.
            Allocate_Observer_to_Mimic();

            // 20180628 Semaphore 할당
            // 현재 Semaphore를 사용할지, 사용하지 않을지에 대해서 고민중임
            // TODO : Semaphore 처리
            Initialize_Semaphore();

            // 20180628 Parameter Setting 초기화
            // Parameter Setting에서 사용하는 값들을 초기화 하기 위한 항목이다
            // 현재 강제적으로 데이터를 넣고있으나, 설정한 값들의 보존을 위해서는 File이나 DB로 저장하도록 변경해야 한다.
            // TODO : Parameter Settings
            scheduler = new int[24];


            //-----------------------------
            // 20180628
            // Class TagManager 생성
            // TagManager는 Alarm 관련 항목들을 맡아서 처리하는 Class이다.
            // 현재는 알람을 단순하게 처리하지만, 나중에 ALARM 에 전시할 항목이 늘어날 경우
            //-----------------------------
            try
            {
                TagManager = new TagManager(this);
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Abort");
                throw e;
            }



        }

        private void Initialize_Mimic()
        {
            p_main = new MIMIC.MainViewer();
            p_alarm = new MIMIC.AlarmViewer();
            p_history = new MIMIC.HistoryViewer();
            p_control = new MIMIC.ControlViewer();
            p_measure = new MIMIC.MeasureViewer();
            p_measure_BMS_Rack = new MIMIC.MeasureViewer2();
            p_measure_PCS_Fault = new MIMIC.MeasureViewer3();
            p_measure_PCS = new MIMIC.MeasureViewer4();

            p_measure_PCSV2 = new MIMIC.MeasureViewerV2();

            p_mimic = new MIMIC.MimicViewer();
            p_trend = new TrendViewer();
            p_setting = new MIMIC.Setting_PageViewer();
        }


        private void Initialize_Semaphore()
        {
            bms_resourcePool = new Semaphore(0, bms_maximumThreads);
            bms_resourcePool.Release();

            pcs_resourcePool = new Semaphore(0, pcs_maximumThreads);
            pcs_resourcePool.Release();
            dbConnector = new DBConnector();
        }

        private void Allocate_Observer_to_Mimic()
        {
            observers = p_measure;
            bmsviewer.AddObserver(observers);
            observers = p_measure_BMS_Rack;
            bmsviewer.AddObserver(observers);
            observers = p_mimic;
            bmsviewer.AddObserver(observers);

            observers = p_mimic;
            pmdviewer.AddObserver(observers);

            observers = p_main;
            bmsviewer.AddObserver(observers);

            observers = p_main;
            pmdviewer.AddObserver(observers);

            observers = p_measure_PCS_Fault;
            pmdviewer.AddObserver(observers);

            observers = p_measure_PCS;
            pmdviewer.AddObserver(observers);
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

            DateTime baseTime = new DateTime(2018, 4, 1, 0, 0, 0);
            TimeSpan timeDiff = DateTime.Now.Subtract(baseTime);
            pmd.DateTime = timeDiff.TotalSeconds;

            pmd.Frequency = BitConverter.ToInt16(data, 8) / 1000;

            // F052
            //PMD_DI_Status
        }

        #region GnEPS PCS의 데이터 획득
        public void Get_PCS(byte[] data)
        {
            /*
            GnEPS_PCS.Stand_Grid_Mode = (BitConverter.ToInt16(data, 0) & 0x80) >> 7;
            GnEPS_PCS.Diesel_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x10) >> 5;
            GnEPS_PCS.Wind_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x0F) >> 4;
            GnEPS_PCS.Solar_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x08) >> 3;
            GnEPS_PCS.ESS_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x04) >> 2;
            GnEPS_PCS.Inverter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x02) >> 1;
            GnEPS_PCS.System_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x01) >> 0;
            */
            //pcs_resourcePool.WaitOne();

            //Mode_Standby

            GnEPS_PCS.GRID_R_Voltage = ByteConverterToUInt16(data, 0);
            GnEPS_PCS.GRID_S_Voltage = ByteConverterToUInt16(data, 1);
            GnEPS_PCS.GRID_T_Voltage = ByteConverterToInt16(data, 2);
            GnEPS_PCS.GRID_R_Current = ByteConverterToInt16(data, 3);
            GnEPS_PCS.GRID_S_Current = ByteConverterToInt16(data, 4);
            GnEPS_PCS.GRID_T_Current = ByteConverterToInt16(data, 5);
            GnEPS_PCS.GRID_Power = ByteConverterToInt16(data, 6);
            p_setting.power.setPCSPower(GnEPS_PCS.GRID_Power);

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

            GnEPS_PCS.Control_MODE = ByteConverterToInt16(data, 31);

            GnEPS_PCS.Mode_Standby = (GnEPS_PCS.Control_MODE >> 0) & 0x01;
            GnEPS_PCS.Mode_Peak_cut = (GnEPS_PCS.Control_MODE >> 2) & 0x01;
            GnEPS_PCS.Mode_Charging = (GnEPS_PCS.Control_MODE >> 6) & 0x01;
            GnEPS_PCS.Mode_Discharging = (GnEPS_PCS.Control_MODE >> 7) & 0x01;
            GnEPS_PCS.Mode_Reset = (GnEPS_PCS.Control_MODE >> 8) & 0x01;
            GnEPS_PCS.Mode_ACKED = (GnEPS_PCS.Control_MODE >> 10) & 0x01;

            GnEPS_PCS.Fault_System_CB_Status = ByteConverterToInt16(data, 32);
            GnEPS_PCS.Inverter_Current_Reference = ByteConverterToInt16(data, 33);
            GnEPS_PCS.Inverter_Q_Current = ByteConverterToInt16(data, 34);
            GnEPS_PCS.Inverter_D_Current = ByteConverterToInt16(data, 35);

            GnEPS_PCS.Battery_Voltage = ByteConverterToInt16(data, 50);
            GnEPS_PCS.Battery_Current = ByteConverterToInt16(data, 51);

            TagManager.PCS_Fault_처리_프로시져();

            //pcs_resourcePool.Release();

            //-----------------------------------------------
            // 20180709 DataTable안에 데이터를 넣는 로직.
            // 43~80은 Battery System의 항목이기에 ID 필터링 이후 값을 넣도록 한다.
            // 그리고 InputCH는 동일하다.
            //-----------------------------------------------
            Insert_To_DataTable(data, 1, 42, 0);

        }
        #endregion
        public void Get_BSC(byte[] data)
        {

            //bms_resourcePool.WaitOne();
            byte[] temp_byte = new byte[2];

            samsung_bcs.Protocol_Version = ByteConverterToUInt16(data, 0);
            samsung_bcs.System_Voltage = ByteConverterToUInt16(data, 1) * 0.1;
            samsung_bcs.System_Current = ByteConverterToInt16(data, 2);
            samsung_bcs.System_Power = samsung_bcs.System_Voltage * samsung_bcs.System_Current / 1000;



            //t_dr[0]["Value"] = ByteConverterToUInt16(data, 1) * 0.1;      

            // Charging과 DisCHarging을 나누기 위해서 만듬
            p_setting.power.setBMSPower(samsung_bcs.System_Power);

            if (!(samsung_bcs.System_SOC == ByteConverterToUInt16(data, 3) * 0.1))
            {
                pmdviewer.flag_WriteSOCBuffers_isChanged = true;
                samsung_bcs.System_SOC = ByteConverterToUInt16(data, 3) * 0.1;
            }


            if (!(samsung_bcs.System_SOH == ByteConverterToUInt16(data, 4) * 0.1))
            {
                pmdviewer.flag_WriteSOCBuffers_isChanged = true;
                samsung_bcs.System_SOH = ByteConverterToUInt16(data, 4) * 0.1;
            }

            if (!(samsung_bcs.System_Mode == ByteConverterToUInt16(data, 5)))
            {
                pmdviewer.flag_WriteSOCBuffers_isChanged = true;
                samsung_bcs.System_Mode = ByteConverterToUInt16(data, 5);
            }



            // SOC
            pmdviewer.WriteSOCBuffers[0] = data[6];
            pmdviewer.WriteSOCBuffers[1] = data[7];

            // 전압
            pmdviewer.WriteVoltageBuffers[0] = data[2];
            pmdviewer.WriteVoltageBuffers[1] = data[3];

            // 전류
            pmdviewer.WriteCurrentBuffers[0] = data[4];
            pmdviewer.WriteCurrentBuffers[1] = data[5];

            // Heartbit
            pmdviewer.WriteHeartBitBuffers[0] = data[50];
            pmdviewer.WriteHeartBitBuffers[1] = data[51];



            samsung_bcs.Mode_Charging = (samsung_bcs.System_Mode >> 15) & 0x01;
            samsung_bcs.Mode_Discharging = (samsung_bcs.System_Mode >> 14) & 0x01;
            samsung_bcs.Mode_Offline = (samsung_bcs.System_Mode >> 10) & 0x01;
            samsung_bcs.Mode_Idle = (samsung_bcs.System_Mode >> 9) & 0x01;
            samsung_bcs.Mode_Ready = (samsung_bcs.System_Mode >> 8) & 0x01;
            samsung_bcs.Mode_InputSignal4 = (samsung_bcs.System_Mode >> 7) & 0x01;
            samsung_bcs.Mode_InputSignal3 = (samsung_bcs.System_Mode >> 6) & 0x01;
            samsung_bcs.Mode_InputSignal2 = (samsung_bcs.System_Mode >> 5) & 0x01;
            samsung_bcs.Mode_InputSIgnal1 = (samsung_bcs.System_Mode >> 4) & 0x01;
            samsung_bcs.Mode_OutputControl2 = (samsung_bcs.System_Mode >> 1) & 0x01;
            samsung_bcs.Mode_OutputControl1 = (samsung_bcs.System_Mode >> 0) & 0x01;

            samsung_bcs.System_Max_Voltage = ByteConverterToUInt16(data, 6) * 0.001;
            samsung_bcs.System_Min_Voltage = ByteConverterToUInt16(data, 7) * 0.001;
            samsung_bcs.System_Max_Temp = ByteConverterToInt16(data, 8) * 0.01;
            samsung_bcs.System_Min_Temp = ByteConverterToInt16(data, 9) * 0.01;
            samsung_bcs.Protection_Summary4 = ByteConverterToUInt16(data, 14);
            samsung_bcs.Protection_Summary3 = ByteConverterToUInt16(data, 15);
            samsung_bcs.Protection_Summary2 = ByteConverterToUInt16(data, 16);
            samsung_bcs.Protection_Summary1 = ByteConverterToUInt16(data, 17);
            samsung_bcs.Alarm_Summary4 = ByteConverterToUInt16(data, 18);
            samsung_bcs.Alarm_Summary3 = ByteConverterToUInt16(data, 19);
            samsung_bcs.Alarm_Summary2 = ByteConverterToUInt16(data, 20);
            samsung_bcs.Alarm_Summary1 = ByteConverterToUInt16(data, 21);

            samsung_bcs.Discharge_Current_Limit_of_Rack = ByteConverterToUInt16(data, 22) * 0.1;
            samsung_bcs.Charge_Current_Limit = ByteConverterToUInt16(data, 23) * 0.1;
            samsung_bcs.Watchdog_Response = ByteConverterToInt16(data, 24);

            samsung_bcs.System_Heartbit = ByteConverterToUInt16(data, 25);
            samsung_bcs.Connecting_Status = ByteConverterToUInt16(data, 26);

            samsung_bcs.Service_Voltage = ByteConverterToUInt16(data, 27) * 0.1;
            samsung_bcs.Service_SOC = ByteConverterToUInt16(data, 28) * 0.1;

            samsung_bcs.System_Alarm_Status = ByteConverterToUInt16(data, 30);
            dbConnector.Insert_Value_to_Database();
            TagManager.BMS_Fault_처리_프로시져();

            //bms_resourcePool.Release();
            Insert_To_DataTable(data,43,80, 0 );
        }

        private void Insert_To_DataTable(byte[] data, int start, int end , int offset)
        {

            //-----------------------------------------------
            //20180709 DataTable안에 데이터를 넣는 로직.
            // 43~80은 Battery System의 항목이기에 ID 필터링 이후 값을 넣도록 한다.
            // 그리고 InputCH는 동일하다.
            //-----------------------------------------------
            DataRow[] t_dr = Tag_Data_Table.Select();
            foreach (DataRow dr in t_dr)
            {

                int temp_InputCH = (Convert.ToUInt16(dr["InputCH"])) - offset;
                int temp_ID = Convert.ToInt16(dr["ID"]);

                if (temp_ID >= start && temp_ID <= end)
                {
                    dr["Value"] = ByteConverterToUInt16(data, temp_InputCH);
                }

            }
        }

        public void Insert_Rack(ref Samsung_BMS_Rack Rack, byte[] data, int num_of_Rack)
        {

            int offset = num_of_Rack * 60 - 40;

            Rack.Rack_Voltage = ByteConverterToUInt16(data, 40+ offset) * 0.1;
            Rack.String1_Rack_Voltage = ByteConverterToUInt16(data, 41+ offset) * 0.1;
            Rack.String2_Rack_Voltage = ByteConverterToUInt16(data, 42+ offset) * 0.1;
            Rack.String1_Cell_Summation_Voltage = ByteConverterToUInt16(data, 43 + offset) * 0.1;
            Rack.String2_Cell_Summation_Voltage = ByteConverterToUInt16(data, 44 + offset) * 0.1;

            Rack.Rack_Current = ByteConverterToInt16(data, 45 + offset) * 0.1;
            Rack.String1_Rack_Current = ByteConverterToInt16(data, 46 + offset) * 0.1;
            Rack.String2_Rack_Current = ByteConverterToInt16(data, 47 + offset) * 0.1;
            Rack.Rack_Current_Average = ByteConverterToInt16(data, 48 + offset) * 0.1;
            Rack.Rack_Mode = ByteConverterToUInt16(data, 49 + offset);
            Rack.Rack_SOC = ByteConverterToInt16(data, 50 + offset) * 0.1;
            Rack.Rack_SOH = ByteConverterToInt16(data, 51 + offset) * 0.1;


            Rack.Max1_Cell_Voltage_Value = ByteConverterToInt16(data, 64 + offset) * 0.001;
            Rack.Max1_Cell_Voltage_Position = ByteConverterToInt16(data, 65 + offset);
            Rack.Max2_Cell_Voltage_Value = ByteConverterToInt16(data, 66 + offset) * 0.001;
            Rack.Max2_Cell_Voltage_Position = ByteConverterToInt16(data, 67 + offset);

            Rack.Average_Cell_Voltage_Value = ByteConverterToInt16(data, 68 + offset) * 0.001;
            Rack.Min2_Cell_Voltage_Value = ByteConverterToInt16(data, 69 + offset) * 0.001;
            Rack.Min2_Cell_Voltage_Position = ByteConverterToInt16(data, 70 + offset);
            Rack.Min1_Cell_Voltage_Value = ByteConverterToInt16(data, 71 + offset) * 0.001;
            Rack.Min1_Cell_Voltage_Position = ByteConverterToInt16(data, 72 + offset);

            Rack.Max1_Cell_Temp_Value = ByteConverterToInt16(data, 73 + offset) * 0.01;
            Rack.Max1_Cell_Temp_Position = ByteConverterToInt16(data, 74 + offset);
            Rack.Max2_Cell_Temp_Value = ByteConverterToInt16(data, 75 + offset) * 0.01;
            Rack.Max2_Cell_Temp_Position = ByteConverterToInt16(data, 76 + offset);

            Rack.Average_Cell_Temp_Value = ByteConverterToInt16(data, 77 + offset) * 0.01;

            Rack.Min2_Cell_Temp_Value = ByteConverterToInt16(data, 78 + offset) * 0.01;
            Rack.Min2_Cell_Temp_Position = ByteConverterToInt16(data, 79 + offset);
            Rack.Min1_Cell_Temp_Value = ByteConverterToInt16(data, 80 + offset) * 0.01;
            Rack.Min1_Cell_Temp_Position = ByteConverterToInt16(data, 81 + offset);

            Rack.Rack_Discharge_Current_Limit_of_Rack = ByteConverterToUInt16(data, 82 + offset) * 0.1;
            Rack.Rack_Charge_Current_Limit_of_Rack = ByteConverterToUInt16(data, 83 + offset) * 0.1;

            Rack.Rack_Switch_Control_Info = ByteConverterToUInt16(data, 84 + offset);
            Rack.Rack_Switch_Sensor_Info = ByteConverterToUInt16(data, 85 + offset);
            Rack.Rack_External_Sensor_Info = ByteConverterToUInt16(data, 86 + offset);
            Rack.Module_Comm_Fault_Position = (ByteConverterToUInt16(data, 86 + offset) >> 8) & 0xFF;

            if (num_of_Rack == 1)
            {
                Insert_To_DataTable(data, 81, 114, offset);
            }
            else if (num_of_Rack == 2)
            {
                Insert_To_DataTable(data, 115, 148, offset);
            }
            
        }

        private ushort ByteConverterToUInt16(byte[] data, int offset)
        {
            return BitConverter.ToUInt16(swapbyte(data, offset * 2), 0);
        }
        private short ByteConverterToInt16(byte[] data, int offset)
        {
            return BitConverter.ToInt16(swapbyte(data, offset * 2), 0);
        }

        private byte[] swapbyte(byte[] word, int offset)
        {
            //BSC_Controller_Data[0]  =   BSC1[0] * 256 + data[1];
            byte[] data = new Byte[2];

            data[0] = word[offset + 1];
            data[1] = word[offset];

            return data;
        }

    }
}

