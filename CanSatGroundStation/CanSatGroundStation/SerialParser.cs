﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace CanSatGroundStation
{
    // Delegate methods to be notified for events
    public delegate void ValidPacketAvailableHandler(TelemetryPacket packet);
    public delegate void RawPacketAvailableHandler(String data);

    class SerialParser
    {
        private static volatile SerialParser serialParser;
        private static object syncRoot = new Object();        
        private static SerialPort serialPort;

        public static event RawPacketAvailableHandler rawPacketAvailable;
        public static event ValidPacketAvailableHandler validPacketAvailable;

        private static StringBuilder bigBuffer;

        private SerialParser(){}

        public static SerialParser Instance
        {
            get
            {
                // use a lock for additional thread safety
                lock (syncRoot)
                {
                    if (serialParser == null)
                    {
                        serialParser = new SerialParser();                        
                        serialPort = new SerialPort();
                        bigBuffer = new StringBuilder();
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    }
                }
                return serialParser;
            }
        }


        private static void OnRawPacketAvaialbe(String data)
        {
            if (rawPacketAvailable != null)
            {
                rawPacketAvailable(data);
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
                if(!serialPort.IsOpen){                   
                    return;
                }

                byte[] smallBuffer = new byte[serialPort.BytesToRead];           
                int recvBytes = serialPort.Read(smallBuffer, 0, smallBuffer.Length);
                  

                bigBuffer.Append(BitConverter.ToString(smallBuffer).Replace("-", string.Empty));
                 
                if(bigBuffer.Length == TelemetryPacket.API_PACKET_SIZE)
                {
                       // notify RawPacket is Avaiable to listeners 
                       String data = bigBuffer.ToString();
                       bigBuffer.Clear();
                       OnRawPacketAvaialbe(data);               
                       parse(data);
                }
                              
        
        }



        private static void OnValidPacketAvaialbe(TelemetryPacket packet)
        {
            if (validPacketAvailable != null)
            {
                validPacketAvailable(packet);
            }
        }

        // notifies listeners when valid packet is parsed from the API frame
        private static void parse(String data)
        {
           String telemetry = data.Substring(TelemetryPacket.API_FRAME_DATA_OFFSET, TelemetryPacket.PACKET_DATA_SIZE);
           
           // First data validation, check team id
           if(!telemetry.Substring(0,4).Equals(TelemetryPacket.TEAM_ID)){
               //Not a valid team id
               return;
           }

           OnValidPacketAvaialbe(new TelemetryPacket(telemetry));
        }



        public void closeSerialPort()
        {
            serialPort.Close();
        }

        public void openSerialPort(String name, int baud)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = name;
                serialPort.BaudRate = baud;
                serialPort.Open();
            }
        }

        public bool serialPortIsOPen()
        {
            return serialPort.IsOpen;
        }

    }
}
