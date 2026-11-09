namespace Assignment3
{
    public class Program
    {
        public int IntegerAmount = 3;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        // This is public for the tests, don't change this.
        public void Start()
        {
            Console.WriteLine("Enter 3 integers:");
            int[] numbers = new int[IntegerAmount];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {CalculateSum(numbers)}");
            Console.WriteLine($"Average: {CalculateAverage(numbers):F2}");
        }

        public int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }

            return sum;
        }

        public double CalculateAverage(int[] numbers)
        {
            
            return (double)CalculateSum(numbers) / numbers.Length;
        }
    }
}
