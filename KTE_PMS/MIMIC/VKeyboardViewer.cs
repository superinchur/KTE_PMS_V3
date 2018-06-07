using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    [Flags]
    public enum KeyFlag { KE_DOWN = 0, KE__EXTENDEDKEY = 1, KE_UP = 2 }
    public partial class VKeyboardViewer : Form
    {
        bool showWithoutActivation = false;
        protected override bool ShowWithoutActivation
        {
            get
            {
                return showWithoutActivation;
            }
        }
        public void Show(bool activate)
        {
            showWithoutActivation = !activate;
        }

        public VKeyboardViewer()
        {
            InitializeComponent();
        }
        static Mutex mu = new Mutex();
        const int IME_CMODE_NATIVE = 0x1;
        [DllImport("imm32.dll")]
        static extern int ImmGetContext(int hWnd);
        [DllImport("imm32.dll")]
        static extern int ImmReleaseContext(int hWnd, int hImc);
        [DllImport("imm32.dll")]
        static extern int ImmGetConversionStatus(int hImc, out int fdwConversion,
                                              out int fdwSentence);
        [DllImport("imm32.dll")]
        static extern bool ImmSetConversionStatus(IntPtr hIMC, int fdwConversion,
                                                int fdwSentence);
        public static bool IsNativeMode(int handle)
        {
            int hImc, dwConversion = 0, dwSentense = 0;
            hImc = ImmGetContext(handle);
            ImmGetConversionStatus(hImc, out dwConversion, out dwSentense);
            return (dwConversion & IME_CMODE_NATIVE) == 1;
        }
        [DllImport("user32.dll")]
        private static extern int GetKeyboardState(byte[] pbKeyState);
        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(int wCode, int wMapType);

        public new static void KeyDown(Keys keycode)
        {
            mu.WaitOne();
            keybd_event((byte)keycode, 0, (int)(KeyFlag.KE_DOWN | KeyFlag.KE__EXTENDEDKEY), 0);
            mu.ReleaseMutex();
        }
        public new static void KeyUp(Keys keycode)
        {
            mu.WaitOne();
            keybd_event((byte)keycode, 0, (int)(KeyFlag.KE_UP | KeyFlag.KE__EXTENDEDKEY), 0);
            mu.ReleaseMutex();
        }

        public static void KeyClick(Keys keycode, bool shift)
        {
            mu.WaitOne();
            if (shift)
            {
                keybd_event((byte)Keys.ShiftKey, 0,
                            (int)(KeyFlag.KE_DOWN | KeyFlag.KE__EXTENDEDKEY), 0);
                keybd_event((byte)keycode, 0,
                            (int)(KeyFlag.KE_DOWN | KeyFlag.KE__EXTENDEDKEY), 0);
                keybd_event((byte)keycode, 0,
                            (int)(KeyFlag.KE_UP | KeyFlag.KE__EXTENDEDKEY), 0);
                keybd_event((byte)Keys.ShiftKey, 0,
                            (int)(KeyFlag.KE_UP | KeyFlag.KE__EXTENDEDKEY), 0);
            }
            else
            {
                keybd_event((byte)keycode, 0,
                             (int)(KeyFlag.KE_DOWN | KeyFlag.KE__EXTENDEDKEY), 0);
                keybd_event((byte)keycode, 0,
                             (int)(KeyFlag.KE_UP | KeyFlag.KE__EXTENDEDKEY), 0);
            }
            mu.ReleaseMutex();
        }
        public static bool IsPress(Keys keycode)
        {
            byte[] vks = new byte[256];
            GetKeyboardState(vks);
            return vks[(int)keycode] == 1;
        }


        private void BTN0_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D0, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D0, 0), 0x02, 0);
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D1, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D1, 0), 0x02, 0);
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D2, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D2, 0), 0x02, 0);
        }
        private void BTN3_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D3, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D3, 0), 0x02, 0);
        }
        private void BTN4_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D4, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D4, 0), 0x02, 0);
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D5, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D5, 0), 0x02, 0);
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D6, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D6, 0), 0x02, 0);
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D7, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D7, 0), 0x02, 0);
        }
        private void BTN8_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D8, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D8, 0), 0x02, 0);
        }
        private void BTN9_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.D9, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.D9, 0), 0x02, 0);
        }

        private void BTNDOT_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.Separator, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.Separator, 0), 0x02, 0);

        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.Back, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.Back, 0), 0x02, 0);

        }

        private void BTN_MINUS_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.OemMinus, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.OemMinus, 0), 0x02, 0);
        }

        private void BTN_ENTER_Click(object sender, EventArgs e)
        {
            keybd_event(0, MapVirtualKey((int)Keys.Enter, 0), 0x00, 0);
            keybd_event(0, MapVirtualKey((int)Keys.Enter, 0), 0x02, 0);
        }


    }
}
