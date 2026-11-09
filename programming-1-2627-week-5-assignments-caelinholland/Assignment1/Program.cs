namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Enter width: ");
            rectangle.Width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            rectangle.Height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
        }
    }
}
