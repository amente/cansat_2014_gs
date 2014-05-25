using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Diagnostics;
namespace CanSatGroundStation
{
    // Delegate methods to be notified for events
    public delegate void ValidPacketAvailableHandler(TelemetryPacket packet);
    public delegate void RawPacketAvailableHandler(String data);
    public delegate void DataRecieveTimoutHandler();

    class SerialParser
    {
        private static volatile SerialParser serialParser;
        private static object syncRoot = new Object();        
        private static SerialPort serialPort;

        public static event RawPacketAvailableHandler rawPacketAvailable;
        public static event ValidPacketAvailableHandler validPacketAvailable;
        public static event DataRecieveTimoutHandler dataRecieveTimeout;             

        private static StringBuilder bigBuffer;

        private static Stopwatch watchdog;
        //private static System.Threading.Timer MyTimer = new System.Threading.Timer(dataWatchDog, null, 100, 2000);

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
            if (!serialPort.IsOpen)
            {
                return;
            }
            /*lock (syncRoot)
            {
                watchdog.Reset();
                watchdog.Start();
            }*/
            byte[] smallBuffer = new byte[serialPort.BytesToRead];
            int recvBytes = serialPort.Read(smallBuffer, 0, smallBuffer.Length);
            String recivedData = BitConverter.ToString(smallBuffer).Replace("-", string.Empty);

            Console.WriteLine(recivedData);

            bigBuffer.Append(recivedData);


            if (bigBuffer.Length > TelemetryPacket.API_PACKET_SIZE)
            {
                String snapShot = bigBuffer.ToString();
                Console.WriteLine(snapShot);
                Console.WriteLine("Length" + bigBuffer.Length);
                int start = snapShot.IndexOf("7E");
                int end = snapShot.IndexOf("7E", start + 3);
                Console.WriteLine("Start" + start + " End" + end);
                if ((end - start) > 0)
                {
                    String data = snapShot.Substring(start, (end - start));
                    OnRawPacketAvaialbe(data);
                    parse(data);
                    //bigBuffer.Remove(0, end);
                    bigBuffer.Clear();
                    bigBuffer.Append(snapShot.Substring(end));
                }
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

            int numDataPackets = (data.Length - TelemetryPacket.API_FRAME_DATA_OFFSET)/TelemetryPacket.PACKET_DATA_SIZE;

            for (int i = 0; i < numDataPackets; i++)
            {                
                String telemetry = data.Substring(TelemetryPacket.API_FRAME_DATA_OFFSET + i * TelemetryPacket.PACKET_DATA_SIZE, TelemetryPacket.PACKET_DATA_SIZE);

                Console.WriteLine("Telemetry: " + telemetry);
                // First data validation, check team id
                if (!telemetry.Substring(0, 4).Equals(TelemetryPacket.TEAM_ID))
                {
                    //Not a valid team id
                    return;
                }

                OnValidPacketAvaialbe(new TelemetryPacket(telemetry));

            }
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

        public static void dataWatchDog(object state)
        {
            lock (syncRoot)
            {
                if (watchdog.ElapsedMilliseconds > 10000)
                {
                    //No data recieved for more than 10 seconds
                }

            }
        }

    }
}
