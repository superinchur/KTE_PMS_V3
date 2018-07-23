using KTE_PMS.Observer;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class MeasureViewer3 : Viewer, IUpdate
    {
        public MeasureViewer3()
        {
            InitializeComponent();
        }

        private void Measure_Load(object sender, EventArgs e)
        {
        }

        delegate void CrossThreadSafetySetText(Control ctl, String text);

        private void CSafeSetText(Control ctl, String text)
        {

            /*
             * InvokeRequired 속성 (Control.InvokeRequired, MSDN)
             *   짧게 말해서, 이 컨트롤이 만들어진 스레드와 현재의 스레드가 달라서
             *   컨트롤에서 스레드를 만들어야 하는지를 나타내는 속성입니다.  
             * 
             * InvokeRequired 속성의 값이 참이면, 컨트롤에서 스레드를 만들어 텍스트를 변경하고,
             * 그렇지 않은 경우에는 그냥 변경해도 아무 오류가 없기 때문에 텍스트를 변경합니다.
             */
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            else
                ctl.Text = text;
        }

        public void ObserverUpdate()
        {

            switch (tabPane1.SelectedPageIndex)
            {
                case 0:
                    ObserverUpdate_PCS();
                    break;
                case 1:
                    ObserverUpdate_PCS_ALARM();
                    break;
                case 2:
                    ObserverUpdate_BMS_System();
                    break;
                case 3:
                    ObserverUpdate_BMS_Rack1();
                    break;
                case 4:
                    ObserverUpdate_BMS_Rack2();
                    break;
            }

        }

        private void ObserverUpdate_PCS()
        {
            sPCS t = Repository.Instance.GnEPS_PCS;

            // BMS : System용 이다
            // 값 써주기
            CSafeSetText(l11_1, t.GRID_R_Voltage.ToString() + " " + "V");
            CSafeSetText(l12_1, t.GRID_S_Voltage.ToString() + " " + "V");
            CSafeSetText(l13_1, t.GRID_T_Voltage.ToString() + " " + "V");
            CSafeSetText(l14_1, t.GRID_R_Current.ToString() + " " + "A");
            CSafeSetText(l15_1, t.GRID_S_Current.ToString() + " " + "A");
            CSafeSetText(l16_1, t.GRID_T_Current.ToString() + " " + "A");
            CSafeSetText(l17_1, t.GRID_Power.ToString() + " " + "kW");
            CSafeSetText(l18_1, t.GRID_Frequency.ToString() + " " + "Hz");

            if (t.isTemperatureWarning > 0)
            {
                CSafeSetText(l19_1, "WARNING");
            }
            else
            {
                CSafeSetText(l19_1, "NORMAL");
            }
            
            CSafeSetText(l110_1, t.LOAD_R_Current.ToString() + " " + "A");
            CSafeSetText(l111_1, t.LOAD_S_Current.ToString() + " " + "A");
            CSafeSetText(l112_1, t.LOAD_T_Current.ToString() + " " + "A");

            CSafeSetText(l11_2, t.LOAD_Power.ToString() + " " + "kW");
            CSafeSetText(l12_2, t.INVERTER_Power.ToString() + " " + "kW");
            CSafeSetText(l13_2, t.Mode_Standby.ToString());
            CSafeSetText(l14_2, t.Control_MODE.ToString());

            CSafeSetText(l15_2, t.Inverter_Current_Reference.ToString() + " " + "A");
            CSafeSetText(l16_2, t.Inverter_Q_Current.ToString() + " " + "A");
            CSafeSetText(l17_2, t.Inverter_D_Current.ToString() + " " + "A");
            CSafeSetText(l18_2, t.Battery_Voltage.ToString() + " " + "V");
            CSafeSetText(l19_2, t.Battery_Current.ToString() + " " + "A");
        }
        private void ObserverUpdate_PCS_ALARM()
        {
            // Page PCS_ALARM
            sPCS t = Repository.Instance.GnEPS_PCS;

            CSafeSetText(l21_1, t.Fault_Battery_Voltage.ToString() + " " + "V");
            CSafeSetText(l22_1, t.Fault_Battery_Current.ToString() + " " + "V");
            CSafeSetText(l23_1, t.Fault_System_A_Current.ToString() + " " + "A");
            CSafeSetText(l24_1, t.Fault_System_B_Current.ToString() + " " + "A");
            CSafeSetText(l25_1, t.Fault_System_C_Current.ToString() + " " + "A");
            CSafeSetText(l26_1, t.Fault_Inverter_A_Current.ToString() + " " + "A");
            CSafeSetText(l27_1, t.Fault_Inverter_B_Current.ToString() + " " + "A");
            CSafeSetText(l28_1, t.Fault_Inverter_C_Current.ToString() + " " + "A");
            CSafeSetText(l29_1, t.Fault_Inverter_A_Voltage.ToString() + " " + "V");
            CSafeSetText(l210_1, t.Fault_Inverter_B_Voltage.ToString() + " " + "V");
            CSafeSetText(l211_1, t.Fault_Inverter_C_Voltage.ToString() + " " + "V");
            CSafeSetText(l212_1, t.Fault_Active_Power.ToString() + " " + "kW");
            CSafeSetText(l213_1, t.Fault_System_CB_Status.ToString() + " " + "V");
        }

        private void ObserverUpdate_BMS_System()
        {
            sSamsungBCS t = Repository.Instance.samsung_bcs;

            CSafeSetText(l31_1, t.System_Voltage.ToString() + " " + "V");
            CSafeSetText(l32_1, t.System_Current.ToString() + " " + "A");
            CSafeSetText(l33_1, t.System_SOC.ToString() + " " + "%");
            CSafeSetText(l34_1, t.System_SOH.ToString() + " " + "%");
            
            CSafeSetText(l35_1, BMS_Mode_Text());
            CSafeSetText(l36_1, t.System_Max_Voltage.ToString() + " " + "V");
            CSafeSetText(l37_1, t.System_Min_Voltage.ToString() + " " + "V");
            CSafeSetText(l38_1, t.System_Max_Temp.ToString() + " " + "°C");
            CSafeSetText(l39_1, t.System_Min_Temp.ToString() + " " + "°C");
            
            CSafeSetText(l310_1, t.Discharge_Current_Limit.ToString() + " " + "A");
            CSafeSetText(l311_1, t.Charge_Current_Limit.ToString() + " " + "A");
            CSafeSetText(l312_1, t.Rack1.String1_Cell_Summation_Voltage.ToString() + " " + "V");
            CSafeSetText(l313_1, t.Rack1.String2_Cell_Summation_Voltage.ToString() + " " + "V");

            CSafeSetText(l31_2, t.Watchdog_Response.ToString());
            CSafeSetText(l32_2, t.System_Heartbit.ToString());

        }
        private void ObserverUpdate_BMS_Rack1()
        {
            // BMS : System용 이다
            // 값 써주기
            sSamsungBCS t = Repository.Instance.samsung_bcs;

            CSafeSetText(l41_1, t.Rack1.Rack_Voltage.ToString() + " " + "V");

            CSafeSetText(l44_2, t.Rack1.String1_Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(l44_2, t.Rack1.String1_Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(l44_3, t.Rack1.String2_Rack_Voltage.ToString() + " " + "V");

            CSafeSetText(l42_1, t.Rack1.Rack_Current.ToString() + " " + "A");
            
            CSafeSetText(l46_2, t.Rack1.String1_Rack_Current.ToString() + " " + "A");
            CSafeSetText(l46_3, t.Rack1.String2_Rack_Current.ToString() + " " + "A");
            CSafeSetText(l43_1, t.Rack1.Rack_Current_Average.ToString() + " " + "A");
            CSafeSetText(l45_1, t.Rack1.Rack_SOC.ToString() + " " + "%");
            CSafeSetText(l46_1, t.Rack1.Rack_SOH.ToString() + " " + "%");
        }

        private void ObserverUpdate_BMS_Rack2()
        {
            // BMS : System용 이다
            // 값 써주기
            sSamsungBCS t = Repository.Instance.samsung_bcs;



            CSafeSetText(l51_1, t.Rack1.Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(l52_1, t.Rack1.Rack_Current.ToString() + " " + "A");
            CSafeSetText(l53_1, t.Rack1.Rack_Current_Average.ToString() + " " + "A");
            CSafeSetText(l54_1, t.Rack1.Rack_Mode.ToString());
            CSafeSetText(l55_1, t.Rack1.Rack_SOC.ToString() + " " + "%");
            CSafeSetText(l56_1, t.Rack1.Rack_SOH.ToString() + " " + "%");
            CSafeSetText(l57_1, t.Rack1.Average_Cell_Voltage_Value.ToString() + " " + "mV");
            CSafeSetText(l58_1, t.Rack1.Average_Cell_Temp_Value.ToString() + " " + "­°C");
            CSafeSetText(l59_1, t.Rack1.Rack_Discharge_Current_Limit_of_Rack.ToString() + " " + "­A");
            CSafeSetText(l510_1, t.Rack1.Rack_Charge_Current_Limit_of_Rack .ToString() + " " + "­A");
            CSafeSetText(l511_1, t.Rack1.Rack_Switch_Control_Info .ToString());
            CSafeSetText(l512_1, t.Rack1.Rack_Switch_Sensor_Info.ToString());
            CSafeSetText(l513_1, t.Rack1.Rack_External_Sensor_Info .ToString());
            CSafeSetText(l514_1, t.Rack1.Module_Comm_Fault_Position.ToString());

            CSafeSetText(l54_2, t.Rack1.String1_Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(l55_2, t.Rack1.String1_Cell_Summation_Voltage .ToString() + " " + "V");
            CSafeSetText(l56_2, t.Rack1.String1_Rack_Current .ToString() + " " + "A");
            CSafeSetText(l57_2, t.Rack1.Max1_Cell_Voltage_Value .ToString() + " " + "V");
            CSafeSetText(l58_2, t.Rack1.Max1_Cell_Voltage_Position .ToString());
            CSafeSetText(l59_2, t.Rack1.Min1_Cell_Voltage_Value.ToString() + " " + "V");
            CSafeSetText(l510_2, t.Rack1.Min1_Cell_Voltage_Position.ToString());
            CSafeSetText(l511_2, t.Rack1.Max1_Cell_Temp_Value .ToString() + " " + "°C");
            CSafeSetText(l512_2, t.Rack1.Max1_Cell_Temp_Position.ToString());
            CSafeSetText(l513_2, t.Rack1.Min1_Cell_Temp_Value.ToString() + " " + "°C");
            CSafeSetText(l514_2, t.Rack1.Min1_Cell_Temp_Position.ToString());

            CSafeSetText(l54_3, t.Rack1.String2_Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(l55_3, t.Rack1.String2_Cell_Summation_Voltage.ToString() + " " + "V");
            CSafeSetText(l56_3, t.Rack1.String2_Rack_Current.ToString() + " " + "A");
            CSafeSetText(l58_3, t.Rack1.Max1_Cell_Voltage_Position.ToString());            
            CSafeSetText(l510_3, t.Rack1.Min1_Cell_Voltage_Position.ToString());
            CSafeSetText(l512_3, t.Rack1.Max1_Cell_Temp_Position.ToString());
            CSafeSetText(l514_3, t.Rack1.Min1_Cell_Temp_Position.ToString());



        }
        private string BMS_Mode_Text()
        {
            string lb_System_Status;

                    // 값을 써주자.
            if (Repository.Instance.samsung_bcs.Mode_Charging == 1)
            {
                lb_System_Status = "CHARGING";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Discharging == 1)
            {
                lb_System_Status = "DISCHARGING";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Offline == 1)
            {
                lb_System_Status = "OFFLINE";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Idle == 1)
            {
                lb_System_Status = "IDLE";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Ready == 1)
            {
                lb_System_Status = "READY";
            }
            else
            {
                lb_System_Status = "UNEXPECTED";
            }
            return lb_System_Status;

        }
        private void btn_Move_To_BMS_System_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure);
        }

        private void btn_Move_To_BMS_Rack_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure_BMS_Rack);
        }

        private void btn_Move_To_PCS_Data_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure_PCS);
        }

        private void btn_Move_To_PCS_Fault_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure_PCS_Fault);
        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(tabPane1.SelectedPageIndex);
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            ObserverUpdate();
        }
    }
}
