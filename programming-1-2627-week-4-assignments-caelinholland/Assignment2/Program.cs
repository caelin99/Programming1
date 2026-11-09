namespace Assignment2
{
    public class Program
    {
        private int MinRand = 1;
        private int MaxRand = 100;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.Write("Enter a seed: ");
            int seed = int.Parse(Console.ReadLine());
            int[] numbers = new int[20];
            FillArray(numbers, seed);
            DisplayArray(numbers);
            Console.WriteLine($"Smallest number is: {GetSmallestNumber(numbers)}");

        }

        public void FillArray(int[] numbers, int seed)
        {
            Random r = new Random(seed);
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(MinRand, MaxRand+1);
            }
        }

        public void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length-1)
                    Console.Write($"{numbers[i]}\n");
                else
                    Console.Write($"{numbers[i]} ");
            }
        }

        public int GetSmallestNumber(int[] numbers)
        {
            int smallest = MaxRand;
            foreach (int n in numbers)
            {
                if (n < smallest)
                    smallest = n;
            }

            return smallest;
        }
        
    }
}