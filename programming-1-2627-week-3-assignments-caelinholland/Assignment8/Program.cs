namespace Assignment8
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
            Console.Write("Enter the number of elements: ");
            int count = int.Parse(Console.ReadLine());
            int sum = CalculateSum(count);
            Console.WriteLine($"The sum is: {sum}");
            double average = CalculateAverage(sum, count);
            Console.WriteLine($"The average is: {average}");
        }

        public int CalculateSum(int count)
        {
            int sum = 0;
            for(int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                int readNum = int.Parse(Console.ReadLine());
                sum += readNum;
            }
            return sum;
        }

        public double CalculateAverage(int sum, int count)
        {
            double average = (double)sum / count;
            return average;
        }
    }
}
