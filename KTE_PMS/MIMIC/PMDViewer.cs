using KTE_PMS.Observer;
using ModbusTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
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
        private System.Threading.Timer threadingtimer;
        private int flag_PMD_Connection;

        private byte[] data;

        public PMDViewer()
        {
            InitializeComponent();
            master = new ModbusTCP.Master();

            threadingtimer = new System.Threading.Timer(ThreadingTimerCallback, null, 0, 1000);
            WriteValueBuffers = new byte[2];
            WriteHeartBitBuffers = new byte[2];
            WriteSOCBuffers = new byte[2];
            WriteVoltageBuffers = new byte[2];
            WriteCurrentBuffers = new byte[2];

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

        // ---------------------------------------------------------
        // 1초 Thread. 추기적으로 Read와 Write를 날린다
        // ---------------------------------------------------------
        private void ThreadingTimerCallback(object state)
        {
            WriteHeartBit();

            WriteSOC();
            WriteVoltage();
            WriteCurrent();
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
                master.OnException += new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
                //flag_PMD_Connection = 1;
            }
            catch (SystemException error)
            {
                //MessageBox.Show(error.Message + "다시 접속해 주세요");
                System.Diagnostics.Debug.WriteLine(error.Message + "다시 접속해 주세요");
                //flag_PMD_Connection = 0;
            }
        }

        public void ReadFromBSC()
        {
            //MBmaster.ReadHoldingRegister((ushort)0, (Byte)3, (ushort)40000, (Byte)3);
            ushort ID = 1;
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(0);
            byte Length = Convert.ToByte(40);


            master.ReadHoldingRegister(ID, unit, StartAddress, Length);
        }
        public void WriteToBSC()
        {
            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(2);
            byte Length = Convert.ToByte(4);

            //master.WriteSingleRegister(8, unit, StartAddress, WriteValueBuffers);
            /*
            BSC_Controller_Data[0] = BSC1[0];
            BSC_Controller_Data[1] = BSC1[1];
            BSC_Controller_Data[2] = Convert.ToByte(0);
            BSC_Controller_Data[3] = BSC_Controler_Status; // Controller Status
            BSC_Controller_Data[4] = Convert.ToByte(0);
            BSC_Controller_Data[5] = BSC_ReqtoControl_AllContactors; // Req to control All Contactors
            BSC_Controller_Data[6] = Convert.ToByte(0);
            BSC_Controller_Data[7] = BSC_Reset; // Req BSC Reset
            BSC_Controller_Data[8] = Convert.ToByte(0);
            BSC_Controller_Data[9] = BSC_Manual_Mode_Request_Ack; // Manual Mode Request Ack
            BSC_Controller_Data[10] = Convert.ToByte(0);
            BSC_Controller_Data[11] = BSC_Request_Sleep; // Request Sleep (Normal Power Saving Mode)
            BSC_Controller_Data[12] = Convert.ToByte(0);
            BSC_Controller_Data[13] = BSC_Request_Connection; // Request Connection / Disconnection / OS Shutdown

            MBmaster.WriteMultipleRegister(ID, unit, StartAddress, BSC_Controller_Data);
            */
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
            buffer[0] = Convert.ToByte(value / 256);
            buffer[1] = Convert.ToByte(value % 256);

            master.WriteSingleRegister(8, unit, StartAddress, buffer);
        }
        public void Control_Power_Active_Set()
        {

            byte unit = Convert.ToByte(1);
            ushort StartAddress = ReadStartAdr(1);

            //ushort power = Convert.ToUInt16(Regex.Replace("10", @"\D", ""));
            ushort power = Repository.Instance.remote_power;
            if (power > 500)
            {
                power = 500;
            }

            byte[] buffer = new byte[2];
            buffer[0] = Convert.ToByte(power / 256);
            buffer[1] = Convert.ToByte(power % 256);

            master.WriteSingleRegister(8, unit, StartAddress, buffer);
        }

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


        private void Read_PMD_Configuration()
        {
            //string directory = "C:\\Users\\ipms\\Desktop\\ESS\\KTE_PMS\\";
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
                    if (temp.Contains("PMD Setting"))
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

        private ushort ReadStartAdr()
        {
            /*
            // Convert hex numbers into decimal
            if (txtStartAdress.Text.IndexOf("0x", 0, txtStartAdress.Text.Length) == 0)
            {
                string str = txtStartAdress.Text.Replace("0x", "");
                ushort hex = Convert.ToUInt16(str, 16);
                return hex;
            }
            else
            {
                return Convert.ToUInt16(txtStartAdress.Text);
            }
            
            */
            return 0;
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
    }

}
