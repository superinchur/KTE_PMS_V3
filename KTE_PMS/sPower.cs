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

        public static sPower operator+ (sPower a, sPower b)
        {
            sPower newPower = new sPower();

            newPower.BMS_CHARGE_POWER = a.BMS_CHARGE_POWER + b.BMS_CHARGE_POWER;
            newPower.BMS_DISCHARGE_POWER = a.BMS_DISCHARGE_POWER + b.BMS_DISCHARGE_POWER;
            newPower.PCS_CHARGE_POWER = a.PCS_CHARGE_POWER + b.PCS_CHARGE_POWER;
            newPower.PCS_DISCHARGE_POWER = a.PCS_DISCHARGE_POWER + b.PCS_DISCHARGE_POWER;
            return newPower;

        }
    }
}
