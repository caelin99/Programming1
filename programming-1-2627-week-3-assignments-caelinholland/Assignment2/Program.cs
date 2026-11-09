namespace Assignment2
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
            Console.Write("Enter a positive integer: ");
            int readNum = int.Parse(Console.ReadLine());
            int sum = CalculateFactorial(readNum);
            Console.Write("The sum of natural numbers from 1 to " + readNum + " is: ");
            Console.Write(sum);
        }

        public int CalculateFactorial(int n)
        {
            int factor = 1;
            for(int i = 1; i <= n; i++)
            {
                factor *= i;
            }
            return factor;
        }
    }
}
