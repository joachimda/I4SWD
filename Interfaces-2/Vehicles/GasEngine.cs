using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class GasEngine : IEngine
    {
        public GasEngine(uint maxThr)
        {
            MaxThrottle = maxThr;
            CurThrottle = 0;
        }

        public uint MaxThrottle { get; set; }
        public uint CurThrottle { get; set; }

        public void print()
        {
            System.Console.WriteLine("Gas.");
            System.Console.WriteLine("Max: {0}\nCur: {1}\n", MaxThrottle, CurThrottle);
        }
    }
}
