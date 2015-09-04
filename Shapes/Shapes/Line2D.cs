using System;
using System.Net.NetworkInformation;

namespace Shapes
{
    public class Line2D : Shape1D
    {
        Point2D _startPoint = new Point2D();
        Point2D _endPoint = new Point2D();
        private double _lenght;

        /// <summary>
        /// Makes a line from point A to B.
        /// </summary>
        /// <param name="pointA">Beginning Point.</param>
        /// <param name="pointB">Ending Point.</param>
        public Line2D(Point2D pointA, Point2D pointB)
        {
            StartPoint.X = pointA.X;
            StartPoint.Y = pointB.Y;
        }

        private double Lenght
        {
            get { return _lenght; }
            set { _lenght = CalculateLenght(); }
        }

        private Point2D StartPoint
        {
            get { return _startPoint; }
            set { _startPoint = value; }
        }

        private Point2D EndPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }

        /// <summary>
        /// Determines the lenght of the line.
        /// </summary>
        /// <returns>Lenght of line.</returns>
        double CalculateLenght()
        {
            var deltaX = _endPoint.X - _startPoint.X;
            var delteY = _endPoint.Y - _startPoint.Y;

            var lenght = Math.Sqrt(deltaX * 2 + delteY * 2);

            return lenght;
        }

        public override void Render()
        {
            System.Console.WriteLine("This line is {0}" +
                                     " long, begins at: ({0},{1})" +
                                     " and ends at ({2},{3})" +
                                     ".", Lenght, StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}