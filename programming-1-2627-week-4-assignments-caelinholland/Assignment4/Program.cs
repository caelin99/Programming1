namespace Assignment4
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.Write("Enter course name: ");
            string subject = Console.ReadLine();
            Console.Write("Enter amount of students: ");
            int amountStudents = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] grades = new int[amountStudents];
            string[] names = new string[amountStudents];
            ReadNames(names);
            ReadGrades(grades, names);
            int highestIndex = GetHighestGradeIndex(grades);
            Console.WriteLine($"Student {names[highestIndex]} has the highest grade: {grades[highestIndex]}");
        }

        public void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name of student {i+1}: ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine();
        }

        public void ReadGrades(int[] grades, string[] names)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade of {names[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public int GetHighestGradeIndex(int[] grades)
        {
            int index = 0;
            int highest = 0;
            int highestIndex = 0;
            foreach (int g in grades)
            {
                if (g > highest)
                {
                    highest = g;
                    highestIndex = index;
                }
                index++;
            }

            return highestIndex;
        }
    }
}