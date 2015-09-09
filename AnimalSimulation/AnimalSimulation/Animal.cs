using System.Diagnostics.CodeAnalysis;

namespace AnimalSimulation
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }

        public bool IsAlive
        {
            get
            {
                return IsAlive;
            }
            set
            {
                if (!IsAlive) return; // if animal is already dead = no change.

                IsAlive = value;

                if (value == false)
                {
                    System.Console.WriteLine("Animal: {0} has died and should be removed from arena.", Name);
                }
            }
        }

        public int Energy
        {
            get { return Energy; }
            set
            {
                if (0 <= value && value >= 100) // checking for legal value
                {
                    Energy = value;

                    if (value <= 0) // if energy reaches 0 or less, animal is dead
                    {
                        IsAlive = false;
                    }
                }
                else // error message
                {
                    System.Console.WriteLine("Error: {0}, when trying to set energy level to {1}.", Name, value);
                }
            }
        }

        public int Weight
        {
            get { return Weight; }
            set
            {
                if (0 < value && value <= 10000)
                {
                    Weight = value;
                }
                else if (value > 10000)
                {
                    System.Console.WriteLine("Error: {0} is too fat.", Name);
                }
            }
        }

        public int Move()
        {
            throw new System.NotImplementedException();
        }
    }
}