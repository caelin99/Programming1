namespace Assignment1
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
            Console.Write("Enter your age: ");
            string ageString = Console.ReadLine();
            int readAge = int.Parse(ageString);

            if (IsAdult(readAge))
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }
        }

        public bool IsAdult(int age)
        {
            if (age >= 18)
            {
                return true;
            }
                        
            return false;
            
        }
    }
}
