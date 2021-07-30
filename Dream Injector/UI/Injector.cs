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
            Discord.Start();
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
            Discord.Update();
            ChooseDLL();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void GetProcesses()
        {
            Process[] PC = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            commonDropDown.Items.Clear();
            foreach (Process p in PC)
            {
                commonDropDown.Items.Add(p.ProcessName);
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
                Discord.Update();
            } 
            catch (Exception ed)
            {
                MessageBox.Show("Dream Injector ran into an error, screenshot the next messagebox and show a developer to fix it");
                MessageBox.Show(ed.Message);
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
                Discord.Update();

            }
        }

        private void StartVacBypass()
        {
            try
            {
                Process.Start(string.Format("file:///{0}VAC-Bypass-Loader.exe", AppDomain.CurrentDomain.BaseDirectory));
            }
            catch (Exception ed)
            {
                MessageBox.Show("Dream Injector ran into an error starting vac bypasser, screenshot the next messagebox and show a developer");
                MessageBox.Show(ed.Message);
            }
        }

        private void commonDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
