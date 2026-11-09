namespace Assignment6;

public class VotingSystem
{
    private VoteOption[] _votes;
    private int _voteCount = 0;

    public VotingSystem(int size)
    {
        _votes = new VoteOption[size];
    }

    public void CastVote(VoteOption vote)
    {
        if (_voteCount < _votes.Length)
        {
            _votes[_voteCount] = vote;
            _voteCount++;
            Console.WriteLine($"Vote casted: {vote}");
        }
        else
        {
            Console.WriteLine("All votes have been cast.");
        }
    }

    public void DisplayResults()
    {
        int yesCount = 0;
        int noCount = 0;

        for (int i = 0; i < _voteCount; i++)
        {
            if (_votes[i] == VoteOption.Yes)
                yesCount += 1;
            else if (_votes[i] == VoteOption.No)
                noCount += 1;
        }
        
        Console.WriteLine("Results:");
        Console.WriteLine($"Yes: {yesCount}");
        Console.WriteLine($"No: {noCount}");
    }
}