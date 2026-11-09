namespace Assignment3
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
            Console.Write("Enter integer: ");
            int readNumber = int.Parse(Console.ReadLine());
            PrintMultiplicationTable(readNumber);
        }

        public void PrintMultiplicationTable(int number)
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
                i++;
            }

        }
    }
}
