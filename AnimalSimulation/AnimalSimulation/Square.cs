using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    public class Square : ISquare
    {
        private int _foodAmount = 200;
        private bool _moreFood = true;
        private List<IAnimal> _animalsOnSquare = new List<IAnimal>();

        public int FoodAmount
        {
            get
            {
                return _foodAmount;
            }
            set
            {
                if (_moreFood == true && value < _foodAmount)
                {
                    _foodAmount = value;
                }
            }
        }

        public bool MoreFood
        {
            get
            {
                return _moreFood;
            }
            set
            {
                if (_foodAmount <= 0)
                {
                    if (_moreFood == true)
                    {
                        _moreFood = false;
                    }
                }
            }
        }


        public void Enter(IAnimal enteringAnimal)
        {
            _animalsOnSquare.Add(enteringAnimal);
        }

        public void Exit(IAnimal exitingAnimal)
        {
            _animalsOnSquare.Remove(exitingAnimal);
        }
    }
}
