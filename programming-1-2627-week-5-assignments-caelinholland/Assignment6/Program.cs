namespace Assignment6
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
            Console.Write("How many votes should be processed: ");
            int amountVotes = int.Parse(Console.ReadLine());
            VotingSystem votingSystem = new VotingSystem(amountVotes);
            for (int i = 0; i < amountVotes; i++)
            {
                Console.Write("Enter your vote (Yes/No): ");
                string readVote = Console.ReadLine();
                VoteOption userVote = Enum.Parse<VoteOption>(readVote, ignoreCase: true);
                votingSystem.CastVote(userVote);
            }
            votingSystem.DisplayResults();
        }
    }
}
