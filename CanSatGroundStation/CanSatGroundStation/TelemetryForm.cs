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
        static string[] comPorts;
        string buffer;

        public TelemetryForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;

            refreshComPorts();
            this.comboBox2.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400" });
            this.comboBox2.SelectedIndex = 3;

            this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void refreshComPorts()
        {
            comPorts = SerialPort.GetPortNames();
            if (comPorts.Length != 0)
            {
                this.comboBox1.Items.Clear();
                this.comboBox1.Items.AddRange(comPorts);
            }
            else
            {
                this.comboBox1.Items.Add("<N/A>");
            }
            this.comboBox1.SelectedIndex = 0;
        }

        public void messageRecieved(object[] message)
        {
            //lstTelemetry.Items.Insert(0, StationControl.messageToString(message));
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to clear the log?", "Delete Log", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                manager.ClearLog();
                this.label4.Text = "0";
            }
        }

        private string[] packetParser(string rawData)
        {
            // <TEAM ID>,<PACKET COUNT>,<MISSION TIME>,<ALT SENSOR>,<TEMP>,<VOLTAGE>,<LUX>
            
            string[] paddedData = new string[7];
            string[] data = rawData.Split(',');

            for (int i = Math.Min(data.Length, 7); i > 0; --i)
            {
                paddedData[i] = data[i-1];
            }

            return paddedData;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            this.buffer = this.serialPort1.ReadLine();
            this.lstTelemetry.Items.Add(buffer);
            this.lstTelemetry.TabIndex = this.lstTelemetry.Items.Count - 1;
            this.label4.Text = (int.Parse(this.label4.Text) + this.buffer.Length).ToString();

            manager.commitMessage(packetParser(buffer));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text.Equals("Connect"))
            {
                try
                {
                    this.serialPort1.PortName = this.comboBox1.SelectedItem.ToString();
                    this.serialPort1.BaudRate = int.Parse(this.comboBox2.SelectedItem.ToString());
                    this.serialPort1.Open();
                }
                catch
                {
                    MessageBox.Show("Could not open port: " + this.serialPort1.PortName);
                }

                this.button1.Text = "Disconnect";
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.button2.Enabled = false;
            }
            else
            {
                this.serialPort1.Close();
                this.button1.Text = "Connect";
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
                this.button2.Enabled = true;
                refreshComPorts();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshComPorts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lstTelemetry.Items.Clear();
        }
    }
}
