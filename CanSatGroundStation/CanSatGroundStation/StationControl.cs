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
       
        DataGraphForm payloadGraphForm;       
        DataTableForm payloadTableForm;
        DataGraphForm containerGraphForm;
        DataTableForm containerTableForm;
        TelemetryForm telemetryForm;

        public StationControl()
        {
            InitializeComponent();
            SerialParser.rawPacketAvailable += RawPacketAvailable;
            SerialParser.validPacketAvailable += ValidPacketAvailable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            payloadGraphForm = new DataGraphForm();
            payloadGraphForm.Text = "Payload Chart";           
            payloadTableForm = new DataTableForm();
           
            payloadGraphForm.MdiParent = this;            
            payloadTableForm.MdiParent = this;

            containerGraphForm = new DataGraphForm();
            containerGraphForm.Text = "Container Chart";
            containerTableForm = new DataTableForm();
            containerGraphForm.MdiParent = this;
            containerTableForm.MdiParent = this;

            telemetryForm = new TelemetryForm();
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
            if (packet.isFromPayload()) {
                payloadTableForm.AddData(packet.toArray());
                payloadGraphForm.addPacket(packet);
            }
            else
            {
                containerTableForm.AddData(packet.toArray());
                containerGraphForm.addPacket(packet);
            }
           
            Logger.Instance.logValid(packet);
        }

        private void mnuTelemetry_Click(object sender, EventArgs e)
        {
            telemetryForm.Show();
        }
        private void mnuDataGraphs_Click(object sender, EventArgs e)
        {
            payloadGraphForm.Show();
            containerGraphForm.Show();
        }
        private void mnuDataTable_Click(object sender, EventArgs e)
        {
            payloadTableForm.Show();
            containerTableForm.Show();
        }

        private void btnTelemetry_Click(object sender, EventArgs e)
        {
            telemetryForm.Show();
            telemetryForm.BringToFront();
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            payloadGraphForm.Show();            
            payloadGraphForm.BringToFront();
            containerGraphForm.Show();
            containerGraphForm.BringToFront(); 
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            payloadTableForm.Show();
            payloadTableForm.BringToFront();
            containerTableForm.Show();
            containerTableForm.BringToFront();
        }
    
    
    }
}
