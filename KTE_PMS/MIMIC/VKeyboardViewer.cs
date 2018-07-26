using DevExpress.CodeParser;
using KTE_PMS.CLASS;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class VKeyboardViewer : Form
    {
        private string Status;


        public VKeyboardViewer()
        {
            InitializeComponent();

            Repository.Instance.user_level = 1;

            lb_STATUS.Text = "비밀번호를 입력해 주십시오.";
        }

        public VKeyboardViewer(string s)
        {
            InitializeComponent();

            Status = s;
            Repository.Instance.user_level = 1;

            if (Status == "새로운 비밀번호")
            {
                lb_STATUS.Text = "변경하고자 하는 비밀번호를 입력해 주십시오.";
            }
            else if (Status == "비밀번호 확인")
            {
                lb_STATUS.Text = "확인을 위해 변경하고자 하는 비밀번호를 다시 한번 더 입력해 주십시오.";
            }
        }   

        private void BTN0_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "0";
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "2";
        }
        private void BTN3_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "3";
        }
        private void BTN4_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "4";
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "5";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "6";
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "7";
        }
        private void BTN8_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "8";
        }
        private void BTN9_Click(object sender, EventArgs e)
        {
            tb_Password.Text = tb_Password.Text + "9";
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Password.Text.Length != 0)
                {
                    tb_Password.Text = tb_Password.Text.Substring(0, (tb_Password.Text.Length - 1));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        private void BTN_ENTER_Click(object sender, EventArgs e)
        {
            if (Status == "새로운 비밀번호")
            {
                Repository.Instance.first_password = tb_Password.Text;
                tb_Password.Text = "";
                this.Dispose();
            }
            else if (Status == "비밀번호 확인")
            {
                if (Repository.Instance.first_password == tb_Password.Text)
                {

                    Repository.Instance.password = Repository.Instance.first_password;
                    MessageBox.Show("비밀번호가 성공적으로 변경되었습니다.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다. 다시 한번 시도해주시길 바랍니다.");
                    this.Dispose();
                }
                tb_Password.Text = "";
            }
            else
            {
                if (tb_Password.Text == Repository.Instance.password)
                {
                    // Success
                    //MessageBox.Show("올바른 비밀번호를 입력하였습니다.");
                    tb_Password.Text = "";
                    Repository.Instance.user_level = 5;
                    this.Dispose();
                }
                else
                {
                    // Wrong Password
                    MessageBox.Show("비밀번호가 잘못되었습니다. 다시 확인해주시길 바랍니다.");
                    tb_Password.Text = "";
                    Repository.Instance.user_level = 1;
                }
            }
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            // 자리수 검사.
            // if 4자리 이상이면 경고 Message 띄움
            if (tb_Password.Text.Length > 4)
            {
                tb_Password.Text.Remove(4, 1);

                
            }
        }

        #region BTN_Image할당
        private void BTN7_MouseDown(object sender, MouseEventArgs e)
        {

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._7_1, button.Width, button.Height);

        }

        private void BTN7_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN8_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._8_1, button.Width, button.Height);

        }

        private void BTN8_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN9_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._9_1, button.Width, button.Height);

        }

        private void BTN9_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN4_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._4_1, button.Width, button.Height);
        }

        private void BTN4_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN5_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._5_1, button.Width, button.Height);
        }

        private void BTN5_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN6_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._6_1, button.Width, button.Height);
        }

        private void BTN6_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN1_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._1_1, button.Width, button.Height);
        }

        private void BTN1_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN2_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._2_1, button.Width, button.Height);
        }

        private void BTN2_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN3_MouseDown(object sender, MouseEventArgs e)
        {
                // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
                Button button = (Button)sender;
                button.Image = ImageResize.ResizeImage(Properties.Resources._3_1, button.Width, button.Height);
        }

        private void BTN3_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN_CLEAR_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.back_1, button.Width, button.Height);
        }

        private void BTN_CLEAR_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN0_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._0_1, button.Width, button.Height);
        }

        private void BTN0_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void BTN_ENTER_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.ok_1, button.Width, button.Height);
        }

        private void BTN_ENTER_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
        #endregion
    }

}


/*
       private void BTN0_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D0, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D0, 0), 0x02, 0);
       }

       private void BTN1_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D1, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D1, 0), 0x02, 0);
       }

       private void BTN2_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D2, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D2, 0), 0x02, 0);
       }
       private void BTN3_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D3, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D3, 0), 0x02, 0);
       }
       private void BTN4_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D4, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D4, 0), 0x02, 0);
       }

       private void BTN5_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D5, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D5, 0), 0x02, 0);
       }

       private void BTN6_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D6, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D6, 0), 0x02, 0);
       }

       private void BTN7_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D7, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D7, 0), 0x02, 0);
       }
       private void BTN8_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D8, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D8, 0), 0x02, 0);
       }
       private void BTN9_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.D9, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.D9, 0), 0x02, 0);
       }

       private void BTNDOT_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.Separator, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.Separator, 0), 0x02, 0);

       }

       private void BTN_CLEAR_Click(object sender, EventArgs e)
       {
           tb_Password.Focus();
           keybd_event(0, MapVirtualKey((int)Keys.Back, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.Back, 0), 0x02, 0);

       }

       private void BTN_MINUS_Click(object sender, EventArgs e)
       {
           keybd_event(0, MapVirtualKey((int)Keys.OemMinus, 0), 0x00, 0);
           keybd_event(0, MapVirtualKey((int)Keys.OemMinus, 0), 0x02, 0);
       }
       */
