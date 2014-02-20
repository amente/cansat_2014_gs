﻿using System;
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

        public void addPacket(TelemetryPacket packet)
        {
            rtgTemp.AddDataPoint(packet.temperature);
            rtgAlt.AddDataPoint(packet.altitude);
            rtgBat.AddDataPoint(packet.batVoltage);
            /*rtgAltitude.AddDataPoint(Convert.ToInt32(message[3]));
            rtgBatteryV.AddDataPoint(Convert.ToInt32(message[5]));*/
        }

        private void DataGraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.MdiFormClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void lblAltitude_Click(object sender, EventArgs e)
        {

        }

        private void splTempurature_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
