namespace Assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Assignment 4 - Calculator");
            Console.Write("Enter first number: ");
            double readNum1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double readNum2 = double.Parse(Console.ReadLine());
            Console.Write("Choose an operation (+, -, *, /): ");
            string readOperation = Console.ReadLine();

            double result = CalculateResult(readNum1, readNum2, readOperation);
            Console.Write($"{readNum1} {readOperation} {readNum2} = {result}");
        }

        public double CalculateResult(double num1, double num2, string operation)
        {
            double solution;
            switch(operation.ToLower())
            {
                case "+":
                    solution = Add(num1, num2);
                    return solution;
                case "-":
                    solution = Subtract(num1, num2);
                    return solution;
                case "*":
                    solution = Multiply(num1, num2);
                    return solution;
                case "/":
                    solution = Divide(num1, num2);
                    return solution;
                default:
                    Console.WriteLine("No valid operation selected.");
                    return 0;
            }
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
