using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRadioModem
{
    public static class GlobalVars
    {

        public static MiniModemManager SenderModem { get; set; } = null;

        public static MiniModemManager RecModem { get; set; } = null;

        public static List<string> MessageQueue { get; set; } = new List<string>();

        public static MainForm MainForm;

        public static List<int> SenderIds = new List<int>();


        public static List<string> TransmitTypes = new List<string>() { 
        "rtty",
        "tdd", 
        "same",
        "bell"
        };

        public static string ChosenTransmitType = "rtty";

        public static int BellSpeed = 100;
    }

}
