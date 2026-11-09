namespace Opgave1
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
            Console.Write("Pins knocked down on the first throw: ");
            int firstThrow = int.Parse(Console.ReadLine());
            int secondThrow = 0;
            if (firstThrow != 10)
            {
                Console.Write("Pins knocked down on the second throw: ");
                secondThrow = int.Parse(Console.ReadLine());
            }

            string result = GetFrameResult(firstThrow, secondThrow);
            Console.WriteLine($"Frame result: {result}");
            Console.WriteLine($"Pins knocked down: {firstThrow + secondThrow}");
        }

        public string GetFrameResult(int firstThrow, int secondThrow)
        {
            string output = "";
            if (firstThrow < 0 || secondThrow < 0 || firstThrow + secondThrow > 10)
            {
                output = "Invalid number of pins";
            }
            
            else if (firstThrow == 10)
            {
                output = "Strike";
            }
            else if (firstThrow + secondThrow == 10)
            {
                output = "Spare";
            }
            else
            {
                output = "Open frame";
            }

            return output;
        }
    }
}
