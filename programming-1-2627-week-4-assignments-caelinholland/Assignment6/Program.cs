namespace Assignment6
{
    public class Program
    {
        private int MinDie = 1;
        private int MaxDie = 6;
        private int DiceThrows = 6000;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            int[] diceCounts = new int[MaxDie];
            for (int i = 0; i < MaxDie; i++)
            {
                diceCounts[i] = 0;
            }
            ThrowDice(diceCounts, DiceThrows);

            for (int i = 0; i < diceCounts.Length; i++)
            {
                Console.WriteLine($"Number of throws of value {i + 1} = {diceCounts[i]}");
            }
        }

        public void ThrowDice(int[] diceCounts, int numberOfThrows)
        {
            Random r = new Random();
            for (int i = 0; i < numberOfThrows; i++)
            {
                int dieValue = r.Next(MinDie, MaxDie + 1);
                diceCounts[dieValue - 1] += 1;
            }
        }
    }
}