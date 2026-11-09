namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        // This is public for the tests, don't change this.
        public void Start()
        {
            Console.Write("Enter a day of the week (eg. Tuesday): ");
            string readDay = Console.ReadLine();
            Day day = Enum.Parse<Day>(readDay, ignoreCase: true);
            switch (day)
            {
                case Day.Saturday: case Day.Sunday:
                    Console.WriteLine("It's weekend!! Party time!");
                    break;
                default:
                    Console.WriteLine("Weekend is loading...");
                    break;
            }
        }
    }

}
