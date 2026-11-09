namespace Assignment3
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
            Console.WriteLine("This is assignment 3 | Check Number");
            Console.Write("Enter your number: ");
            int readNumber = int.Parse(Console.ReadLine());
            CheckNumber(readNumber);
        }

        public void CheckNumber(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"number is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"number is zero.");
            }
            else
            {
                Console.WriteLine($"number is positive.");
            }
        }


    }
}
