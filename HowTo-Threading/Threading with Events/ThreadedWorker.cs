using System;
using System.Threading;

namespace Threading_with_Events
{
    public class ThreadedWorker
    {
        private readonly int _id;
        private readonly Thread _thread;
        private bool _isRunning = true;
        EventMaker myEventMaker = new EventMaker();

        public ThreadedWorker(int id)
        {
            _id = id;
            Thread t = new Thread(myEventMaker.MakeEvents);
            Thread v = new Thread(myEventMaker.DoneMakingEvents);
            myEventMaker.Happening += OnHappening;
            myEventMaker.StopThreads += OnStopThreads;
            t.Start();
            v.Start();
            _thread = new Thread(StartRunning);
            _thread.Start();
        }

        void StartRunning()
        {
            while (true)
            {
                Thread.Sleep(100);
                Console.WriteLine("#" + _id + " Waiting.");
            }
        }

        public void OnHappening()
        {
            if (_isRunning)
            {
                Console.WriteLine("#" + _id + " knows something happened!");
            }
        }

        public void OnStopThreads()
        {
            Console.WriteLine("#" + _id + " was told to stop");
            _thread.Abort();
            _isRunning = false;
        }
    }
}