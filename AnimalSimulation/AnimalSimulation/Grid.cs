using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulation
{
    public class Grid
    {
        private List<ISquare> _savanna = new List<ISquare>();
        public int _gridSize = 0;

        /// <summary>
        /// Fills Grid with ISquares of same type.
        /// </summary>
        /// <param name="squareType">The kind of ISquare.</param>
        /// <param name="gridLenght">How "long" the grid has to be.</param>
        /// <param name="gridBreath">How "wide" the grid has to be.</param>
        public Grid(ISquare squareType, int gridLenght, int gridBreath)
        {
            var numberOfSquares = ((gridLenght + 2) * (gridBreath + 2));

            for (var i = 0; i < numberOfSquares; i++)
            {
                _savanna.Add(squareType);
            }

            _gridSize = _savanna.Count();
        }
    }
}
