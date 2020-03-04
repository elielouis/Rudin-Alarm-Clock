using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rudin.AlarmClock;
using System;

namespace Rudin.AlarmClock.Tests
{
    public class AlarmObserverTest : TAlarmObserver
    {
        bool _test_value;

        public AlarmObserverTest()
        {
            _test_value = false;
        }

        public bool getTestValue()
        {
            return _test_value;
        }

        public void UpdateAfterAlarm()
        {
            _test_value = true;
        }
    }

    [TestClass()]
    public class AlarmClockTests
    {
        [TestMethod()]
        public void OnTimedEventTest()
        {
           /* DateTime past = new DateTime(1990);
            Alarm alarm = new Alarm(past);
            AlarmClock alarmClock = new AlarmClock(alarm, 100);
            AlarmObserverTest observerTest = new AlarmObserverTest();
            Assert.IsFalse(observerTest.getTestValue());
            alarmClock.Attach(observerTest);
            alarmClock.OnTimedEvent(null, null);
            System.Threading.Thread.Sleep(200);
            Assert.IsTrue(observerTest.getTestValue());*/
        }

        [TestMethod()]
        public void AlarmClockTestPast()
        {
            /*DateTime past = new DateTime(1990);
            Alarm alarm = new Alarm(past);
            AlarmClock alarmClock = new AlarmClock(alarm, 100);
            AlarmObserverTest observerTest = new AlarmObserverTest();
            Assert.IsFalse(observerTest.getTestValue());
            alarmClock.Attach(observerTest);
            alarmClock.StartClock();
            System.Threading.Thread.Sleep(200);
            Assert.IsTrue(observerTest.getTestValue());*/
        }

        [TestMethod()]
        public void AlarmClockTestFuture()
        {
            DateTime future = DateTime.Now.AddSeconds(0.2);
            Alarm alarm = new Alarm(future);
            AlarmHandler alarmClock = new AlarmHandler(alarm, 100);
            AlarmObserverTest observerTest = new AlarmObserverTest();
            Assert.IsFalse(observerTest.getTestValue());
            alarmClock.Attach(observerTest);
            alarmClock.StartClock();
            System.Threading.Thread.Sleep(300);
            Assert.IsTrue(observerTest.getTestValue());
        }

     
        [TestMethod()]
        public void StatusTest()
        {
            // fill it
        }
    }
}