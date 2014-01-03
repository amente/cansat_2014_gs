using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Ports;


namespace CanSatGroundStation
{
    public class Logger
    {
        public static string TELEMETRY_LOG_FILE_PATH = "telemetry_log.txt";
        public static string RAW_LOG_FILE_PATH = "raw_log.txt";

        private static Logger logger;
        private Logger(){}

        public static Logger Instance
        {
            get
            {
                if (logger == null)
                {
                    logger = new Logger();
                    // Add PacketAvailable to  PackerAvailableHandler delegate
                    // Add DataRecieved to SerialPortDataRecieveHandler
                }
                return logger;
            }
        }

        

        private void DataRecieved(Object sender, SerialDataReceivedEventArgs e)
        {
            // This method is called when the serial port recieves data 
        }

        private void PacketAvailable(Object sender, EventArgs e)
        {
            // This method is called when a valid telemetry packet is parsed
        }

        public void writeToLog(object[] message)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(TELEMETRY_LOG_FILE_PATH, true))
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        file.WriteLine(message[i]);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file: \n" + e.Message);
            }
        }

        public List<object[]> readFromLog()
        {
            List<object[]> listObjectsArrays = new List<object[]>();
            try
            {
                using (StreamReader file = new StreamReader(TELEMETRY_LOG_FILE_PATH))
                {
                    int current = 0;
                    object[] objectArray = new object[7];
                    while (!file.EndOfStream)
                    {
                        objectArray[current] = file.ReadLine();
                        current++;

                        if (current >= 7)
                        {
                            current = 0;
                            listObjectsArrays.Add(objectArray);
                            objectArray = new object[7];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file: \n" + e.Message);
            }

            return listObjectsArrays;
        }

        public void OpenTelemetryLog()
        {
            Process.Start(TELEMETRY_LOG_FILE_PATH);
        }

        public void OpenRawLog()
        {
            Process.Start(RAW_LOG_FILE_PATH);
        }

        public void ClearLog()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(TELEMETRY_LOG_FILE_PATH))
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error clearing file: \n" + e.Message);
            }

        }

    }
}

