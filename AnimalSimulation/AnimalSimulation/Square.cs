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
        private readonly int[] _neighbours = new int[8];
        private int _squarePlacementInGrid = 0;

        public Square(int gridSize, int placementInGrid)
        {
            int sideLenght = (int)Math.Sqrt(gridSize);
            sideLenght -= 2;

            /*Calculating neighbour addresses*/
            // "top"-sides
            _neighbours[0] = ((placementInGrid - sideLenght) - 1);
            _neighbours[1] = (placementInGrid - sideLenght);
            _neighbours[2] = ((placementInGrid - sideLenght) + 1);

            // "mid"-sides
            _neighbours[3] = (placementInGrid - 1);
            _neighbours[4] = (placementInGrid - 1);

            // "bottom"-sides
            _neighbours[5] = ((placementInGrid + sideLenght) - 1);
            _neighbours[6] = (placementInGrid + sideLenght);
            _neighbours[7] = ((placementInGrid + sideLenght) + 1);
            /*Done finding neighbours*/

            _squarePlacementInGrid = placementInGrid;
        }

        public int FoodAmount
        {
            get { return _foodAmount; }
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
            get { return _moreFood; }
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

        public int[] Neighbours { get; private set; }
    }
}

