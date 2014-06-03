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
       
        PayloadGraphForm payloadGraphForm;       
        DataTableForm payloadTableForm;
        ContainerGraphForm containerGraphForm;
        DataTableForm containerTableForm;
        CommandForm telemetryForm;
        ConfigForm configForm;
        StatusForm statusForm;

        public StationControl()
        {
            InitializeComponent();
            SerialParser.rawPacketAvailable += RawPacketAvailable;
            SerialParser.validPacketAvailable += ValidPacketAvailable;
           // SerialParser.dataRecieveTimeout += dataRecieveTimeout;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            payloadGraphForm = new PayloadGraphForm();
            payloadGraphForm.Text = "Payload Chart";           
            payloadTableForm = new DataTableForm();

            payloadGraphForm.Show();
            payloadTableForm.Show();

            containerGraphForm = new ContainerGraphForm();
            containerGraphForm.Text = "Container Chart";
            containerTableForm = new DataTableForm();
            containerGraphForm.Show();
            containerTableForm.Show();

            telemetryForm = new CommandForm();         
            telemetryForm.Show();

            configForm = new ConfigForm();
            statusForm = new StatusForm();
            statusForm.Show();
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
                statusForm.setPayloadData(packet);                
            }
            else
            {
                containerTableForm.AddData(packet.toArray());
                containerGraphForm.addPacket(packet);                
                statusForm.setContainerData(packet);
            }

            telemetryForm.appendValidData(packet);
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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            configForm.Show();
        }

        private void btnStatus_Click_1(object sender, EventArgs e)
        {
            statusForm.Show();
        }

        /*public void dataRecieveTimeout()
        {
           
                payloadTableForm.AddData(packet.toArray());
                payloadGraphForm.addPacket(packet);
                statusForm.setPayloadData(packet);
           
                containerTableForm.AddData(packet.toArray());
                containerGraphForm.addPacket(packet);
                statusForm.setContainerData(packet);            
        }*/

    }
}
