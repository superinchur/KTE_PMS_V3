﻿using KTE_PMS.MIMIC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Linq;

namespace KTE_PMS
{
    public class TagManager
    {
        private const int TSize = 3;

        Repository repository;
        public cTag[] tt;
        public Dictionary<string, cTag> dictionary = new Dictionary<string, cTag>();
        string directory;

        string filename = "\\TagList.csv";

        public Dictionary<string, string> htCurrentFault = new Dictionary<string, string>();
        Queue<string> qRecvFault = new Queue<string>();

        public string[,] FAULT_CODE = {{"46_0", "Black out"}, {"46_1", "Over frequency"}, {"46_2", "Under frequency"}, {"46_3", "Over Voltage"},{"46_4", "Under Voltage"},
                                        {"46_5", "Reserved"}, {"46_6", "Reserved"}, {"46_7", "Reserved"}, {"46_8", "Reserved"}, {"46_9", "Reserved"}, {"46_10", "Reserved"}, {"46_11", "Reserved"},
                                        {"46_12", "Reserved"}, {"46_13", "Reserved"}, {"46_13", "Reserved"}, {"46_14", "Reserved"}, {"46_15", "Reserved"},
                                        {"47_0", "INV_OVR"}, {"47_1", "INV_OCR"}, {"47_2", "GRID_OCR"}, {"47_3", "DC_OCR"}, {"47_4", "DC_UVR"}, {"47_5", "DC_OCR"},
                                        {"47_6", "OT"}, {"47_7", "Door_Open_Fault"}, {"47_8", "PCS Comm Fault"}, {"47_9", "HW Fault"}};

        public string[,] Samsung_BMS_FAULT_CODE = {{"14_15", "Reserved"} , {"14_14", "Reserved"}, {"14_13", "Reserved"},{"14_12", "Reserved"},{"14_11", "Reserved"}, {"14_10", "Reserved"},{"14_9", "Reserved"}, {"14_8", "Reserved"},
            {"14_7", "Reserved"}, {"14_6", "Reserved"}, {"14_5", "Reserved"},{"14_4", "Reserved"}, {"14_3", "Reserved"}, {"14_2", "Reserved"},{"14_1", "Reserved"}, {"14_0", "Additional Protection Fail"},{"15_15", "Cell dchg operation limit"},
            {"15_14", "Cell chg operation limit"}, {"15_13", "Module pcb ot"}, {"15_12", "Module pcb ut"}, {"15_11", "Dcsw3_fail"}, {"15_10", "Dcsw3_sensing_fail"}, {"15_9", "Dcsw2_sensing_fail"}, {"15_8", "Dcsw1_sensing_fail"}, {"15_7", "Reserved"},
            {"15_6", "Reserved"}, {"15_5", "Reserved"}, {"15_4", "Reserved"}, {"15_3", "Reserved"}, {"15_2", "Reserved"}, {"15_1", "Reserved"}, {"15_0", "Reserved"}, {"16_15", "Reserved"}, {"16_14", "Reserved"}, {"16_13", "Reserved"},
            {"16_12", "Reserved"}, {"16_11", "Reserved"}, {"16_10", "Reserved"}, {"16_9", "Reserved"}, {"16_8", "Reserved"}, {"16_7", "Reserved"}, {"16_6", "Reserved"},
            {"16_5", "Reserved"}, {"16_4", "Reserved"}, {"16_3", "Reserved"}, {"16_2", "Reserved"}, {"16_1", "Rack string I-imb"}, {"16_0", "Rack string V-imb"}, {"17_15", "Permanent uv"}, {"17_14", "Rack fuse fail"}, {"17_13", "Rack I sensor fail"},
            {"17_12", "Rack V sensing diff"}, {"17_11", "Rack OV"}, {"17_10", "Rack UV"}, {"17_9", "Rack DchqOC"}, {"17_8", "Rack ChgOC"}, {"17_7", "R-S comm fail"}, {"17_6", "R-M comm fail"}, {"17_5", "Module T-imb"}, {"17_4", "Module V-imb"},
            {"17_3", "Module OV"}, {"17_2", "Module UV"}, {"17_1", "Module OT"}, {"17_0", "Module UT"}, {"18_15", "Reserved"}, {"18_14", "Reserved"}, {"18_13", "Reserved"}, {"18_12", "Reserved"}, {"18_11", "Reserved"}, {"18_10", "Reserved"},
            {"18_9", "Reserved"}, {"18_8", "Reserved"}, {"18_7", "Reserved"}, {"18_6", "Reserved"}, {"18_5", "Reserved"}, {"18_4", "Reserved"}, {"18_3", "Reserved"}, {"18_2", "Reserved"}, {"18_1", "Reserved"}, {"18_0", "Additional Protection Fail"},
            {"19_15", "Cell dchg operation limit"}, {"19_14", "Cell chg operation limit"}, {"19_13", "Module pcb ot"}, {"19_12", "Module pcb ut"}, {"19_11", "Dcsw3_fail"}, {"19_10", "Dcsw3_sensing_fail"}, {"19_9", "Dcsw2_sensing_fail"},
            {"19_8", "Dcsw1_sensing_fail"}, {"19_7", "Reserved"}, {"19_6", "Reserved"}, {"19_5", "Reserved"}, {"19_4", "Reserved"}, {"19_3", "Reserved"}, {"19_2", "Reserved"}, {"19_1", "Reserved"}, {"19_0", "Reserved"}, {"20_15", "Reserved"},
            {"20_14", "Reserved"}, {"20_13", "Reserved"}, {"20_12", "Reserved"}, {"20_11", "Reserved"}, {"20_10", "Reserved"}, {"20_9", "Reserved"}, {"20_8", "Reserved"}, {"20_7", "Reserved"}, {"20_6", "Reserved"}, {"20_5", "Reserved"},
            {"20_4", "Reserved"}, {"20_3", "Reserved"}, {"20_2", "Reserved"}, {"20_1", "Rack string I-imb"}, {"20_0", "Rack string V-imb"}, {"21_15", "Permanent uv"}, {"21_14", "Rack fuse fail"}, {"21_13", "Rack I sensor fail"},
            {"21_12", "Rack V sensing diff"}, {"21_11", "Rack OV"}, {"21_10", "Rack UV"}, {"21_9", "Rack DchqOC"}, {"21_8", "Rack ChgOC"}, {"21_7", "R-S comm fail"}, {"21_6", "R-M comm fail"}, {"21_5", "Module T-imb"},
            {"21_4", "Module V-imb"}, {"21_3", "Module OV"}, {"21_2", "Module UV"}, {"21_1", "Module OT"}, {"21_0", "Module UT"}};


