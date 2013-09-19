using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanSatGroundStation
{
    public class MissionTimer
    {
        DateTime missionStartTime;
        bool missionStarted = false;

        public DateTime StartTime { get { return missionStartTime; } }
        public TimeSpan ElapsedTime
        {
            get
            {
                if (missionStarted) return System.DateTime.Now - missionStartTime;
                else return new TimeSpan(0, 0, 0);
            }
        }

        public void StartTimer()
        {
            if (!missionStarted)
            {
                missionStartTime = System.DateTime.Now;
                missionStarted = true;
            }
        }

        public void ResetAndStopTimer()
        {
            missionStartTime = System.DateTime.Now;
            missionStarted = false;
        }
    }
}
