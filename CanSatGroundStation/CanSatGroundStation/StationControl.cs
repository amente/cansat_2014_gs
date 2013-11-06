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
    public partial class StationControl : Form
    {
        MissionTimer timer = new MissionTimer();
        Manager manager;

        DataGraphForm dataGraphForm;
        DataTableForm dataTableForm;
        TelemetryForm telemetryForm;

        public StationControl()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.StartTimer();
            manager = new Manager(messageRecieved);

            dataGraphForm = new DataGraphForm();
            dataTableForm = new DataTableForm(manager);
            telemetryForm = new TelemetryForm(manager);

            dataGraphForm.MdiParent = this;
            dataTableForm.MdiParent = this;
            telemetryForm.MdiParent = this;
            
            SerialParser sim = new SerialParser(manager);
            sim.Show();
        }

        private void messageRecieved(object[] message)
        {
            dataGraphForm.messageRecieved(message);
            dataTableForm.messageRecieved(message);
            telemetryForm.messageRecieved(message);

            //rtgTempurature.AddDataPoint(Convert.ToInt32(message[9]));
            //rtgAltitude.AddDataPoint(Convert.ToInt32(message[8]));
            //rtgBatteryV.AddDataPoint(Convert.ToInt32(message[10]));

            //lstTelemetry.Items.Insert(0, MessageToString(message));
        }

        public static string messageToString(object[] message)
        {
            string s = "" + message[0];
            for (int i = 1; i < message.Length; i++)
                s += ", " + message[i];
            return s;
        }
        
        private void mnuTelemetry_Click(object sender, EventArgs e)
        {
            telemetryForm.Show();
        }
        private void mnuDataGraphs_Click(object sender, EventArgs e)
        {
            dataGraphForm.Show();
        }
        private void mnuDataTable_Click(object sender, EventArgs e)
        {
            dataTableForm.Show();
        }

        private void btnTelemetry_Click(object sender, EventArgs e)
        {
            telemetryForm.Show();
            telemetryForm.BringToFront();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            dataGraphForm.Show();
            dataGraphForm.BringToFront();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            dataTableForm.Show();
            dataTableForm.BringToFront();
        }
    
    
    }
}