        public string[,,] FAULT_STATUS = new string[256, 17, 3];
        public string[,,] BMS_FAULT_STATUS = new string[256, 17, 3];


        public TagManager(Repository rep)
        {
            directory = Application.StartupPath;

            // ----------------------------------------------------------------------------------------
            // 파일을 읽어서 List에 넣기
            // cTag에 저장하기
            // 항상 동작하면서 cTag에 있는 값을 해당되는 통신방식에 맞게 값을 읽어오고 주기적으로 쓴다  
            // ----------------------------------------------------------------------------------------
            repository = rep;

            tt = new cTag[TSize];
            for (int i = 0; i < TSize; i++)
            {
                tt[i] = new cTag();
            }

            
            Read_AlarmData(ref tt);
        }

        public string GetFaultText(int nFileNo, int nBit)
        {
            string szReturn = "";


            for (int i = 0; i <= Samsung_BMS_FAULT_CODE.GetLength(0) - 1; i++)
            {

                string szFileNo = Samsung_BMS_FAULT_CODE[i, 0];

                if (szFileNo == string.Format("{0}_{1}", nFileNo, nBit))
                {
                    szReturn = Samsung_BMS_FAULT_CODE[i, 1];
                    break;
                }
            }

            return szReturn;
        }

        public void PCS_Fault_처리_프로시져()
        {

            // PCS_DataDisplay(szMode, szMessage)
            // 46~47 에러 하기 (PCS쪽 Fault)
            for (int nFileNo = 46; nFileNo <= 47; nFileNo++)
            {
                //ushort ushValue = GetModbusData_Ushort(nFileNo);
                ushort ushValue = 0;

                for (int nBit = 0; nBit <= 15; nBit++)
                {
                    int nStatus = ushValue >> nBit & 0x1;
                    if (FAULT_STATUS[nFileNo, nBit, 0] != nStatus.ToString())
                        경보발생및해제(nStatus, nFileNo, nBit);
                }
            }
        }

