namespace Assignment6
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
            int readNumber = 0;
            do
            {
                Console.Write("Enter a number to check if it is a prime number: ");
                readNumber = int.Parse(Console.ReadLine());
                if (IsPrime(readNumber)) Console.WriteLine($"{readNumber} is a prime number.");
                else Console.WriteLine($"{readNumber} is not a prime number.");

            } while (readNumber != 0);
        }

        public bool IsPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
