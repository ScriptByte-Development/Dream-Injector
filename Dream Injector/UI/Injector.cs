using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dream_Injector.Handler;
using static Dream_Injector.Handler.Structs;

namespace Dream_Injector
{
    public partial class Injector : Form
    {
        private static string DLLP { get; set; }
        static readonly IntPtr INTPTR_ZERO = (IntPtr)0;
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        public Injector()
        {
            InitializeComponent();
        }

        private void Injector_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            Discord.Start();
            Structs.Idling();
            CheckWork();
            commonDropDown.Focus(); //focus on something other then a text box so it doesn't have the typing cursor at start up
            GetProcesses();
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            DLLP = pathTextBox.Text;
        }


        private void chooseBtn_Click(object sender, EventArgs e)
        {
            Structs.ResetAll();
            Structs.Selecting();
            CheckWork();
            Discord.Update();
            ChooseDLL();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void CheckWork()
        {
            if (DLLInjecting)
            {
                FreeBtn.Hide();
                busyBtn.Show();
                workLabel.Text = "Busy";
            }
            else if (Injected)
            {
                FreeBtn.Show();
                busyBtn.Hide();
                workLabel.Text = "Free";
            }
            else if (SelectingDLL)
            {
                FreeBtn.Hide();
                busyBtn.Show();
                workLabel.Text = "Busy";
            }
            else if (SelectedDLL)
            {
                FreeBtn.Show();
                busyBtn.Hide();
                workLabel.Text = "Free";
            }
            else if (GettingProcesses)
            {
                FreeBtn.Hide();
                busyBtn.Show();
                workLabel.Text = "Busy";
            }
            else if (Idle)
            {
                FreeBtn.Show();
                busyBtn.Hide();
                workLabel.Text = "Free";
            }
        }

        private void GetProcesses()
        {
            try
            {
                Processes();
                CheckWork();
                Process[] PC = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
                commonDropDown.Items.Clear();
                foreach (Process p in PC)
                {
                    commonDropDown.Items.Add(p.ProcessName);
                    ResetProcess();
                    FreeBtn.Show();
                    busyBtn.Hide();
                    workLabel.Text = "Free";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dream Injector could not get the currenct process, try restarting application");
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseDLL()
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.InitialDirectory = @"C:/";
                OFD.Title = "Select DLL";
                OFD.DefaultExt = "dll";
                //OFD.Filter = "DLL (*.dll) | *.dll)";
                OFD.Filter = "DLL (*.dll)|*.dll";
                OFD.CheckFileExists = true;
                OFD.CheckPathExists = true;
                OFD.ShowDialog();
                DLLP = OFD.FileName;
                pathTextBox.Text = OFD.FileName;
                Structs.ResetAll();
                Structs.Selected();
                CheckWork();
                Discord.Update();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Dream Injector ran into an error, screenshot the next messagebox and show a developer to fix it");
                MessageBox.Show(ex.Message);
            }
        }

        public static int Inject(string PN, string DLLP)
        {
            //1 = file does not exist
            //2 = Process not active
            //3 = injection failed
            //4 = injection succeeded

            if (!File.Exists(DLLP)) { return 1; }

            uint _procId = 0;
            Process[] _procs = Process.GetProcesses();
            for (int i = 0; i < _procs.Length; i++)
            {
                if (_procs[i].ProcessName == PN)
                {
                    _procId = (uint)_procs[i].Id;
                }
            }

            if (_procId == 0) { return 2; }

            if (!SI(_procId, DLLP))
            {
                return 3;
            }

            return 4;
        }

        public static bool SI(uint P, string DDLP)
        {
            IntPtr hndProc = OpenProcess((0x2 | 0x8 | 0x10 | 0x20 | 0x400), 1, P);

            if (hndProc == INTPTR_ZERO) { return false; }


            IntPtr lpAddress = VirtualAllocEx(hndProc, (IntPtr)null, (IntPtr)DLLP.Length, (0x1000 | 0x2000), 0x40);

            if (lpAddress == INTPTR_ZERO)
            {
                return false;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(DLLP);

            if (WriteProcessMemory(hndProc, lpAddress, bytes, (uint)bytes.Length, 0) == 0)
            {
                return false;
            }

            CloseHandle(hndProc);

            return true;
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            Structs.ResetAll();
            Structs.Injecting();
            CheckWork();
            Discord.Update();
            int Result = Inject(commonDropDown.Text, DLLP);
            if (Result == 1)
            {
                MessageBox.Show("DLL does not exist", Application.ProductName);
            }
            else if (Result == 2)
            {
               MessageBox.Show("Process not found", Application.ProductName);

            }
            else if (Result == 3)
            {
                MessageBox.Show("Injection failed", Application.ProductName);
            }
            else if (Result == 4)
            {
                MessageBox.Show("Injection succeeded", Application.ProductName);
                Structs.ResetAll();
                Structs.Inject();
                CheckWork();
                Discord.Update();
            }
        }

        private void StartVacBypass()
        {
            try
            {
                Process.Start(string.Format("file:///{0}VAC-Bypass-Loader.exe", AppDomain.CurrentDomain.BaseDirectory));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dream Injector ran into an error starting vac bypasser, screenshot the next messagebox and show a developer");
                MessageBox.Show(ex.Message);
            }
        }

        private void commonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Discord.ShutDown();
            Close();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxResetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximize disabled", Application.ProductName);
        }

        //we dont want people clicking the button
        private void workBtn_MouseHover(object sender, EventArgs e)
        {
            FreeBtn.Animated = false;
            chooseBtn.Focus();
        }

        private void workBtn_Click(object sender, EventArgs e)
        {
            chooseBtn.Focus();
        }
    }
}
