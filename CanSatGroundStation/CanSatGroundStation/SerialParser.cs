using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{
    class SerialParser
    {
        private static volatile SerialParser serialParser;
        private static object syncRoot = new Object();

        private static List<Byte> buffer;

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
                        buffer = new List<Byte>();
                        // Add PacketAvailable to  PackerAvailableHandler delegate
                        // Add DataRecieved to SerialPortDataRecieveHandler
                    }
                }
                return serialParser;
            }
        }

        





    }
}
