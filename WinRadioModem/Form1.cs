using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinRadioModem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ModeSelectionBox.DataSource = GlobalVars.TransmitTypes;
        }

        private void TransmitButton_Click(object sender, EventArgs e)
        {
            GlobalVars.SenderModem.SendTextMessage(UserTextBox.Text);
        }



        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            MainDisplayTextBox.Text += value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVars.RecModem.Refresh();
        }

        private void DataRateBox_ValueChanged(object sender, EventArgs e)
        {
            GlobalVars.BellSpeed = (int)DataRateBox.Value;
            GlobalVars.SenderModem.Refresh();
            GlobalVars.RecModem.Refresh();
        }

        private void ModeSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVars.ChosenTransmitType = ModeSelectionBox.Text;
            GlobalVars.SenderModem.Refresh();
            GlobalVars.RecModem.Refresh();
        }

        private void TestFunction(object sender, EventArgs e)
        {
            MessageBox.Show("hi there");
        }
    }
}
