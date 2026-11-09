    namespace Assignment5
{
    public class Program
    {
        private int ArraySize = 3;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Person[] personArray = new Person[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.Write($"Enter name for person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Entery age for person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Person person = new Person(name, age);
                personArray[i] = person;
            }
            PrintPersonArray(personArray);
        }
        
        public void PrintPersonArray(Person[] persons)
        {
            Console.WriteLine("Displaying all persons:");
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine($"Person {i + 1}:");
                persons[i].DisplayPersonInfo();
            }
        }
    }
}
