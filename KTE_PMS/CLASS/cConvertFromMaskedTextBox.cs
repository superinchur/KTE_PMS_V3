using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTE_PMS.CLASS
{
    class cConvertFromMaskedTextBox
    {
        public float ToSingle(MaskedTextBox maskedTextBox)
        {
            string[] temp;
            temp = maskedTextBox.Text.Trim().Split('.');

            temp[0] = temp[0].Trim();
            temp[1] = temp[1].Trim();
            if (temp[0] == null)
            {
                temp[0] = "0";
            }
            if (temp[1] == null)
            {
                temp[1] = "0";
            }
            float ret = Convert.ToSingle(temp[0] + "." + temp[1]);
         
            
            return ret;
        }
    }


}
