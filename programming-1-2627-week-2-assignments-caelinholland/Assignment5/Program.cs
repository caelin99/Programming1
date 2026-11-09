namespace Assignment5
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
            Console.WriteLine("Welcome to Assignment 5 | Maximum of Three Numbers");
            Console.Write("Enter first number: ");
            int readNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int readNumber2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int readNumber3 = int.Parse(Console.ReadLine());

            int maxNumber = FindMax(readNumber1, readNumber2, readNumber3);
            Console.WriteLine($"The highest number is {maxNumber}");
        }

        public int FindMax(int number1, int number2, int number3)
        {
            int maxNumber = number1;
            if(number2 > maxNumber)
            {
                maxNumber = number2;

            }
            if(number3 > maxNumber)
            {
                maxNumber = number3;
            }
            return maxNumber;
        }
    }
}
