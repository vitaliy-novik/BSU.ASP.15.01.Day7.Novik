using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class Alarm
    {
        public event EventHandler<AlarmEventArgs> AlarmClock;

        protected virtual void OnAlarmClock(object sender, AlarmEventArgs e)
        {
            if (AlarmClock != null)
            {
                AlarmClock(sender, e);
            }
        }

        public void SimulateAlarm(int seconds, string message)
        {
            Thread.Sleep(seconds * 1000);
            OnAlarmClock(this, new AlarmEventArgs(message));
        }
    }
}
