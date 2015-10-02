using System;
using System.Threading;

namespace HowTo_Threading
{
    class Program
    {
        public class ThreadedWorker
        {
            private readonly int _id;
            private readonly Thread _t;

            public ThreadedWorker(int ID)
            {
                _id = ID;
                _t = new Thread(DoWork);
                _t.Start();
            }

            void DoWork()
            {
                Console.WriteLine("Thread: " + _id + " has started.");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread: " + _id + " is running.");
                }

                Console.WriteLine("Thread: " + _id + " is finished.");
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadedWorker tw = new ThreadedWorker(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main is running.");
            }
        }
    }
}
