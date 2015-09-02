using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IEngine
    {
        uint MaxThrottle { get; set; }
        uint CurThrottle { get; set; }

        void print();
    }
}
