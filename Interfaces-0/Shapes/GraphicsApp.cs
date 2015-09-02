using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class GraphicsApp
    {
        private List<IShape> _shapes;
        public void AddShape(IShape s)
        {
            _shapes.Add(s);
        }
    }
}
