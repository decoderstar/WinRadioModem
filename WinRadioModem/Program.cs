using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRadioModem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            GlobalVars.SenderModem = new MiniModemManager(false);
            GlobalVars.SenderModem.BeginThread();
            
            GlobalVars.RecModem = new MiniModemManager(true);
            GlobalVars.RecModem.BeginThread();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalVars.MainForm = new MainForm();
            Application.Run(GlobalVars.MainForm);


        }
    }
}
