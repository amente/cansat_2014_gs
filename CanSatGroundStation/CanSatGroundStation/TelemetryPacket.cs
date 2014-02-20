using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{
     //<TEAM ID>,<PACKET COUNT>,<MISSION_TIME>,<ALT SENSOR>,<TEMP>,<VOLTAGE>,[<LUX>]
    public class TelemetryPacket
    {
        public static int API_PACKET_SIZE = 60 ; // 60 Hex String Chars
        public static int API_FRAME_DATA_OFFSET = 30; // 30 Hex String chars = 15 bytes
        public static int PACKET_DATA_SIZE = 28; //28 Hex String chars = 14 bytes 

        public static int PACKET_COUNT_IDX = 4;  // 4 Hex Strings
        public static int MISSION_TIME_IDx = 8;
        public static int ALT_IDX = 12;
        public static int TEMPERATURE_IDX = 16;
        public static int SOURCE_VOLT_IDX = 20;
        public static int LUX_IDX = 24;

        public static string TEAM_ID = "2305" ;

        public double temperature;
        public double altitude;
        public int missionTime; // Mission time in seconds? How do we count this?
        public int packetCount;
        public double batVoltage;
        public double lux;

        String[] packetArray;
        String packetString;
                
        public TelemetryPacket(String telemetry)
        {
            altitude = convertAltitude(Int16.Parse(telemetry.Substring(ALT_IDX, 4), System.Globalization.NumberStyles.HexNumber));
            temperature = convertTemperature(Int16.Parse(telemetry.Substring(TEMPERATURE_IDX, 4), System.Globalization.NumberStyles.HexNumber));
            packetCount = Int16.Parse(telemetry.Substring(PACKET_COUNT_IDX, 4), System.Globalization.NumberStyles.HexNumber);

            packetArray = new String[] { 
                TEAM_ID,
                packetCount.ToString(), 
                missionTime.ToString(),
                altitude.ToString(),
                temperature.ToString(),
                batVoltage.ToString(),
                lux.ToString()
            };

            packetString = String.Join(",",packetArray);
        }

        private double convertAltitude(short unconvertedPressure){
            //convert using parameters from sensor datasheet
            return 0.0;
        }

        private double convertTemperature(short unconvertedTemperature)
        {
            //convert it using parameters from sensor datasheet
            return 0.0;
        }


        private double convertMissionTime(short unconvertedMissionTime)
        {
           // convert mision time to seconds
            return 0.0;
        }



        private double convertbatVoltage(short unconvertedBatVoltage)
        {
            // Convert bat voltage
            return 0.0;
        }

        private double convertLux(short unconvertedLux)
        {
            // Convert Lux
            return 0.0;
        }
        
        public String[] toArray()
        {
            return packetArray;
        }

        public String toString()
        {
            return packetString;
        }
    }
}
