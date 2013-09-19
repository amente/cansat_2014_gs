using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CanSatGroundStation
{
    // <TEAM ID>,<PACKET COUNT>,<MISSION_TIME>,<ALT SENSOR>,<TEMP>,<VOLTAGE>,[<BONUS>]
    public partial class ParserSim : Form
    {
        object[] list = new object[7];

        Manager manager;

        // hard coded values for the incoming data
        int teamId = 1234;
        int missionTime = 0;
        int position = 0;
        int velocity = 100;
        int gravity = 10;
        int temp = 0;
        int batV = 5;
        int packetCount = 0;

        public ParserSim(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }


        private void tmrTime_Tick(object sender, EventArgs e)
        {
            valueGen();

            manager.commitMessage(list);

            lstValues.Items.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                    lstValues.Items.Add(list[i]);
            }


        }

        private void valueGen()
        {
            //TEAM_ID
            list[0] = teamId;

            packetCount += 1;
            list[1] = packetCount;

            //MISSION_TIME
            missionTime += 1;
            list[2] = missionTime;
            

            //GPS_ALT
            list[3] = position;
            if (position < 0)
            {
                velocity = 0;
                gravity = 0;
            }
            velocity -= gravity;
            position += velocity;
            
            //TEMP
            list[4] = Math.Sin(temp += 1) * 10;

            //BAT_V
            list[5] = batV;

            //BONUS
            list[6] = 0;

        }


    }
}