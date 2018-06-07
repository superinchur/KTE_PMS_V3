using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTE_PMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KTE_PMS.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        [TestMethod()]
        public void Get_PCSTest()
        {
            byte[] data = new byte[200];
            
            data[0] = 0x40;
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x80) >> 7));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x40) >> 6));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x20) >> 5));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x10) >> 4));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x08) >> 3));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x04) >> 2));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x02) >> 1));
            System.Diagnostics.Debug.WriteLine(((BitConverter.ToInt16(data, 0) & 0x01) >> 0));
            
            /*
            GnEPS_PCS.Diesel_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x10) >> 5;
            GnEPS_PCS.Wind_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x0F) >> 4;
            GnEPS_PCS.Solar_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x08) >> 3;
            GnEPS_PCS.ESS_Converter_Run_Stop = (BitConverter.ToInt16(data, 0) & 0x04) >> 2;
            
            
            repository.Get_PCS(data);
            */
        }
    }
}