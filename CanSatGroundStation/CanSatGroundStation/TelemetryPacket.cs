using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{

    public class TelemetryPacket
    {
        public static int PACKET_SIZE = 16 ; // The packets size in bytes

        public double temperature;
        public double pressure;
        public int missionTime; // Mission time in seconds? How do we count this?
        public double batVoltage;
        public double lux;
        
                
        public TelemetryPacket(Queue<Byte> buffer, int offset)
        {
            // Read and convert values from the buffer according to the telemetry format
        }

        private double convertPressure(Queue<Byte> buffer, int offset){
            // read pressure data from buffer starting from specified offset and convert using parameters from sensor datasheet
            return 0.0;
        }

        private double convertTemperature(Queue<Byte> buffer, int offset)
        {
            // read temperature data from buffer starting from specified offset and convert it using parameters from sensor datasheet
            return 0.0;
        }


        private double convertMissionTime(Queue<Byte> buffer, int offset)
        {
            // read mission time from buffer starting from specified offset
            return 0.0;
        }



        private double convertbatVoltage(Queue<Byte> buffer, int offset)
        {
            // read battery voltage from buffer starting from specified offset
            return 0.0;
        }

        private double convertLux(Queue<Byte> buffer, int offset)
        {
            // read lux from buffer starting from specified offset
            return 0.0;
        }

        

    }
}
