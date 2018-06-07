using KTE_PMS.MIMIC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
        
        
            

        public TagManager(Repository rep)
        {
            directory = System.Windows.Forms.Application.StartupPath;



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
            //int j;
            //j = 0;

            Read_AlarmData(ref tt);


        }

        private void Read_AlarmData(ref cTag[] tt)
        {
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
