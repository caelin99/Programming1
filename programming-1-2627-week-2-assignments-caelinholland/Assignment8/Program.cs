namespace Assignment8
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
            Console.WriteLine("Welcom to Assignment 8 | Day of the Week Calculator");
            Console.Write("Enter a number (1-7) to get the day if the week: ");
            int readDayNumber = int.Parse(Console.ReadLine());
            Console.Write("The day is: ");
            string dayOfWeek = GetDayOfWeek(readDayNumber);
            Console.Write(dayOfWeek);
        }

        public string GetDayOfWeek(int dayNumber)
        {
            switch(dayNumber)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Invalid day number";
            }
        }
    }
}
