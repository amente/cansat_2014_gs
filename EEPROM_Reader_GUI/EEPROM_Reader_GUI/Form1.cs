using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Connect"))
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a serial port.");
                    return;
                }
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                try
                {
                    serialPort1.Open();
                    button1.Text = "Disconnect";
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Could not open serial port.");
                }
            }
            else
            {
                serialPort1.Close();
                button1.Text = "Connect";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "cansat_eeprom_" + DateTime.Now.ToFileTime().ToString() + ".bin";
            FileStream myfile;

            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("The serial port needs to be opened first.");
                return;
            }

            while (File.Exists(fileName))
            {
                fileName = "cansat_eeprom_" + DateTime.Now.ToFileTime().ToString() + ".bin";
                Thread.Sleep(1000);
            }

            try
            {
                myfile = File.OpenWrite(fileName);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not open " + fileName + " for writing.");
                return;
            }

            serialPort1.WriteLine("");
            try
            {
                for (int i = 0; i < 0x8000; i++)
                {
                    myfile.WriteByte((byte)serialPort1.ReadByte());
                    progressBar1.Value++;
                }
            }
            catch (Exception exc)
            {
                if (exc.InnerException is TimeoutException)
                    MessageBox.Show("Serial read timed out.");
                else
                    MessageBox.Show("An error has occurred while dumping the EEPROM.");
            }
            MessageBox.Show("Success! " + myfile.Length + " bytes dumped.");
            myfile.Close();
            progressBar1.Value = 0;
        }
    }
}
