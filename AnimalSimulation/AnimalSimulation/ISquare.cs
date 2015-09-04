using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    public interface ISquare
    {
        int FoodAmount { get;  set; }
        bool MoreFood { get; set; }
        void Enter(IAnimal enteringAnimal);
        void Exit(IAnimal exitingAnimal);
        int[] Neighbours { get; }
    }
}
