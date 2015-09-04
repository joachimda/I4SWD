namespace Shapes
{
    abstract class Shape1D : IShape
    {
        /// <summary>
        /// Should print relevant data about the shape.
        /// </summary>
        public abstract void Render();

        /// <summary>
        /// Surface-area of shape in 1D is always 0.
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// Volumen of shape in 1D is always 0.
        /// </summary>
        public double Volumen { get; set; }
    }
}