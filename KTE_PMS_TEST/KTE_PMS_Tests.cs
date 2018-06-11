using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTE_PMS;


namespace KTE_PMS_TEST
{
    [TestClass]
    public class KTE_PMS_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] data;
            data = new byte[60];

            data[42] = 1;
            Repository.Instance.Get_BSC(data);
            Repository.Instance.TagManager.BMS_Fault_처리_프로시져();
            Repository.Instance.p_alarm.LoadCurrentFault();
        }
    }
}
