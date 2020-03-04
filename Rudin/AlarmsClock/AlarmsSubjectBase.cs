using System.Collections;

namespace Rudin.AlarmClock
{
    public class AlarmSubjectBase
    {
        private ArrayList _observers = new ArrayList();

        public void Attach(TAlarmObserver o)
        {
            _observers.Add(o);
        }

        public void Detach(TAlarmObserver o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (TAlarmObserver o in _observers)
            {
                o.UpdateAfterAlarm();
            }
        }
    }
}
