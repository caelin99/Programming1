namespace Assignment1
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

        }

        public void FillArray(int[] numbers, int seed)
        {
            Random r = new Random(seed);
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(MinRand, MaxRand + 1);
            }
        }

        public void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i+1} is: {numbers[i]}");

            }
            
            // Zelfde met een foreach loopie
            // int index = 0;
            // foreach (int i in numbers)
            // {
            //     Console.WriteLine($"Element {index+1} is: {i}");
            //     index++;
            // }
        }
    }
}