using System.Collections.Generic;

namespace AnimalSimulation
{
    class Square : ISquare
    {
        List<IAnimal> _animalsOnSquare = new List<IAnimal>(); 

        public int FoodAmount
        {
            get { return FoodAmount; }
            set
            {
                if (0 < value && value <= FoodAmount)
                {
                    FoodAmount = value;
                }
            }
        }

        public int Eat(int amountToEat)
        {
            if (amountToEat >= FoodAmount)
            {
                System.Console.WriteLine("Error: Someone tried to eat more food than available.");
                return FoodAmount;
            }
            if (amountToEat < FoodAmount)
            {
                FoodAmount -= amountToEat;
                return 0;
            }
        }

        public int Enter(IAnimal enteringAnimal)
        {
            _animalsOnSquare.Add(enteringAnimal);
        }

        public int Exit(IAnimal exitingAnimal)
        {
            _animalsOnSquare.Add(exitingAnimal);
        }
    }
}