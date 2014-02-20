using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace CanSatGroundStation
{
    public partial class StationControl : Form
    {
       
        DataGraphForm dataGraphForm;       
        DataTableForm dataTableForm;
        TelemetryForm telemetryForm;

        public StationControl()
        {
            InitializeComponent();
            SerialParser.rawPacketAvailable += RawPacketAvailable;
            SerialParser.validPacketAvailable += ValidPacketAvailable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

            dataGraphForm = new DataGraphForm();
            dataGraphForm.Text = "Telemetry Chart";
           
            dataTableForm = new DataTableForm();
            telemetryForm = new TelemetryForm();

            dataGraphForm.MdiParent = this;            
            dataTableForm.MdiParent = this;
            telemetryForm.MdiParent = this;

            telemetryForm.Show();
           
        }

        private void RawPacketAvailable(String data)
        {
            telemetryForm.appendRawData(data);
            Logger.Instance.logRaw(data);
        }
       
        private void ValidPacketAvailable(TelemetryPacket packet)
        {
            dataTableForm.AddData(packet.toArray());
            Logger.Instance.logValid(packet);
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
