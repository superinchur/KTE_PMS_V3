using System;
using System.IO;
using System.IO.Ports;
using System.Timers;
using System.Windows.Forms;


namespace KTE_PMS
{
    public partial class Modbus_Setup : Form
    {
        Modbus_RTU mb = new Modbus_RTU();
        SerialPort sp = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();
        string dataType;
        bool isPolling = false;
        int pollCount;

        #region GUI Delegate Declarations
        public delegate void GUIDelegate(string paramString);
        public delegate void GUIClear();
        public delegate void GUIStatus(string paramString);
        #endregion


        private string pcs_port;
        private string pcs_baudrate;
        private string pcs_parity;
        private string pcs_stopbit;
        private int pcs_readtimeout;
        private int pcs_writetimeout;

        private string directory = System.Windows.Forms.Application.StartupPath;
        private string filename = "\\Configs.dat";

        public Modbus_Setup()
        {
            InitializeComponent();
            LoadListboxes();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            // Parameter 값을 미리 설정하고 생성하자 마자 바로 연결 시도 //
            StartPoll();

            //-----------------------------
            // Modbus RTU - PCS 통신 시도 //
            //-----------------------------
            // 1. File에서 설정값 읽어오기
            // Not Yet
            Read_PCS_Configuration();
            // 2. 연결하기
            //Connect_to_PCS();
        }
        public Modbus_Setup(string port, string baudrate, string parity, string stopbit, int readtimeout, int writetimeout)
        {
            InitializeComponent();
            LoadListboxes();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            lstPorts.SelectedIndex = lstPorts.FindString(port);
            lstBaudrate.SelectedIndex = lstPorts.FindString(baudrate);
            txtSampleRate.Text = readtimeout.ToString();

            // Parameter 값을 미리 설정하고 생성하자 마자 바로 연결 시도 //
            StartPoll();

            //-----------------------------
            // Modbus RTU - PCS 통신 시도 //
            //-----------------------------
            // 1. File에서 설정값 읽어오기
            // Not Yet
            //Read_PCS_Configuration();
            // 2. 연결하기
            //Connect_to_PCS();
        }

        #region Delegate Functions
        public void DoGUIClear()
        {
            if (this.InvokeRequired)
            {
                GUIClear delegateMethod = new GUIClear(this.DoGUIClear);
                this.Invoke(delegateMethod);
            }
            else
                this.lstRegisterValues.Items.Clear();
        }
        public void DoGUIStatus(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIStatus delegateMethod = new GUIStatus(this.DoGUIStatus);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
                this.lblStatus.Text = paramString;
        }
        public void DoGUIUpdate(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoGUIUpdate);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
                this.lstRegisterValues.Items.Add(paramString);
        }
        #endregion

