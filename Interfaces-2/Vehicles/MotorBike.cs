using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class MotorBike
    {
        private IEngine _engine = null;

        public MotorBike(IEngine engine)
        {
            _engine = engine;
            _engine.print();
        }

        public void RunAtHalfSpeed()
        {
            _engine.CurThrottle = (_engine.MaxThrottle / 2);
            _engine.print();
        }
    }
}
