namespace Opgave4
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
            GuessingGame guessingGame = new GuessingGame();
            string result = "";
            Console.WriteLine("Guess a number from 1 to 20.");
            do
            {
                Console.Write("Your guess: ");
                int guess = int.Parse(Console.ReadLine());
                result = guessingGame.Guess(guess);
                Console.WriteLine(result);
                if (result == "Correct")
                {
                    Console.WriteLine($"You needed {guessingGame.GetGuessCount()} guesses.");
                }
            } while (result != "Correct");
        }
    }
}
