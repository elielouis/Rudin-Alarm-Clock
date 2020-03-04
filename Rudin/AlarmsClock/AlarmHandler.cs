using System;
using System.Timers;

namespace Rudin.AlarmClock
{
    public class AlarmHandler : AlarmSubjectBase
    {
        private Alarm _alarm;
        private Timer _timer;

        public AlarmHandler(Alarm alarm, int time_interval = 1000)
        {
            _timer = new System.Timers.Timer(time_interval);
            _timer.AutoReset = true;
            _timer.Enabled = false;
            _timer.Elapsed += OnTimedEvent;
            _alarm = alarm;
        }

        public void StartClock()
        {
            _timer.Enabled = true;
        }

        public void StopClock()
        {
            _timer.Enabled = false;
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            /*    foreach (Alarm alarm in _alarms)
             {
                 if (DateTime.Compare(alarm.Time, DateTime.Now) <= 0 && alarm.Enabled)
                 {
                     Notify();
                 }
             }*/
            DateTime current = default(DateTime).Add(DateTime.Now.TimeOfDay);
            if (Math.Abs((_alarm.Time - current).TotalSeconds) <= 120)
            {
                StopClock();
                Notify();
            }
        }

        ~AlarmHandler()
        {
            _timer.Stop();
            _timer.Dispose();
        }
    }
}
