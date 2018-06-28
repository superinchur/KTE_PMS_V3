using System;
using System.Linq;

namespace KTE_PMS.MIMIC
{
    public class cTag
    {
        public string Address { set; get; }
        public Boolean AlrAckValue { set; get; }
        public string AlrDisable { set; get; }
        public Boolean AlrOffValue { set; get; }
        public Boolean AlrOnValue { set; get; }
        public string AlrStatus { set; get; }
        public string CommType { set; get; }
        public string CommUrl { set; get; }
        public string Description { set; get; }
        public string DevM { set; get; }
        public string DevMLimit { set; get; }
        public string DevP { set; get; }
        public string DevPLimit { set; get; }
        public string DevSetpoint { set; get; }
        public string DisplayMax { set; get; }
        public string DisplayMin { set; get; }
        public string DisplayUnit { set; get; }
        public string DisplayValue { set; get; }
        public Boolean Hi { set; get; }
        public Boolean HiHi { set; get; }
        public float HiHiLimit { set; get; }
        public float HiLimit { set; get; }
        public string Index { set; get; }
        public Boolean Lo { set; get; }
        public float LoLimit { set; get; }
        public Boolean LoLo { set; get; }
        public float LoLoLimit { set; get; }
        public float Max { set; get; }
        public string MemberName { set; get; }
        public float Min { set; get; }
        public string Name { set; get; }
        public string OriginalTag { set; get; }
        public string Quality { set; get; }
        public string Rate { set; get; }
        public string RateLimit { set; get; }
        public string Size { set; get; }
        public string Source { set; get; }
        public DateTime TimeStamp { set; get; }
        public Boolean UnAck { set; get; }
        public string Unit { set; get; }
        public string UnitAdd { set; get; }
        public string UnitDiv { set; get; }
        public string Used { set; get; }

        public float value;

        public cTag()
        {
            //Address = 
            //Description = "";

        }
        public bool Changed;

        public void Tag_Update(Repository rep)
        {
            // Repository에 있는 값을
            // Address를 통해서 값을 읽어오기
            GetData(rep);
            // TimeStamp 설정
            TimeStamp = DateTime.Now;
            // Alarm 설정
            SetAlarm();
        }
        private void GetData(Repository rep)
        {
            //value = rep.get_BSC1(Convert.ToInt32(Address));
        }

        private void SetAlarm()
        {
            /*/////////////////////////////
           //    Alarm에 대한 처리     //
           ////////////////////////////*/
            // LoLo에 대한 Alarm 처리
            if (LoLoLimit > value) LoLo = true;
            else LoLo = false;
            // Low에 대한 Alarm 처리
            if (LoLimit > value) Lo = true;
            else Lo = false;
            // HiHi에 대한 Alarm 처리
            if (HiHiLimit < value)
            {
                HiHi = true;
            }
            else
            {
                HiHi = false;
            }

            // Hi에 대한 Alarm 처리
            if (HiLimit < value)
            {
                Hi = true;
            }
            else
            {
                Hi = false;
            }
        }
    }


}
