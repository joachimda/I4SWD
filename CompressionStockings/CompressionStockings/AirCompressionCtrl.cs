using System.Reflection;
using System.Runtime.InteropServices;

namespace CompressionStockings
{
    public class AirCompressionCtrl : ICompressionCtrl
    {
        private readonly IPump _pump;
        private ICompressionEventHandler _compressionEventHandler;

        public AirCompressionCtrl(IPump pump)
        {
            _pump = pump;
            IsPumped = false;
        }

        public void Compress()
        {
            if (IsPumped)
            {
                System.Console.WriteLine("Already pumped, jackass.");
                return;
            }

            _compressionEventHandler.NotifiCompressionStarted();
            _pump.Forward();

            DelayFancy(5);

            _pump.Stop();
            _compressionEventHandler.NotifiCompressionComplete();

            IsPumped = true;
        }

        public void Decompress()
        {
            if (!IsPumped)
            {
                System.Console.WriteLine("It's not pumped, jackass.");
                return;
            }

            _compressionEventHandler.NotifiCompressionStarted();
            _pump.Reverse();

            DelayFancy(2);

            _pump.Stop();
            _compressionEventHandler.NotifiCompressionComplete();

            IsPumped = false;
        }

        public void AddNotificationCenter(ICompressionEventHandler compressionEventHandler)
        {
            _compressionEventHandler = compressionEventHandler;
        }

        public bool IsPumped { get; set; }

        public void DelayFancy(int delay)
        {
            System.Console.WriteLine("Waiting " + delay + " seconds...");

            for (int i = 1; i < delay + 1; i++)
            {
                for (int o = 0; o < 3; o++)
                {
                    System.Console.Write(".");
                    System.Threading.Thread.Sleep(200);
                }

                System.Console.Write(i);
                System.Threading.Thread.Sleep(200);
            }
            System.Console.WriteLine("");
        }
    }
}