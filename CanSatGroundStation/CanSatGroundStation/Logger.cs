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
        public static string VALID_LOG_FILE_PATH = "valid_log.txt";
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
                }
                return logger;
            }
        }
        

        public void logRaw(byte[] buffer)
        {
            // This method is called when the serial port recieves data 
            try
            {
                FileStream s = new FileStream(RAW_LOG_FILE_PATH,FileMode.Append);
                using (BinaryWriter file = new BinaryWriter(s,Encoding.ASCII))
                {
                    file.Write(buffer);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Problem writing log file for raw data: \n" + e.Message);
            }
        }

        public void logValid(TelemetryPacket packet)
        {
            // This method is called when a valid telemetry packet is parsed
        }

        public void writeToLog(object[] message)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(VALID_LOG_FILE_PATH, true))
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
                using (StreamReader file = new StreamReader(VALID_LOG_FILE_PATH))
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
            Process.Start(VALID_LOG_FILE_PATH);
        }

        public void OpenRawLog()
        {
            Process.Start(RAW_LOG_FILE_PATH);
        }

        public void ClearLog()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(VALID_LOG_FILE_PATH))
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

