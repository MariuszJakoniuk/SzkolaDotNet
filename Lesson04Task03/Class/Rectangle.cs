namespace Lesson04Task03.Class;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double DiagonalRectangle()
    {
        return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
    }

    public double AreaRectangle()
    {
        return Width * Height;
    }
}