using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTE_PMS
{
    public class sPower
    {
        public double PCS_CHARGE_POWER { get; set; }
        public double PCS_DISCHARGE_POWER { get; set; }
        public double BMS_CHARGE_POWER { get; set; }
        public double BMS_DISCHARGE_POWER { get; set; }

        public bool setBMSPower(double power)
        {
            if (power > 0)
            {
                BMS_CHARGE_POWER = BMS_CHARGE_POWER + power;

            }
            else if (power < 0)
            {
                BMS_DISCHARGE_POWER = BMS_DISCHARGE_POWER + power;
            }
            return true;
        }

        public bool setPCSPower(double power)
        {
            if (power > 0)
            {
                PCS_CHARGE_POWER = PCS_CHARGE_POWER + power;

            }
            else if (power < 0)
            {
                PCS_DISCHARGE_POWER = PCS_DISCHARGE_POWER + power;
            }
            return true;
        }

    }
}
