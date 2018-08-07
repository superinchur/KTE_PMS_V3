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

        public int PCS_CHARGE_COUNT { get; set; }
        public int PCS_DISCHARGE_COUNT { get; set; }

        public int BMS_CHARGE_COUNT { get; set; }
        public int BMS_DISCHARGE_COUNT { get; set; }


        public sPower()
        {
            PCS_CHARGE_POWER = 0;
            PCS_DISCHARGE_POWER = 0;
            BMS_CHARGE_POWER = 0;
            BMS_DISCHARGE_POWER = 0;
            PCS_CHARGE_COUNT = 0;
            PCS_DISCHARGE_COUNT = 0;
            BMS_CHARGE_COUNT = 0;
            BMS_DISCHARGE_COUNT = 0;
        }
        public sPower GetValue()
        {
            sPower answer = new sPower();

            if (this.BMS_CHARGE_COUNT == 0)
            {
                answer.BMS_CHARGE_POWER = 0;
            }
            else
            {
                answer.BMS_CHARGE_POWER = this.BMS_CHARGE_POWER / this.BMS_CHARGE_COUNT;
            }
            if (this.BMS_DISCHARGE_COUNT == 0)
            {
                answer.BMS_DISCHARGE_POWER = 0;
            }
            else
            {
                answer.BMS_DISCHARGE_POWER = this.BMS_DISCHARGE_POWER / this.BMS_DISCHARGE_COUNT;
            }
            if (this.PCS_CHARGE_COUNT == 0)
            {
                answer.PCS_CHARGE_POWER = 0;
            }
            else
            {
                answer.PCS_CHARGE_POWER = this.PCS_CHARGE_POWER / this.PCS_CHARGE_COUNT;
            }
            if (this.PCS_DISCHARGE_COUNT == 0)
            {
                answer.PCS_DISCHARGE_POWER = 0;
            }
            else
            {
                answer.PCS_DISCHARGE_POWER = this.PCS_DISCHARGE_POWER / this.PCS_DISCHARGE_COUNT;
            }

            PCS_CHARGE_POWER = 0;
            PCS_DISCHARGE_POWER = 0;
            BMS_CHARGE_POWER = 0;
            BMS_DISCHARGE_POWER = 0;
            PCS_CHARGE_COUNT = 0;
            PCS_DISCHARGE_COUNT = 0;
            BMS_CHARGE_COUNT = 0;
            BMS_DISCHARGE_COUNT = 0;

            return answer;
        }
        public bool setBMSPower(double power)
        {
            if (power > 0)
            {
                BMS_CHARGE_POWER = BMS_CHARGE_POWER + power;
                BMS_CHARGE_COUNT++;

            }
            else if (power < 0)
            {
                BMS_DISCHARGE_POWER = -1 * BMS_DISCHARGE_POWER + power;
                BMS_DISCHARGE_COUNT++;
            }
            return true;
        }

        public bool setPCSPower(double power)
        {
            if (power > 0)
            {
                PCS_CHARGE_POWER = PCS_CHARGE_POWER + power;
                PCS_CHARGE_COUNT++;
            }
            else if (power < 0)
            {
                PCS_DISCHARGE_POWER = -1 * PCS_DISCHARGE_POWER + power;
                PCS_DISCHARGE_POWER++;
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
