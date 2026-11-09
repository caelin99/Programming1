namespace Assignment7
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
            Console.WriteLine("Enter a year to check if it's a leap year: ");
            int readYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is leap year is {IsLeapYear(readYear)}");
        }

        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else
                {
                    return true;
                }
            } else
            {
                return false;
            }
        }
    }
}
