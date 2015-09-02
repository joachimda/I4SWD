using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square
    {
        private int _center;
        public double SideLenght { get; private set; }
        public int Center { get; private set; }
        public double GetArea()
        {
            return SideLenght * 3;
        }
    }
}
