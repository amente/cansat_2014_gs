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
       
        DataGraphForm payloadDataGraph;
        DataGraphForm containerDataGraph;
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
            

            payloadDataGraph = new DataGraphForm();
            payloadDataGraph.Text = "Telemetry Chart";
            containerDataGraph = new DataGraphForm();
            containerDataGraph.Text = "Container";
            dataTableForm = new DataTableForm();
            telemetryForm = new TelemetryForm();

            payloadDataGraph.MdiParent = this;
            containerDataGraph.MdiParent = this;
            dataTableForm.MdiParent = this;
            telemetryForm.MdiParent = this;

            telemetryForm.Show();
           
        }

        private void RawPacketAvailable(byte[] buffer)
        {
            telemetryForm.appendRawData(buffer);
            Logger.Instance.logRaw(buffer);
        }
       
        private void ValidPacketAvailable(TelemetryPacket packet)
        {
            // This method is called when a valid telemetry packet is parsed
        }

        private void mnuTelemetry_Click(object sender, EventArgs e)
        {
            telemetryForm.Show();
        }
        private void mnuDataGraphs_Click(object sender, EventArgs e)
        {
            payloadDataGraph.Show();
            containerDataGraph.Show();
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
            payloadDataGraph.Show();            
            payloadDataGraph.BringToFront();
            containerDataGraph.Show();
            containerDataGraph.BringToFront();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            dataTableForm.Show();
            dataTableForm.BringToFront();
        }
    
    
    }
}
