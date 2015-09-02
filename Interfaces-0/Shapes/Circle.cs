using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        private int _center;
        public double Radius { get; private set; }
        public int Center { get; private set; }
        public double GetArea()
        {
            return Radius * 2 * 3.14;
        }
    }
}
