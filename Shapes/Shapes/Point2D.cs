namespace Shapes
{
    class Point2D : Shape1D
    {
        private int _y;
        private int _x;

        /// <summary>
        /// Constructer for Point in 2D.
        /// </summary>
        /// <param name="x">X-coordinate.</param>
        /// <param name="y">Y-coordinate.</param>
        public Point2D(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        internal int X
        {
            get { return _x; }
            set { _x = value; }
        }

        internal int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Outputs coordinates in this form: "(x,y)".
        /// </summary>
        public override void Render()
        {
            System.Console.WriteLine("({0},{1})",X,Y);
        }
    }
}