        public void BMS_Fault_처리_프로시져()
        {
            ushort ushValue;
            // 14~15 에러 하기 (BMS쪽 Fault)
            for (int nFileNo = 14; nFileNo <= 22; nFileNo++)
            {
                
                for (int nBit = 0; nBit <= 15; nBit++)
                {
                    if (nFileNo == 14)
                        ushValue = Repository.Instance.samsung_bcs.Protection_Summary4;
                    else if (nFileNo == 15)
                        ushValue = Repository.Instance.samsung_bcs.Protection_Summary3;
                    else if (nFileNo == 16)
                        ushValue = Repository.Instance.samsung_bcs.Protection_Summary2;
                    else if (nFileNo == 17)
                        ushValue = Repository.Instance.samsung_bcs.Protection_Summary1;
                    else if (nFileNo == 18)
                        ushValue = Repository.Instance.samsung_bcs.Alarm_Summary4;
                    else if (nFileNo == 19)
                        ushValue = Repository.Instance.samsung_bcs.Alarm_Summary3;
                    else if (nFileNo == 20)
                        ushValue = Repository.Instance.samsung_bcs.Alarm_Summary2;
                    else if (nFileNo == 21)
                        ushValue = Repository.Instance.samsung_bcs.Alarm_Summary1;
                    else
                        ushValue = 0;


                    int nStatus = ushValue >> nBit & 0x1;

                    if (FAULT_STATUS[nFileNo, nBit, 0] == null)
                        FAULT_STATUS[nFileNo, nBit, 0] = "";

                    if (FAULT_STATUS[nFileNo, nBit, 0] != nStatus.ToString())
                    { 
                        경보발생및해제(nStatus, nFileNo, nBit);
                    }
                }
            }
            
        }

        private string getDeviceName(int nFileNo)
        {
            if (nFileNo >= 14 && nFileNo <= 22)
            {
                return("BMS");
            }
            else if (nFileNo >= 46 && nFileNo <= 47)
            {
                return("PCS");
            }
            else
            {
                return("Unexpected Device");
            }         
        }
        public void 경보발생및해제(int nStatus, int nFileNo, int nBit)
        {
            // heartbit가 동작중에는 flag_PCS_COMMFAULT Flag를 설정시키기 때문에 
            // Heartbit가 동작중에는 초기화 하는것이 필요하다. Heartbit가 11이 됨으로 부터 정상적인 PCS Alarm 발생을 시작
            string szFaultCode = string.Format("{0}_{1}", nFileNo, nBit);

            // 화면_고장
            string szFaultText = GetFaultText(nFileNo, nBit);
            string DeviceName = getDeviceName(nFileNo);
            DateTime tCurrent = DateTime.Now;



            if (nStatus == 0)
            {
                // 해제
                FAULT_STATUS[nFileNo, nBit, 0] = nStatus.ToString();
                FAULT_STATUS[nFileNo, nBit, 1] = "";
                string szFault = string.Format("{0}|{1}|{2}|{3}|{4}", tCurrent.ToString("yyyy-MM-dd hh:mm:ss") , string.Format("{0} [0x{1:X2}] ", nFileNo, nBit ), DeviceName, szFaultText, "NORMAL");
                qRecvFault.Enqueue(szFault);

                // Ack Bit 여부를 확인하고, Ack면 해제, Ack가 아니라면 UnAcked Normal을 띄워줘야함.
                
                
                foreach (var key in htCurrentFault.Keys.ToList())
                {
                    // 값을 받아온다.
                    string szCurrentFault = htCurrentFault[key] + "";
                    string[] current_IO = szCurrentFault.Split('|');
                    

                    // Unacked이면 Acked로, Unacekd Normal이면 삭제.
                    if (current_IO[4] == "ACK")
                    {
                        Repository.Instance.TagManager.htCurrentFault.Remove(key);
                    }
                    // UNACK라면?
                    else if (current_IO[4] == "UNACK")
                    {
                        szCurrentFault = szCurrentFault.Replace("UNACK", "UNACK NORMAL");
                        Repository.Instance.TagManager.htCurrentFault.Remove(key);
                        Repository.Instance.TagManager.htCurrentFault.Add(key, szCurrentFault);

                    }
                }
            }
            else
            {
                // 발생
                FAULT_STATUS[nFileNo, nBit, 0] = nStatus.ToString();
                FAULT_STATUS[nFileNo, nBit, 1] = tCurrent.ToString("yyyy-MM-dd HH:mm:ss");
                string szFault = string.Format("{0}|{1}|{2}|{3}|{4}", tCurrent.ToString("yyyy-MM-dd hh:mm:ss"),string.Format("{0} [0x{1:X2}] ", nFileNo, nBit), DeviceName, szFaultText, "UNACK");
                qRecvFault.Enqueue(szFault);
                //szFault = string.Format("{0}|{1}|{2}{3}{4}", tCurrent.ToString("yyyy-MM-dd hh:mm:ss"), string.Format("{0} [0x{1:X2}] {2}", nFileNo, nBit, szFaultText), DeviceName, szFaultText);
                htCurrentFault[szFaultCode] = szFault;
            }
        }

