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
        // Used to indicate first instance of a log operation so as include the data and time per session
        private bool appendedTimeToRaw = false; 
        private bool appendedTimeToValid = false; 

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
                if (!appendedTimeToRaw)
                {
                    FileStream s1 = new FileStream(RAW_LOG_FILE_PATH, FileMode.Append);
                    using (StreamWriter sw = new StreamWriter(s1))
                    {
                        sw.WriteLine("\n**********" + System.DateTime.Now.ToString()+"**********");                       
                    }
                    appendedTimeToRaw = true;
                }
                FileStream s = new FileStream(RAW_LOG_FILE_PATH, FileMode.Append);
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
        

        public void OpenValidLog()
        {
            Process.Start(VALID_LOG_FILE_PATH);
        }

        public void OpenRawLog()
        {
            Process.Start(RAW_LOG_FILE_PATH);
        }               

    }
}

