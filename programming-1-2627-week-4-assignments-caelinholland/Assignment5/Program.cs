namespace Assignment5
{
    public class Program
    {
        private int ArraySize = 20;
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            int[] numbers = new int[ArraySize];
            ReadNumbers(numbers);
            Console.Write("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());
            int occurences = CountSearchValue(numbers, searchValue);
            Console.WriteLine($"Number of occurences of search value ({searchValue}) is: {occurences}");
        }

        public int CountSearchValue(int[] numbers, int searchValue)
        {
            int occurences = numbers.Count(searchValue);
            return occurences;
        }

        public void ReadNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number (0 = stop): ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] == 0)
                {
                    break;
                }
            }
        }
    }
}