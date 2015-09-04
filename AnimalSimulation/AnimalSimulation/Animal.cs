using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    public class Animal : IAnimal
    {
        private int _bodyWeight;
        private int _energi;
        private bool _isAlive;
        private ISquare _currentLocation;

        public string Name { get; set; }

        public int BodyWeight
        {
            get
            {
                return _bodyWeight;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    _bodyWeight = value;
                }
            }
        }

        public int Energi
        {
            get
            {
                return _energi;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _energi = value;
                }
            }
        }

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                if (_isAlive == true)
                {
                    _isAlive = value;
                }
            }
        }

        public ISquare CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                /* Her skal også tilføjes til tjek, som skal sikre at den 
                 * nye location er ved siden af den gamle, således at 
                 * dyrene ikke bare springer rundt overalt på grid.
                 */
                if (_currentLocation != null && value != _currentLocation)
                {
                    _currentLocation = value;
                }
            }
        }

        public void Move()
        {
            var rnd = new Random();
            int nextMove = rnd.Next(1, 9);

            switch (nextMove)
            {
                case 1:

                    break;
            }
        }

        public void Status()
        {
            /* Printfunktion som skal bruges til kontroltjek og debugging
             */
        }
    }
}