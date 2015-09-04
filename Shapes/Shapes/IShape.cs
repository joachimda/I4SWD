namespace Shapes
{
    /// <summary>
    /// Interface to shapes.
    /// Contains the following:
    ///     Properties:
    ///         Area
    ///         Volumen
    ///     Methods:
    ///         Render()
    /// </summary>
    public interface IShape
    {
        void Render();
        double Area { get; set; }
        double Volumen { get; set; }
    }
}