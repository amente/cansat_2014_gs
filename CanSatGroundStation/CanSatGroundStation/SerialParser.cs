using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace CanSatGroundStation
{
    // Delegate methods to be notified for events
    public delegate void ValidPacketAvailableHandler(TelemetryPacket packet);
    public delegate void RawPacketAvailableHandler(byte[] buffer);

    class SerialParser
    {
        private static volatile SerialParser serialParser;
        private static object syncRoot = new Object();        
        private static SerialPort serialPort;

        public static event RawPacketAvailableHandler rawPacketAvailable;
        public static event ValidPacketAvailableHandler validPacketAvailable;

        private static Queue<Byte> buffer;

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
                        buffer = new Queue<Byte>();
                        serialPort = new SerialPort();
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    }
                }
                return serialParser;
            }
        }


        private static void OnRawPacketAvaialbe(byte[] b)
        {
            if (rawPacketAvailable != null)
            {
                rawPacketAvailable(b);
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
                if(!serialPort.IsOpen){                   
                    return;
                }

                byte[] smallBuffer = new byte[serialPort.BytesToRead];
                int recvBytes = serialPort.Read(smallBuffer, 0, smallBuffer.Length);
                // notify RawPacket is Avaiable to listeners     
                OnRawPacketAvaialbe(smallBuffer);

                foreach(byte b in smallBuffer){
                    buffer.Enqueue(b);
                }

                if (buffer.Count >= TelemetryPacket.PACKET_SIZE)
                {
                    parse();
                }                   
        
        }



        private static void OnValidPacketAvaialbe(TelemetryPacket packet)
        {
            if (validPacketAvailable != null)
            {
                validPacketAvailable(packet);
            }
        }


        private static void parse()
        {
            //TODO
            // This is a critical method
            // It extracts valid packets from the buffer queue and clears it
            // notify listeners when valid packet is parsed
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
