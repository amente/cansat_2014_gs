using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CanSatGroundStation
{
    public partial class DataGraphForm : Form
    {
        public DataGraphForm()
        {
            InitializeComponent();
        }

        public void messageRecieved(object[] message)
        {
            rtgTempurature.AddDataPoint(Convert.ToInt32(message[4]));
            rtgAltitude.AddDataPoint(Convert.ToInt32(message[3]));
            rtgBatteryV.AddDataPoint(Convert.ToInt32(message[5]));
        }

        private void DataGraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.MdiFormClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
