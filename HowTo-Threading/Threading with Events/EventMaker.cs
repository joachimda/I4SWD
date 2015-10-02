using System.Threading;

namespace Threading_with_Events
{
    public class EventMaker
    {
        public delegate void HappeningEventHandler();
        public delegate void StopThreadsEventHandler();

        public event HappeningEventHandler Happening;
        public event StopThreadsEventHandler StopThreads;

        protected virtual void OnStopThreads()
        {
            var handler = StopThreads;
            if (handler != null) handler();
        }

        protected virtual void OnHappening()
        {
            var handler = Happening;
            if (handler != null) handler();
        }

        public void MakeEvents()
        {
            while(true)
            {
                Thread.Sleep(3000);
                OnHappening();
            }
        }

        public void DoneMakingEvents()
        {
            Thread.Sleep(5000);
            OnStopThreads();
        }
    }
}