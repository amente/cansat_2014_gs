using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{
    public class TelemetryPacket
    {
        double temperature;
        double pressure;
        int missionTime; // Mission time in seconds? How do we count this?
        double batVoltage;
        double lux;
        
                
        public TelemetryPacket(List<Byte> buffer, int offset)
        {
            // Read and convert values from the buffer according to the telemetry format
        }

        private double convertPressure(List<Byte> buffer, int offset){
            // read pressure data from buffer starting from specified offset and convert using parameters from sensor datasheet
            return 0.0;
        }

        private double convertTemperature(List<Byte> buffer, int offset)
        {
            // read temperature data from buffer starting from specified offset and convert it using parameters from sensor datasheet
            return 0.0;
        }


        private double convertMissionTime(List<Byte> buffer, int offset)
        {
            // read mission time from buffer starting from specified offset
            return 0.0;
        }



        private double convertbatVoltage(List<Byte> buffer, int offset)
        {
            // read battery voltage from buffer starting from specified offset
            return 0.0;
        }

        private double convertLux(List<Byte> buffer, int offset)
        {
            // read lux from buffer starting from specified offset
            return 0.0;
        }








    }
}
