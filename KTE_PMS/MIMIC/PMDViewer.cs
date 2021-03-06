﻿using KTE_PMS.Observer;
using ModbusTCP;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class PMDViewer : Form
    {
        public ModbusTCP.Master master;

        public byte[] WriteValueBuffers { get; set; }
        public byte[] WriteHeartBitBuffers { get; set; }
        public byte[] WriteSOCBuffers { get; set; }
        public byte[] WriteVoltageBuffers { get; set; }
        public byte[] WriteCurrentBuffers { get; set; }

        /* 180625 
         * 부하를 줄이기 위해서 이전값과 비교해서 값이 바뀌었을때만 PCS로 보내주도록 한다.
         * */

        public bool flag_WriteValueBuffers_isChanged { get; set; }
        public bool flag_WriteHeartBitBuffers_isChanged { get; set; }
        public bool flag_WriteSOCBuffers_isChanged { get; set; }
        public bool flag_WriteVoltageBuffers_isChanged { get; set; }
        public bool flag_WriteCurrentBuffers_isChanged { get; set; }


        private byte[] data;
        private int timeoff;

        DateTime tLastRecv;
        public PMDViewer()
        {
            InitializeComponent();

            tLastRecv = new DateTime();
            tLastRecv = DateTime.Now;

            timeoff = 10;
            
            if (Properties.Settings.Default.DEBUG) return;

            master = new Master();
            WriteValueBuffers = new byte[2];
            WriteHeartBitBuffers = new byte[2];
            WriteSOCBuffers = new byte[2];
            WriteVoltageBuffers = new byte[2];
            WriteCurrentBuffers = new byte[2];

            MBmaster_Connect();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();

        }

        private void MBmaster_Connect()
        {
            // For test. IP 설정창을 그린 후 해당 내용으로 교체할 예정임
            txtIP1.Text = "17";
            txtIP2.Text = "91";
            txtIP3.Text = "30";
            txtIP4.Text = "10";

            //-----------------------------
            // Modbus TCP - uPMD 통신 시도 //
            //-----------------------------
            // 1. File에서 설정값 읽어오기
            // Not Yet
            //Read_PMD_Configuration();
            // 2. 연결하기
            Connect_to_PMD();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 20180723 자동재접속을 하도록 프로그램을 수정하려고 했으나 실패함
            // MBmaster.connected의 값을 신뢰할 수가 없음. 그래서 정상적으로 동작하지 않음
            // 자동 재접속이 아닌 재접속 버튼을 통한 재접속을 하도록 수정
            if (true)
            //if (master.connected)
            {
                // Mode에 따라서 동작하도록 코드 수정
                PMS_Scheduling_Operation();
            }
            else
            {
                //Thread t1 = new Thread(new ThreadStart(MBmaster_Connect));
                //t1.Start();

            }
            timer.Interval = timeoff * 1000;
        }

        private void PMS_Scheduling_Operation()
        {
            if (DateTime.Now.Second % 2 == 1)
            {
                ReadFromPCS();
            }
            else
            {
                if (Repository.Instance.current_pcs_mode == 2 )
                {
                    //Manual Mode 충전모드 상태임
                    // 충전 정지 SOC를 확인하자, 그리고 현재 상태도 확인.  
                    if ((Repository.Instance.GnEPS_PCS.Mode_Charging == 1))
                    {
                        if (Repository.Instance.samsung_bms.System_SOC >= Repository.Instance.p_control.Charging_Stop_SOC)
                        {
                            Repository.Instance.pmdviewer.Control_Idle();
                        }
                    }
                    else
                    {
                        if (Repository.Instance.samsung_bms.System_SOC < Repository.Instance.p_control.Charging_Stop_SOC)
                        {
                            Repository.Instance.pmdviewer.Control_Charge();
                        }
                        else
                        {
                            Repository.Instance.pmdviewer.Control_Idle();
                        }
                    }

                }
                else if (Repository.Instance.current_pcs_mode == 3)
                {
                    //Manual Mode 방전모드 상태임
                    // 방전 정지 SOC를 확인하자, 그리고 현재 상태도 확인.  
                    if ((Repository.Instance.GnEPS_PCS.Mode_Discharging == 1))
                    {
                        if (Repository.Instance.samsung_bms.System_SOC <= Repository.Instance.p_control.Discharging_Stop_SOC)
                        {
                            Repository.Instance.pmdviewer.Control_Idle();
                        }
                    }
                    else
                    {
                        if (Repository.Instance.samsung_bms.System_SOC > Repository.Instance.p_control.Discharging_Stop_SOC)
                        {
                            Repository.Instance.pmdviewer.Control_Discharge();
                        }
                        else 
                        {
                            Repository.Instance.pmdviewer.Control_Idle();
                        }
                    }
                }
                else if (Repository.Instance.current_pcs_mode == 4 || Repository.Instance.current_pcs_mode == 5)
                {
                    // 충전모드라면 충전신호를 보낸다. 충전모드가 아니라면 충전신호를 지속적으로 보낸다
                    // 방전모드라면 방전신호를 보낸다. 방전모드가 아니라면 방전신호를 지속적으로 보낸다.
                    // 단 방전/충전 정지 SOC, 방전/충전 시작 SOC등을 확인해서 신호를 보낸다.

                    // Charging시간이 아니더라도 Charging 조건은 가장 우선시해야한다.

                    if (Repository.Instance.flag_Charging_Time)
                    {
                        if ((Repository.Instance.GnEPS_PCS.Mode_Charging == 1))
                        {
                            if (Repository.Instance.samsung_bms.System_SOC >= Repository.Instance.p_control.Charging_Stop_SOC)
                            {
                                Repository.Instance.pmdviewer.Control_Idle();
                            }
                        }
                        else
                        {
                            if (Repository.Instance.samsung_bms.System_SOC < Repository.Instance.p_control.Charging_Stop_SOC)
                            {
                                Repository.Instance.pmdviewer.Control_Charge();
                            }
                            else
                            {
                                Repository.Instance.pmdviewer.Control_Idle();
                            }
                        }
                    }
                    else if (Repository.Instance.flag_DisCharging_Time)
                    {
                        //Manual Mode 방전모드 상태임
                        // 방전 정지 SOC를 확인하자, 그리고 현재 상태도 확인.  
                        if ((Repository.Instance.GnEPS_PCS.Mode_Discharging == 1))
                        {
                            if (Repository.Instance.samsung_bms.System_SOC <= Repository.Instance.p_control.Discharging_Stop_SOC)
                            {
                                Repository.Instance.pmdviewer.Control_Idle();
                            }
                        }
                        else
                        {
                            if (Repository.Instance.samsung_bms.System_SOC > Repository.Instance.p_control.Discharging_Stop_SOC)
                            {
                                Repository.Instance.pmdviewer.Control_Discharge();
                            }
                            else
                            {
                                Repository.Instance.pmdviewer.Control_Idle();
                            }
                        }
                    }
                    else
                    {
                        // nothing to do
                        // 만약 충전신호나 방전신호가 가고있다면 0으로 바꿔준다.

                        if (Repository.Instance.samsung_bms.System_SOC <= Repository.Instance.p_control.Charging_Stop_SOC)
                        {
                            if (!(Repository.Instance.GnEPS_PCS.Mode_Charging == 1))
                            {
                                Repository.Instance.pmdviewer.Control_Charge();
                            }
                        }
                        else if (Repository.Instance.samsung_bms.System_SOC >= Repository.Instance.p_control.Discharging_Stop_SOC)
                        {
                            if (!(Repository.Instance.GnEPS_PCS.Mode_Discharging == 1))
                            {
                                Repository.Instance.pmdviewer.Control_Discharge();
                            }
                        }
                        else if ((Repository.Instance.GnEPS_PCS.Mode_Discharging == 1) || (Repository.Instance.GnEPS_PCS.Mode_Charging == 1))
                        {
                            Repository.Instance.pmdviewer.Control_Idle();
                        }
                        else
                        {
                            // nothing to do
                            //Console.WriteLine("Unexpected Situtation. Need to Check");                        
                        }
                    }
                }
            }
            /* 변경이 있을때만 보내도록 하자  */

            if (flag_WriteHeartBitBuffers_isChanged)
            {
                WriteHeartBit();
                flag_WriteHeartBitBuffers_isChanged = false;
            }

            if (flag_WriteSOCBuffers_isChanged)
            {
                WriteSOC();
                flag_WriteSOCBuffers_isChanged = false;
            }
            if (flag_WriteVoltageBuffers_isChanged)
            {
                WriteVoltage();
                flag_WriteVoltageBuffers_isChanged = false;
            }
            if (flag_WriteCurrentBuffers_isChanged)
            {
                WriteCurrent();
                flag_WriteCurrentBuffers_isChanged = false;
            }
        }

        private void Connect_to_PMD()
        {
            try
            {
                // Create new modbus master and add event functions
                string ip_address = "17.91.30.10";
                ushort port_number = 502;
                master = new Master(ip_address, port_number);

                // Setting response data and exception
                master.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                master.OnException += new Master.ExceptionData(MBmaster_OnException);

                timeoff = 1;
            }
            catch (SocketException error)
            {
                Console.WriteLine(timeoff.ToString() + "    :    " + error.Message + "다시 접속해 주세요");
                if (timeoff < 65536)
                {
                    timeoff = timeoff << 1;
                }

            }
            catch (SystemException error)
            {
                Console.WriteLine(timeoff.ToString() + "    :    " + error.Message + "다시 접속해 주세요");
                if (timeoff < 65536)
                {
                    timeoff = timeoff << 1;
                }
            }
        }

        public void ReadFromPCS()
        {
            ushort ID = 4;
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(30);
            byte Length = Convert.ToByte(52);

            master.ReadHoldingRegister(ID, unit, StartAddress, Length);

        }

        public void WriteHeartBit()
        {
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(5);

            master.WriteSingleRegister(8, unit, StartAddress, WriteHeartBitBuffers);

        }
        public void WriteVoltage()
        {
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(3);

            master.WriteSingleRegister(8, unit, StartAddress, WriteVoltageBuffers);

        }
        public void WriteCurrent()
        {
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(4);

            master.WriteSingleRegister(8, unit, StartAddress, WriteCurrentBuffers);

        }
        public void WriteSOC()
        {
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(2);

            master.WriteSingleRegister(8, unit, StartAddress, WriteSOCBuffers);

        }
        public void Control_INV_Control_MODE(int value)
        {
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(0);

            byte[] buffer = new byte[2];


            // 20180628 
            //Reset 신호와 Remote Local 신호를 구분하기 위해서 
            // Value에 제어 값과 And를 해서 보내도록 한다
            int final_control = new int();

            if (Repository.Instance.GnEPS_PCS.PCS_ACK)
            {
                final_control = value + 256;
            }
            if (Repository.Instance.GnEPS_PCS.Authority_PMS)
            {
                // Authority_PMS가 1인 경우에는 LEMS에서 제어를 하고
                // Authority_PMS가 0인 경우에는 u_PMS에서 제어를 한다.
                final_control = value + 512;
            }
            buffer[0] = Convert.ToByte(final_control / 256);
            buffer[1] = Convert.ToByte(final_control % 256);

            try
            {
                // ID = 8, Unit = 1, StartAddress = 0
                master.WriteSingleRegister(8, unit, StartAddress, buffer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Control_Power_Active_Set()
        {

            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(1);


            ushort power = Repository.Instance.remote_power;
            if (power > 500)
            {
                power = 500;
            }

            byte[] buffer = new byte[2];
            buffer[0] = Convert.ToByte(power / 256);
            buffer[1] = Convert.ToByte(power % 256);

            try
            {
                master.WriteSingleRegister(8, unit, StartAddress, buffer);
            }
            catch (Exception exc)
            {
                MessageBox.Show("PCS와의 통신 연결 상태를 확인해주십시오");
                Console.WriteLine(exc.Message);
            }

        }

        // 180628 Reset과 Control 신호의 Add를 위해서 Control_INV_Control_Mode를 변경해야할 필요성이 있음

        public void Control_Charge()
        {

            Control_Power_Active_Set();
            Control_INV_Control_MODE(69);
        }
        public void Control_Discharge()
        {
            Control_Power_Active_Set();
            Control_INV_Control_MODE(133);
        }
        public void Control_Idle()
        {
            Control_Power_Active_Set();
            Control_INV_Control_MODE(1);
        }


        // ------------------------------------------------------------------------
        // Event for response data
        // ------------------------------------------------------------------------
        private void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
        {

            // ------------------------------------------------------------------

            // Seperate calling threads
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Master.ResponseData(MBmaster_OnResponseData), new object[] { ID, unit, function, values });
                return;
            }

            // PCS Timeout을 체크하기 위해서 필요한 항목

            tLastRecv = DateTime.Now;

            // ------------------------------------------------------------------------
            // Identify requested data
            switch (ID)
            {
                case 1:
                    // ---------------------------------------------------------
                    // 40000 ~ 40049
                    // ---------------------------------------------------------
                    //BSC1 = values;

                    break;
                case 2:
                    //grpData.Text = "Read discrete inputs";
                    //data = values;

                    //값을 받아와야함


                    break;
                case 3:
                    //grpData.Text = "Read holding register";
                    data = values;

                    break;
                case 4:
                    //grpData.Text = "Read input register";
                    data = values;
                    Repository.Instance.Get_PCS(data);
                    Notify();
                    break;

            }

        }

        // ------------------------------------------------------------------------
        // Modbus TCP slave exception
        // ------------------------------------------------------------------------
        private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
        {
            string exc = "Modbus says error: ";
            switch (exception)
            {
                case Master.excIllegalFunction: exc += "Illegal function!"; break;
                case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
                case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
                case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
                case Master.excAck: exc += "Acknoledge!"; break;
                case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
                case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
                case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
                case Master.excExceptionNotConnected: exc += "Not connected!"; break;
            }

            //MessageBox.Show(exc, "Modbus slave exception");
            System.Diagnostics.Debug.WriteLine(exc);
        }

        private ushort ReadStartAdr(UInt16 StartAddress)
        {
            return StartAddress;
        }

        public List<IUpdate> observers = new List<IUpdate>();
        public void AddObserver(IUpdate observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IUpdate observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IUpdate observer in observers)
            {
                observer.ObserverUpdate();
            }
        }

        public int Connected()
        {
            DateTime dt_now;

            dt_now = DateTime.Now;

            TimeSpan span = dt_now - tLastRecv;

            if (span.TotalSeconds < 15)
            {
                if (Repository.Instance.TagManager.FAULT_STATUS[48, 8, 0] != "0")
                    Repository.Instance.TagManager.경보발생및해제(0, 48, 8);
                return 1;
            }
            else
            {
                if (Repository.Instance.TagManager.FAULT_STATUS[48, 8, 0] != "1")
                    Repository.Instance.TagManager.경보발생및해제(1, 48, 8);
                return 0;
            }
        }
    }

}
