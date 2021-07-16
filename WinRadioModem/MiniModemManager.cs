using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinRadioModem
{
    public  class MiniModemManager
    {


        StreamWriter StreamWriter { get; set; }

        Process CygwinProc { get; set; }

        Thread ProcessThread { get; set; }

        public bool IsReceiver { get; set; }

        public void Output(object sender, DataReceivedEventArgs Args)
        {
            if (IsReceiver && Args.Data != null)
            {
                if (!Args.Data.Contains("### CARRIER"))
                {
                    GlobalVars.MainForm.AppendTextBox(Args.Data + "\n");
                }
            }
            Console.WriteLine(Args.Data);
        }

        public  void SendTextMessage(string Message)
        {
            if (GlobalVars.ChosenTransmitType != "bell")
            {
                StreamWriter.WriteLine("echo " + Message + " |  minimodem  --tx " + GlobalVars.ChosenTransmitType);
            }
            else
            {
                StreamWriter.WriteLine("echo " + Message + " |  minimodem  --tx " + GlobalVars.BellSpeed);
            }
           
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GenerateConsoleCtrlEvent(int sigevent, int dwProcessGroupId);
        public void Init()
        {


            CygwinProc.Start();

            if (!IsReceiver)
            {
                GlobalVars.SenderIds.Add(CygwinProc.Id);
            }

            Console.WriteLine("PID is " + CygwinProc.Id);
            StreamWriter = CygwinProc.StandardInput;

            if (IsReceiver)
            {
               
                Console.WriteLine("Starting reciever");

                if (GlobalVars.ChosenTransmitType != "bell")
                {
                    StreamWriter.WriteLine("minimodem  --rx " + GlobalVars.ChosenTransmitType);
                }
                else
                {
                    StreamWriter.WriteLine("minimodem  --rx " + GlobalVars.BellSpeed);
                }
              

            }
            CygwinProc.BeginOutputReadLine();
           // CygwinProc.WaitForExit();
        }

       
        public void Refresh()
        {
            //CygwinProc.Close();

            foreach (var Proc in Process.GetProcessesByName("minimodem").Where(proc =>
            !GlobalVars.SenderIds.Contains(proc.Id)))
            {
                try
                {
                    Proc.Kill();
                }
                catch (System.ComponentModel.Win32Exception e)
                {

                }
                catch (System.InvalidOperationException)
                {

                }
               
            }
           
            CygwinProc.Kill();

            CygwinProc = new Process();
            
            ProcessStartInfo Startinfo = new ProcessStartInfo(@"C:\cygwin64\bin\bash.exe");
            Startinfo.Arguments = "--login -i";
            Startinfo.RedirectStandardOutput = true;
            Startinfo.RedirectStandardInput = true;
            Startinfo.UseShellExecute = false;
            Startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            Startinfo.CreateNoWindow = true;
            CygwinProc.StartInfo = Startinfo;
            CygwinProc.OutputDataReceived += Output;
            StreamWriter.WriteLine("cd /d \" % ~dp0bin\" && .\bash --login -i");
            Init();
        }

        public void BeginThread()
        {
            Console.WriteLine("Spawning thread");
            ProcessThread = new Thread(Init);
            ProcessThread.SetApartmentState(ApartmentState.STA);
            ProcessThread.Start();
        }

        public MiniModemManager(bool Recieve)
        {
            this.IsReceiver = Recieve;
            CygwinProc = new Process();
            ProcessStartInfo Startinfo = new ProcessStartInfo(@"C:\cygwin64\Cygwin.bat");
            Startinfo.RedirectStandardOutput = true;
            Startinfo.RedirectStandardInput = true;
            Startinfo.UseShellExecute = false;
            Startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            Startinfo.CreateNoWindow = true;
            CygwinProc.StartInfo = Startinfo;
            CygwinProc.OutputDataReceived += Output; 

           
        }

        



    }
}
