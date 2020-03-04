using System;

namespace Rudin.AlarmClock
{
    public class Alarm
    {
        private DateTime _time;
        private bool[] _repeatDays;
        public bool Enabled { get; set; }

        public Alarm(DateTime time, bool[] repeat_days=null, bool enabled=true)
        {
            Enabled = enabled;
            Time = time;
            if (repeat_days == null)
            {
                _repeatDays = new bool[] { true, true, true, true, true, true, true };
            }
            else
            {
                _repeatDays = repeat_days;
            }

        }
        
        public bool[] RepeatDays
        {
            set
            {
                if (value.Length == 7)
                {
                    _repeatDays = value;
                }
                else
                {
                    throw new System.ArgumentException("You need an array of size 7");
                }
            }
            get
            {
                return _repeatDays;
            }
        }

        public DateTime Time {
            set
            {
                _time = default(DateTime).Add(value.TimeOfDay);
            }
            get
            {
                return _time;
            }
        }

    }
}
