namespace Assignment7;

public class Product
{
    private double _price;
    public string Name { get; set; }
    public Product(double price, string name)
    {
        _price = price;
        Name = name;
    }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price cannot be negative");
            }
            else
            {
                _price = value;
            }
        }
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine("Product Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
    }
}