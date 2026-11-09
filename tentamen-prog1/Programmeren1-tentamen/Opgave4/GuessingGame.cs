namespace Opgave4;

public class GuessingGame
{
    private int secretNumber;
    private int guessCount;

    public GuessingGame()
    {
        Random r = new Random();
        secretNumber = r.Next(1, 21);
        guessCount = 0;
    }

    public int GetGuessCount()
    {
        return guessCount;
    }

    public string Guess(int number)
    {
        guessCount += 1;
        string output = "";
        if (number < secretNumber)
        {
            output = "Too low";
        } else if (number > secretNumber)
        {
            output = "Too high";
        } else
        {
            output = "Correct";
        }

        return output;
    }
}