namespace Assignment6
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
            Console.WriteLine("Welcome to Assignment 6 | Grade Calculator");
            Console.Write("Enter your score (in whole numbers): ");
            int readScore = int.Parse(Console.ReadLine());
            string grade = GetGrade(readScore);
            Console.WriteLine(grade);
        }

        public string GetGrade(int score)
        {
            string grade;
            if(score >= 90 && score <= 100)
            {
                grade = "A";
            } else if (score >= 80 && score < 90)
            {
                grade = "B";
            }
            else if (score >= 70 && score < 80)
            {
                grade = "C";
            }
            else if (score >= 60 && score < 70)
            {
                grade = "D";
            }
            else if (score >= 0 && score < 60)
            {
                grade = "F";
            } else
            {
                return "Invalid Input. Please enter a valid score.";
            }
            return grade;
        }
    }
}
