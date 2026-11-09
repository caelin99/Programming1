namespace Assignment5
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
            PerformCalculation();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Simple Calculator Menu:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
        }

        public void PerformCalculation()
        {
            int operation = 0;
            int firstNumber;
            int secondNumber;
            double result;
            do
            {
                DisplayMenu();
                Console.Write("Enter your choice: ");
                operation = int.Parse(Console.ReadLine());
                if(operation == 5)
                {
                    Console.WriteLine("Exiting...\nGoodbye!");
                    break;
                }
                Console.Write("Enter the first number: ");
                firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                secondNumber = int.Parse(Console.ReadLine());

                switch(operation)
                {
                    case 1:
                        result = Add(firstNumber, secondNumber);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 2:
                        result = Subtract(firstNumber, secondNumber);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 3:
                        result = Multiply(firstNumber, secondNumber);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 4:
                        result = Divide(firstNumber, secondNumber);
                        Console.WriteLine($"Result: {result}");
                        break;                        
                    default:
                        Console.WriteLine("No valid operation detected. Pick a valid operation (1, 2, 3, 4, 5).");
                        continue;
                }
            } while (operation != 5);
            
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
