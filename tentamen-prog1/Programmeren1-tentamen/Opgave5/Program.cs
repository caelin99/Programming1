namespace Opgave5
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
            GymMember gymMember = ReadMember();
            DisplayMember(gymMember);
        }

        public GymMember ReadMember()
        {
            Console.Write("Name: ");
            string memberName = Console.ReadLine();
            Console.Write("Age: ");
            int memberAge = int.Parse(Console.ReadLine());
            Console.Write("Visits: ");
            int memberVisits = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return new GymMember(memberName, memberAge, memberVisits);
        }

        public void DisplayMember(GymMember gymMember)
        {
            Console.WriteLine("Gym member:");
            Console.WriteLine($"Name: {gymMember.Name}");
            Console.WriteLine($"Age: {gymMember.Age}");
            Console.WriteLine($"Visits this month: {gymMember.Visits}");
            Console.WriteLine($"Regular visitor: {gymMember.IsRegularVisitor()}");
        }
    }
}
