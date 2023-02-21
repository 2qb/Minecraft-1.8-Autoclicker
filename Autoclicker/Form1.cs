using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Collections.Generic;

namespace Autoclicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        private LowLevelKeyboardProc hookProc;
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        private Keys currentKey;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;

        private IntPtr hookId = IntPtr.Zero;

        Process Process = null;
        private void SetHook()
        {
            Process = GetMinecraft();

            if (Process == null)
            {
                MessageBox.Show("Minecraft not found!");
                Close();
                return;
            }

            hookProc = HookCallback;
            using (ProcessModule module = Process.MainModule)
            {
                hookId = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, GetModuleHandle(module.ModuleName), 0);
            }
        }
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);

                    if (vkCode == (int)currentKey)
                    {
                        EnabledCheckBox.Checked = !EnabledCheckBox.Checked;
                    }
                }
            }
            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private Process GetMinecraft()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (p.ProcessName.ToLower().Contains("javaw") && (p.MainWindowTitle.ToLower().Contains("minecraft") || p.MainWindowTitle.ToLower().Contains("lunar") || p.MainWindowTitle.ToLower().Contains("badlion")))
                {
                    return p;
                }
            }
            return null;
        }

        private bool IsMinecraftFocused()
        {
            IntPtr foregroundHwnd = GetForegroundWindow();
            IntPtr minecraftHwnd = GetMinecraft().MainWindowHandle;
            if (foregroundHwnd == minecraftHwnd)
            {
                return true;
            }
            return false;
        }

        private void Unhook()
        {
            UnhookWindowsHookEx(hookId);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Unhook();
        }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            SetHook();
        }

        private void EnabledText_Click(object sender, EventArgs e)
        {
            EnabledCheckBox.Checked = !EnabledCheckBox.Checked;
        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            double sliderValue = slider1.Value;
            CPSText.Text = "CPS: " + sliderValue.ToString("F1");
        }

        private void KeybindName_Click(object sender, EventArgs e)
        {
            KeybindName.Text = "?";
            currentKey = Keys.None;
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (KeybindName.Text == "?")
            {
                if (e.KeyCode == Keys.Escape)
                {
                    KeybindName.Text = "(none)";
                    currentKey = Keys.None;
                    return;
                }
                currentKey = e.KeyCode;
                KeybindName.Text = currentKey.ToString();
            }
        }

        private void EnabledButtonChange(object sender, EventArgs e)
        {
            if (EnabledCheckBox.Checked)
            {
                timer1.Interval = 100;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private bool IsLeftMouseButtonDown()
        {
            const int VK_LBUTTON = 0x01;
            return (GetAsyncKeyState(VK_LBUTTON) & 0x8000) != 0;
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int minCpsWait = (int)(1000.0 / slider1.Value * 0.6);
            int maxCpsWait = (int)(1000.0 / slider1.Value * 1.5);

            timer1.Interval = rnd.Next(minCpsWait, maxCpsWait);

            if (IsMinecraftFocused())
            {
                if (IsLeftMouseButtonDown())
                {
                    mouse_event(LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(5);
                    mouse_event(LEFTDOWN, 0, 0, 0, 0);
                }
            }

        }
    }
}
