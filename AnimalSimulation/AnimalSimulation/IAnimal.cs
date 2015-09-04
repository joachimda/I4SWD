using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    public interface IAnimal
    {
        string Name { get;  set; }
        int BodyWeight { get;  set; }
        int Energi { get;  set; }
        bool IsAlive { get;  set; }
        ISquare CurrentLocation { get; }
        void Move();
        void Status();
    }
}
