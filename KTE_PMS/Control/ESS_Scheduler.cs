using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTE_PMS
{
    public partial class ESS_Scheduler : UserControl
    {
        public ESS_Scheduler()
        {
            InitializeComponent();         
        }


        public void Color_Update()
        {
            
            try
            {


                foreach (Control gb in this.Controls)
                {
                    if (gb is Button)
                    {
                        string[] parse = gb.Name.Split('_');

                        int index = Convert.ToInt16(parse[2]);

                        if (Repository.Instance.Scheduler[index] == 1)
                        {
                            gb.BackColor = Color.FromArgb(234, 24, 24);
                        }
                        else if (Repository.Instance.Scheduler[index] == 2)
                        {
                            gb.BackColor = Color.FromArgb(0, 153, 43) ;
                        }
                        else
                        {
                            gb.BackColor = Color.FromArgb(44, 44, 44);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ESS_Scheduler : " + ex.Message);
            }

        }

    }
}