        private void 경보전시()
        {
            if (qRecvFault.Count > 0)
            {
                while (qRecvFault.Count > 0)
                {
                    string szFaultData = qRecvFault.Dequeue();
                    string[] szFault = szFaultData.Split('|');

                //qRecvFault.

                }
            }
        }

        private void Read_AlarmData(ref cTag[] tt)
        {
            #region FILE의 입력을 받아서 ALARM 처리 하는 방법 
            /*
            try
            {
                FileStream fs = File.OpenRead(directory + filename);

                StreamReader r = new StreamReader(fs, System.Text.Encoding.Default);
                foreach (cTag i in tt)
                {
                    // 문자 스트림 변환
                    r.BaseStream.Seek(0, SeekOrigin.Begin);

                    // Skip First Line //
                    string temp = r.ReadLine();

                    // 만약 끝이 아니라면
                    if (r.Peek() > -1)
                    {
                        // 1 Line 을 읽는다.
                        temp = r.ReadLine();

                        // 읽은 값을 Parsing 해서 Assign한다.
                        AssignFromFileToTag(temp, i);

                        // Assign 한 값을 Dictionary에 넣는다.
                        // 현재는 Index로 구분하지만 나중에는 TagName으로 구분할 예정으로 수정 필요함
                        dictionary.Add(i.Index, i);

                        //i.Address = Convert.ToString(100);

                    }
                    else
                    {
                        // Unexpected Result
                        throw new Exception();
                    }

                }
                r.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Abort");
                throw e;
            }
            */
            #endregion
        }

        private void AssignFromFileToTag(string temp, cTag i)
        {
            string[] split = System.Text.RegularExpressions.Regex.Split(temp, ",");

            try
            {
                i.AlrOffValue = false;
                i.Index = split[0];
                i.Description = split[2];
                i.Unit = split[3];
                i.Min = Convert.ToSingle(split[12]);
                i.Max = Convert.ToSingle(split[13]);
                /*
                i.LoLimit = Convert.ToSingle(split[14]);
                i.HiLimit = Convert.ToSingle(split[15]);
                i.LoLo = Convert.ToBoolean(split[24]);
                i.Lo = Convert.ToBoolean(split[25]);
                i.Hi = Convert.ToBoolean(split[26]);
                i.HiHi = Convert.ToBoolean(split[27]);
                i.LoLoLimit = Convert.ToSingle(split[29]);
                i.HiHiLimit = Convert.ToSingle(split[30]);
                */
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Abort");
                throw e;
            }
        }

        public void Run()
        {
            try
            {
                foreach (cTag i in tt)
                {
                    if (i.Changed == true)
                    {
                        i.Tag_Update(repository);
                    }
                }
                return;
            }
            catch (Exception e)
            {
                string message;
                message = string.Format("Incorrect exception for {0}", e.Message);
            }
        }
    }
}
