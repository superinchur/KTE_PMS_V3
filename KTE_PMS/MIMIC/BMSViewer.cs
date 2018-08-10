using KTE_PMS.Observer;
using ModbusTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
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

        private int timeoff { get; set; }


        DateTime tLastRecv;
        public byte[] WriteValueBuffers { get; set; }

        public BMSViewer()
        {
            InitializeComponent();

            WriteValueBuffers = new byte[64];
            tLastRecv = new DateTime();
            tLastRecv = DateTime.Now;




            BSC_Controller_Data = new Byte[14];
            BSC1 = new Byte[60];
            timeoff = 10;
            MBmaster = new Master();

            MBmaster_Connect();

            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Start();

        }

        private void MBmaster_Connect()
        {

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
        }

        private void txtIP1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ReadFromBSC(ushort ID)
        {
            //MBmaster.ReadHoldingRegister((ushort)0, (Byte)3, (ushort)40000, (Byte)3);
            //ushort ID = 1;
            byte unit = Convert.ToByte(0);

            ushort temp_startaddr = new ushort();
            ushort temp_length = new ushort();

            if (ID == 1)
            {
                temp_startaddr = 0;
                temp_length = 40;
            }
            else if (ID == 2)
            {
                temp_startaddr = 40;
                temp_length = 51;
            }
            else if (ID == 3)
            {
                temp_startaddr = 100;
                temp_length = 51;
            }


            ushort StartAddress = ReadStartAdr(temp_startaddr);
            byte Length = Convert.ToByte(temp_length);

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

                    Thread t1 = new Thread(new ParameterizedThreadStart(ThreadProc1));
                    t1.Start(values);
                    tLastRecv = DateTime.Now;
                    Notify();
                    break;
                case 2:
                    Thread t2 = new Thread(new ParameterizedThreadStart(ThreadProc2));
                    t2.Start(values);

                    //Repository.Instance.Insert_Rack(ref Repository.Instance.samsung_bcs.Rack1, values, 1);
                    tLastRecv = DateTime.Now;
                    Notify();
                    break;
                case 3:
                    Thread t3 = new Thread(new ParameterizedThreadStart(ThreadProc3));
                    t3.Start(values);
                    
                    tLastRecv = DateTime.Now;
                    Notify();
                    break;
                case 8:
                    //grpData.Text = "Write multiple register";
                    break;
            }



        }

        public static void ThreadProc1(object values)
        {
            Repository.Instance.Get_BSC((byte[])values);
        }
        public static void ThreadProc2(object values)
        {
            Repository.Instance.Insert_Rack(ref Repository.Instance.samsung_bcs.Rack1, (byte[])values, 1);
        }
        public static void ThreadProc3(object values)
        {
            Repository.Instance.Insert_Rack(ref Repository.Instance.samsung_bcs.Rack2, (byte[])values, 2);
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
            Console.WriteLine(exc);           
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
                timeoff = 1;
                
                //flag_BSC_Connection = 1;
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
                Console.WriteLine(error.Message + "다시 접속해 주세요");
                if (timeoff < 65536)
                {
                    timeoff = timeoff << 1;
                }
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
            string directory = Application.StartupPath;
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

                        //TimeInterval;
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

            if (span.TotalSeconds < 15)
            {
                if (Repository.Instance.TagManager.FAULT_STATUS[48, 10, 0] != "0")
                    Repository.Instance.TagManager.경보발생및해제(0, 48, 10);
                return 1;
            }
            else
            {
                if (Repository.Instance.TagManager.FAULT_STATUS[48, 10, 0] != "1")
                    Repository.Instance.TagManager.경보발생및해제(1, 48, 10);


                //MBmaster.Dispose();
                //Connect_to_BSC();
                //if (Properties.Settings.Default.DEBUG ) Console.WriteLine("재접속 시도합니다");

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
            if (Properties.Settings.Default.DEBUG) return;

            //if (MBmaster.connected)
            if (true)
            {
                //-----------------------------------------------------------
                try
                {
                    ReadFromBSC(Convert.ToUInt16(((DateTime.Now.Second % 3) + 1)));
                    timer.Interval = timeoff * 1000;

                }

                catch (SystemException system_ex)
                {
                    Console.WriteLine(timeoff.ToString() + " : " + system_ex.Message);
                }
            }         
            else
            {
                // 20180723 자동재접속을 하도록 프로그램을 수정하려고 했으나 실패함
                // MBmaster.connected의 값을 신뢰할 수가 없음. 그래서 정상적으로 동작하지 않음
                // 자동 재접속이 아닌 재접속 버튼을 통한 재접속을 하도록 수정

                //Thread t1 = new Thread(new ThreadStart(MBmaster_Connect));
                //t1.Start();
                //timer.Interval = timeoff * 1000;
            }

            
        }
    }
}
