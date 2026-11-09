namespace Assignment1;

public class Rectangle
{
    public double Width;
    public double Height;

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * Width + 2 * Height;
    }
}