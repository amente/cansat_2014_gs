using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParserSim
{
    // CANSAT,<TEAM_ID>,<MISSION_TIME>,<GPS_TIME>,<GPS_LAT>,<GPS_LONG>,<GPS_ALT>,<GPS_SAT>,<ALT_SENSOR>,<TEMP>,<BAT_V>,<STATE>
    public partial class MainForm : Form
    {
        object[] list = new object[12];

        // hard coded values for the incoming data
        String name = "CANSAT";
        int teamId = 1234;
        int missionTime = 0;
        double gpsLat = 0;
        double gpsLong = 0;
        int position = 0;
        int velocity = 100;
        int gravity = 10;
        double gpsSat = 0;
        int degrees = 0;
        int temp = 0;
        int batV = 0;
        int state = 0;

        
        bool exitFlag = false;

        public MainForm()
        {
            InitializeComponent();


            
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            valueGen();

            lstValues.Items.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                    lstValues.Items.Add(list[i]);
            }


        }

        private void valueGen()
        {
            //CANSAT
            list[0] = name;

            //TEAM_ID
            list[1] = teamId;

            //MISSION_TIME
            missionTime += 1;
            list[2] = missionTime;

            //GPS_TIME
            DateTime now = DateTime.Now;
            list[3] = now.ToString();

            //GPS_LAT
            list[4] = Math.Sqrt(gpsLat++) * .9;

            //GPS_LONG
            list[5] = Math.Sqrt(gpsLat++) * 1.2;

            //GPS_ALT
            list[6] = position;
            if (position < 0)
            {
                velocity = 0;
                gravity = 0;
            }
            velocity -= gravity;
            position += velocity;

            //GPS_SAT
            list[7] = gpsSat += 1;

            //ALT_SENSOR
            list[8] = position * .95;
            degrees += 1;

            //TEMP
            list[9] = -1* ((temp - 10) ^ 2);
            temp += 1;

            //BAT_V
            list[10] = batV += 1; ;

            //STATE
            list[11] = state += 2;

        }


    }
}