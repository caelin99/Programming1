namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.WriteLine("Starting 'Start' method");
            Console.Write("Enter a number: ");
            int readNumber = int.Parse(Console.ReadLine());
            if (IsEven(readNumber))
            {
                Console.WriteLine($"{readNumber} is an even number");
            }
            else
            {
                Console.WriteLine($"{readNumber} is an odd number");
            }
        }

        public bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
