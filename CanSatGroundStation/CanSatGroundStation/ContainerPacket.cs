using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{
    class ContainerPacket 
    {

        // BMP085 Calibration Values

        public static int AC1 = 7355;
        public static int AC2 = -1065;
        public static int AC3 = -14325;
        public static int AC4 = 33398;
        public static int AC5 = 25192;
        public static int AC6 = 22766;
        public static int B1 = 5498;
        public static int B2 = 55;
        public static int MB = -32768;
        public static int MC = -11075;
        public static int MD = 2432;

        public int X1;
        public int X2;
        public int B5;

        


    }
}
