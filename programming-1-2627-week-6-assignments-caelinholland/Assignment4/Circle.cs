namespace Assignment4;

public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public double Area
    {
        get { return Math.PI * Math.Pow(Radius, 2); }
    }

    public void DisplayCircleInfo()
    {
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {Area}");
    }
}