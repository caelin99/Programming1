namespace Assignment3
{
    public class Program
    {
        private int ArraySize = 3;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.WriteLine($"Enter {ArraySize} integers: ");
            int[] numbers = new int[ArraySize];
            FillArray(numbers);
            Console.WriteLine($"Sum: {CalculateSum(numbers)}");
            Console.WriteLine($"Average: {CalculateAverage(numbers):F2}");
        }

        public void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
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
            int sum = CalculateSum(numbers);

            double average = (double)sum / numbers.Length;
            return average;
        }
    }
}