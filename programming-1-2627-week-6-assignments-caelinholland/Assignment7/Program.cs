namespace Assignment7
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
            Console.Write("Enter product name: ");
            var name = Console.ReadLine();
            Console.Write("Enter product price: ");
            var price = double.Parse(Console.ReadLine());
            var product = new Product(price, name);
            product.DisplayProductInfo();
            product.Price = 17.01;
            product.DisplayProductInfo();
        }
    }
}
