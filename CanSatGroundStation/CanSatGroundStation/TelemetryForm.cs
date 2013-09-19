using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace CanSatGroundStation
{
    public partial class TelemetryForm : Form
    {
        Manager manager;

        public TelemetryForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void TelemetryForm_Load(object sender, EventArgs e)
        {
            //using (var searcher = new ManagementObjectSearcher
            //    ("SELECT * FROM WIN32_SerialPort"))
            //{
            //    string[] portnames = SerialPort.GetPortNames();
            //    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
            //    var tList = (from n in portnames
            //                join p in ports on n equals p["DeviceID"].ToString()
            //                select n + " - " + p["Caption"]).ToList();

            //    foreach (string s in tList)
            //    {
            //        cmbComPorts.Items.Add(s);
            //    }
            //}
        }

        public void messageRecieved(object[] message)
        {
            lstTelemetry.Items.Insert(0, StationControl.messageToString(message));
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to clear the log?", "Delete Log", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                manager.ClearLog();
        }

        private void TelemetryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.MdiFormClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void btnReadLog_Click(object sender, EventArgs e)
        {
            manager.OpenLog();
        }

    }
}
