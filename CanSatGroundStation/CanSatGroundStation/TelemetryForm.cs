﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Threading;

namespace CanSatGroundStation
{
    public partial class TelemetryForm : Form
    {
       
        static string[] comPorts;
        

        public TelemetryForm()
        {
            InitializeComponent();
            refreshComPorts();
            this.comboBox2.Items.AddRange(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400" });
            this.comboBox2.SelectedIndex = 3;            
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


        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to clear the log?", "Delete Log", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //manager.ClearLog();
                this.label4.Text = "0";
            }
        }
        
   
        public void appendRawData(byte[] buffer)
        {      
               
                String data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                this.BeginInvoke(new EventHandler(delegate
                {
                    this.richTextBox1.AppendText(data);
                    this.label4.Text = (int.Parse(this.label4.Text) + buffer.Length).ToString();
                })); 
                                                  
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
            //manager.OpenLog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!SerialParser.Instance.serialPortIsOPen())
            {
                 String PortName = this.comboBox1.SelectedItem.ToString();
                 int BaudRate = int.Parse(this.comboBox2.SelectedItem.ToString());
                try
                {                   
                    SerialParser.Instance.openSerialPort(PortName, BaudRate);                  
                    updateWidgets(true);
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Unable to open port: " + PortName+"\n"+e1.Message);
                    updateWidgets(false);
                }               

            }            
            else
            {
                SerialParser.Instance.closeSerialPort();               
                updateWidgets(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshComPorts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        //Update the widget according to the state of the serial port
        private void updateWidgets(Boolean state)
        {
            this.button1.Text = state ? "Disconnet" : "Connect";
            this.comboBox1.Enabled = !state;
            this.comboBox2.Enabled = !state;
            this.button2.Enabled = !state;            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length; 
                richTextBox1.ScrollToCaret(); 
            }
        }
    }
}