        #region Timer Elapsed Event Handler
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PollFunction();
        }
        #endregion

        #region Load Listboxes
        private void LoadListboxes()
        {
            //Three to load - ports, baudrates, datetype.  Also set default textbox values:
            //1) Available Ports:
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                lstPorts.Items.Add(port);
            }
            //lstPorts.SelectedIndex = 0;

            //2) Baudrates:
            string[] baudrates = { "230400", "115200", "57600", "38400", "19200", "9600" };

            foreach (string baudrate in baudrates)
            {
                lstBaudrate.Items.Add(baudrate);
            }

            lstBaudrate.SelectedIndex = 1;

            //3) Datatype:
            string[] dataTypes = { "Decimal", "Hexadecimal", "Float", "Reverse" };

            foreach (string dataType in dataTypes)
            {
                lstDataType.Items.Add(dataType);
            }

            lstDataType.SelectedIndex = 0;

            //Textbox defaults:
            txtRegisterQty.Text = "20";
            txtSampleRate.Text = "1000";
            txtSlaveID.Text = "1";
            txtStartAddr.Text = "0";
        }
        #endregion

        #region Start and Stop Procedures
        private void StartPoll()
        {
            pollCount = 0;
            try
            {
                //Open COM port using provided settings:
                if (mb.Open(lstPorts.SelectedItem.ToString(), Convert.ToInt32(lstBaudrate.SelectedItem.ToString()),
                    8, Parity.None, StopBits.One))
                {
                    //Disable double starts:
                    btnStart.Enabled = false;
                    dataType = lstDataType.SelectedItem.ToString();

                    //Set polling flag:
                    isPolling = true;

                    //Start timer using provided values:
                    timer.AutoReset = true;
                    if (txtSampleRate.Text != string.Empty)
                        timer.Interval = Convert.ToDouble(txtSampleRate.Text);
                    else
                        timer.Interval = 1000;
                    timer.Start();
                }

                lblStatus.Text = mb.modbusStatus;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        private void StopPoll()
        {
            //Stop timer and close COM port:
            isPolling = false;
            timer.Stop();
            mb.Close();

            btnStart.Enabled = true;

            lblStatus.Text = mb.modbusStatus;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartPoll();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPoll();
        }
        #endregion

        #region Poll Function
        private void PollFunction()
        {
            //Update GUI:
            DoGUIClear();
            pollCount++;
            DoGUIStatus("Poll count: " + pollCount.ToString());

            //Create array to accept read values:
            short[] values = new short[Convert.ToInt32(txtRegisterQty.Text)];
            ushort pollStart;
            ushort pollLength;

            if (txtStartAddr.Text != string.Empty)
                pollStart = Convert.ToUInt16(txtStartAddr.Text);
            else
                pollStart = 0;
            if (txtRegisterQty.Text != string.Empty)
                pollLength = Convert.ToUInt16(txtRegisterQty.Text);
            else
                pollLength = 20;

            //Read registers and display data in desired format:
            try
            {
                while (!mb.SendFc3(Convert.ToByte(txtSlaveID.Text), pollStart, pollLength, ref values)) ;
            }
            catch (Exception err)
            {
                DoGUIStatus("Error in modbus read: " + err.Message);
            }

            string itemString;

            switch (dataType)
            {
                case "Decimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Hexadecimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString("X");
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Float":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i];
                        intValue <<= 16;
                        intValue += (int)values[2 * i + 1];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Reverse":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i + 1];
                        intValue <<= 16;
                        intValue += (int)values[2 * i];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
            }

            // 값 넣고

            // Notification

        }
        #endregion

        #region Write Function
        private void WriteFunction()
        {
            StopPoll();

            if (txtWriteRegister.Text != string.Empty && txtWriteValue.Text != string.Empty && txtSlaveID.Text != string.Empty)
            {
                byte address = Convert.ToByte(txtSlaveID.Text);
                ushort start = Convert.ToUInt16(txtWriteRegister.Text);
                short[] value = new short[1];
                value[0] = Convert.ToInt16(txtWriteValue.Text);

                try
                {
                    while (!mb.SendFc16(address, start, (ushort)1, value)) ;
                }
                catch (Exception err)
                {
                    DoGUIStatus("Error in write function: " + err.Message);
                }
                DoGUIStatus(mb.modbusStatus);
            }
            else
                DoGUIStatus("Enter all fields before attempting a write");

            //StartPoll();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteFunction();
        }
        #endregion

        #region Data Type Event Handler
        private void lstDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //restart the data poll if datatype is changed during the process:
            if (isPolling)
            {
                StopPoll();
                dataType = lstDataType.SelectedItem.ToString();
                StartPoll();
            }

        }
        #endregion


        private void Read_PCS_Configuration()
        {
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
                    if (temp.Contains("PCS Setting"))
                    {
                        try
                        {
                            string[] split;
                            //Read ////////////////
                            temp = r.ReadLine();
                            //split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            ///Read ID=1_enable = 0
                            temp = r.ReadLine();
                            //split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            ///Read ID = 1
                            temp = r.ReadLine();
                            //split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            ///port =
                            ///baudrate =
                            /////////parity =
                            ///stopbit
                            ///readtimeout =
                            ///writetimeout =

                            // read Port
                            temp = r.ReadLine();
                            split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            pcs_port = split[1].Trim();

                            // read baudrate
                            temp = r.ReadLine();
                            split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            pcs_baudrate = split[1].Trim();

                            // read parity bit
                            temp = r.ReadLine();
                            split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            pcs_parity = split[1].Trim();

                            // Read stopbit
                            temp = r.ReadLine();
                            split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            pcs_stopbit = split[1].Trim();

                            // Read readtimeout
                            temp = r.ReadLine();
                            split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            pcs_readtimeout = Convert.ToInt16(split[1].ToString().Trim());
                            // Read writetimeout
                            temp = r.ReadLine();
                            split = System.Text.RegularExpressions.Regex.Split(temp, "=");
                            pcs_writetimeout = Convert.ToInt16(split[1].ToString().Trim());
                            break;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Abort");
                            //throw e;
                        }
                    }

                }


                r.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Abort");
                //throw e;
            }
        }

    }
}
