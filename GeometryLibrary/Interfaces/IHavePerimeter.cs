namespace GeometryLibrary.Interfaces
{
    // Существуют плоские фигуры без периметра (фракталы)
    public interface IHavePerimeter 
    {
        double Perimeter { get; }
    }
}
