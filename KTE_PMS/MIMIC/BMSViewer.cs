﻿using KTE_PMS.Observer;
using ModbusTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class BMSViewer : Form
    {

        public ModbusTCP.Master MBmaster;

        public byte[] BSC_Rack_Data { get; set; }
        public byte[] BSC_Module_Data { get; set; }
        public byte[] BSC_Rack_Version { get; set; }
        public byte[] BSC_Controller_Data { get; set; }
        public byte[] BSC1 { get; set; }
        public byte[] BSC2 { get; set; }

        DateTime tLastRecv;
        public byte[] WriteValueBuffers { get; set; }

        public BMSViewer()
        {
            InitializeComponent();

            WriteValueBuffers = new byte[64];
            tLastRecv = new DateTime();
            tLastRecv = DateTime.Now;

            if (Properties.Settings.Default.DEBUG) return;
            
            MBmaster = new Master();



            BSC_Controller_Data = new Byte[14];

            BSC1 = new Byte[50];
            // For test. IP 설정창을 그린 후 해당 내용으로 교체할 예정임
            // Samsung Battery로 변경함
            if (Properties.Settings.Default.DEBUG)
            {
                txtIP1.Text = "127";
                txtIP2.Text = "0";
                txtIP3.Text = "0";
                txtIP4.Text = "1";
            }
            else
            {
                txtIP1.Text = "17";
                txtIP2.Text = "91";
                txtIP3.Text = "30";
                txtIP4.Text = "246";
            }
            //-----------------------------
            // Modbus TCP - BMS 통신 시도 //
            //-----------------------------
            // 1. File에서 설정값 읽어오기
            //Read_BSC_Configuration();
            // 2. 연결하기
            Connect_to_BSC();

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Start();

        }

        private void txtIP1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ReadFromBSC()
        {
            //MBmaster.ReadHoldingRegister((ushort)0, (Byte)3, (ushort)40000, (Byte)3);
            ushort ID = 1;
            byte unit = Convert.ToByte(0);
            ushort StartAddress = ReadStartAdr(0);
            byte Length = Convert.ToByte(100);

            MBmaster.ReadInputRegister(ID, unit, StartAddress, Length);
            
        }
        public void WriteToBSC(byte value)
        {
            ushort ID = 8;
            byte unit = Convert.ToByte(0);
            ushort StartAddress = ReadStartAdr(0);
            byte Length = Convert.ToByte(1);

            WriteValueBuffers[0] = 0;
            WriteValueBuffers[1] = value;

            // Samsung Battery
            
            MBmaster.WriteSingleRegister(ID, unit, StartAddress, WriteValueBuffers);

        }
        public void GRID_ON()
        {
            WriteToBSC(5);
        }
        public void GRID_OFF()
        {
            WriteToBSC(3);
        }
        public void WATCHDOG(short value)
        {
            ushort ID = 8;
            byte unit = Convert.ToByte(0);
            ushort StartAddress = ReadStartAdr(2);
            byte Length = Convert.ToByte(1);

            
            WriteValueBuffers[0] = Convert.ToByte(value / 256);
            WriteValueBuffers[1] = Convert.ToByte(value % 256);

            // Samsung Battery

            MBmaster.WriteSingleRegister(ID, unit, StartAddress, WriteValueBuffers);

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

            
            // ------------------------------------------------------------------------
            // Identify requested data
            switch (ID)
            {
                case 1:
                    // ---------------------------------------------------------
                    // 30000~30100
                    // ---------------------------------------------------------
                    Repository.Instance.Get_BSC(values);
                    tLastRecv = DateTime.Now;
                    Notify();
                    break;

                case 8:
                    //grpData.Text = "Write multiple register";
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
            System.Diagnostics.Debug.WriteLine(exc);
            //MessageBox.Show(exc, "Modbus slave exception");
        }
        public void Connect_to_BSC()
        {
            try
            {
                // Create new modbus master and add event functions

                string ip_address = txtIP1.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text;
                //string ip_address = "127.0.0.1";
                ushort port_number = 502;
                MBmaster = new Master(ip_address, port_number);

                // Setting response data and exception
                MBmaster.OnResponseData += new Master.ResponseData(MBmaster_OnResponseData);
                MBmaster.OnException += new Master.ExceptionData(MBmaster_OnException);

                //flag_BSC_Connection = 1;
            }
            catch (SystemException error)
            {
                MessageBox.Show(error.Message + "다시 접속해 주세요");
                System.Diagnostics.Debug.WriteLine(error.Message + "다시 접속해 주세요");
                //flag_BSC_Connection = 0;
            }
        }



        public byte get_BSC1(int i)
        {
            return BSC1[i];
        }


        public void Connect_to_PCS()
        {
            //modbus_rtu = new Modbus_Setup();
        }

        private ushort ReadStartAdr(UInt16 StartAddress)
        {
            return StartAddress;
        }

        private void Read_BSC_Configuration()
        {
            string directory = System.Windows.Forms.Application.StartupPath;
            string filename = "\\Configs.dat";
            // ----------------------------------------------------------------------------------------
            // 파일을 읽어서 List에 넣기
            // cTag에 저장하기
            // 항상 동작하면서 cTag에 있는 값을 해당되는 통신방식에 맞게 값을 읽어오고 주기적으로 쓴다  
            // ----------------------------------------------------------------------------------------         
            try
            {
                FileStream fs = File.OpenRead(directory + filename);

                StreamReader r = new StreamReader(fs, System.Text.Encoding.Default);

                // 문자 스트림 변환
                r.BaseStream.Seek(0, SeekOrigin.Begin);

                // 일단 찾고
                // 하기

                // Skip First Line //
                string temp = r.ReadLine();

                // 만약 끝이 아니라면
                while (r.Peek() > -1)
                {
                    // 1 Line 을 읽는다.
                    temp = r.ReadLine();

                    // 2. BSC 관련 값을 찾는다. BSC가 아니라면 다음 라인을 읽는다
                    if (temp.Contains("BSC Setting"))
                    {

                        ///type = LG
                        ///ip_address = 172.31.110.33
                        ///port = 504
                        ///
                        string[] split;


                        // Read ////////////
                        temp = r.ReadLine();
                        split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                        // Manufacture of BSC
                        temp = r.ReadLine();
                        split = System.Text.RegularExpressions.Regex.Split(temp, "=");

                        // Read Ip address
                        temp = r.ReadLine();
                        split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                        string kk = split[1].Trim();

                        string[] split2 = split[1].Split(new char[] { '.' });

                        txtIP1.Text = split2[0].ToString().Trim();
                        txtIP2.Text = split2[1].ToString().Trim();
                        txtIP3.Text = split2[2].ToString().Trim();
                        txtIP4.Text = split2[3].ToString().Trim();

                        // Read Port
                        temp = r.ReadLine();
                        split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                        txtPort.Text = split[1].ToString().Trim();
                        break;
                    }

                }


                r.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Abort");
                throw e;
            }

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

            if (span.TotalSeconds < 10)
            {
                if (Repository.Instance.TagManager.FAULT_STATUS[47, 10, 0] != "0")
                    Repository.Instance.TagManager.경보발생및해제(0, 47, 10);
                return 1;
            }
            else
            {
                if (Repository.Instance.TagManager.FAULT_STATUS[47, 10, 0] != "1")
                    Repository.Instance.TagManager.경보발생및해제(1, 47, 10);
                return 0;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 1초 Timer에 의해서 수행되는 코드
            //-----------------------------------------------------------
            // Read From BSC
            // BSC와 연결되어있다면 Read 시도, 그렇지 않다면 재접속 시도.
            //-----------------------------------------------------------

            //-----------------------------------------------------------
            // Read From BSC
            // BSC와 연결되어있다면 Read 시도, 그렇지 않다면 재접속 시도.
            //-----------------------------------------------------------
            ReadFromBSC();
        }
    }
}
