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
            Console.Write("Original value: ");
            int number = int.Parse(Console.ReadLine());
            ModifyByValue(number);
            Console.WriteLine($"Value after ModifyByValue: {number}");
            ModifyByReference(ref number);
            Console.WriteLine($"Value after ModifyByReference: {number}");
        }

        public void ModifyByValue(int value)
        {
            value += 20;
        }

        public void ModifyByReference(ref int value)
        {
            value += 20;
        }
    }
}
