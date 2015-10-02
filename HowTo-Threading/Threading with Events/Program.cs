
using System.Collections.Generic;
using System.Threading;

namespace Threading_with_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfThreads = 100;

            for (int i = 0; i < numberOfThreads; i++)
            {
                ThreadedWorker myWorker = new ThreadedWorker(i);
            }
        }
    }
}
