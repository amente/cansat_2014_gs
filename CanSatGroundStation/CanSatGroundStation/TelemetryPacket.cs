using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{
     //<TEAM ID>,<PACKET COUNT>,<MISSION_TIME>,<ALT SENSOR>,<TEMP>,<VOLTAGE>,[<LUX>]
    public class TelemetryPacket
    {
        // 7E 00 1C 90 00 13 A2 00 40 70 E1 23 0A 5B 01 23 05 00 B0 1C 57 9F FC 7A F3 00 00 00 00 C0 FF 8E

        public static int API_PACKET_SIZE = 64 ; // 64 bytes
        public static int API_FRAME_DATA_OFFSET = 30; // 30 Hex String chars = 15 bytes
        public static int PACKET_DATA_SIZE = 32; //32 Hex String chars = 16 bytes 

        public static int PACKET_COUNT_IDX = 4;  // 4 Hex Strings
        public static int MISSION_TIME_IDx = 8;
        public static int ALT_IDX = 12;
        public static int TEMPERATURE_IDX = 16;
        public static int SOURCE_VOLT_IDX = 20;
        public static int LUX_IDX_IR = 24;
        public static int LUX_IDX = 28;


        private Boolean isPayload = true;

        
        public static string TEAM_ID = "2305" ;

        public double temperature;
        public double altitude;
        public int missionTime; // Mission time in seconds.
        public int packetCount;
        public double batVoltage;
        public double lux;

        String[] packetArray;
        String packetString;
                
        public TelemetryPacket(String telemetry)
        {
            
            isPayload = checkIfFromPayload(telemetry); // This should be done first before conversions

            temperature = getShortInt(telemetry.Substring(TEMPERATURE_IDX, 4)) * 0.1; // unvonverted temp is in 0.1 celsious
            altitude = getShortInt(telemetry.Substring(ALT_IDX, 4))*0.01; // Altitude expected is in 100m's
            missionTime = getShortInt(telemetry.Substring(MISSION_TIME_IDx, 4));
            packetCount = getShortInt(telemetry.Substring(PACKET_COUNT_IDX, 4));
            batVoltage = getShortInt(telemetry.Substring(SOURCE_VOLT_IDX,4));
            lux = getShortInt(telemetry.Substring(LUX_IDX,4));            
            
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
       
       
        public String[] toArray()
        {
            return packetArray;
        }

        public String toString()
        {
            return packetString;
        }

        private Int16 getShortInt(String hexText){
            return Int16.Parse(hexText, System.Globalization.NumberStyles.HexNumber);
        }

        private UInt16 getUnsignedShortInt(String hexText)
        {
            return UInt16.Parse(hexText, System.Globalization.NumberStyles.HexNumber);
        }

        /**
         * TODO: Implement this function
         */
        private Boolean checkIfFromPayload(String telemetry){
            return true;
        }

        public Boolean isFromPayload()
        {
            return isPayload;
        }


    }
}