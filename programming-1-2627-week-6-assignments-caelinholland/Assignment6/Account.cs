namespace Assignment6;

public class Account
{
    private string _accountHolder;
    private double _amount = 0;
    public Account(string accountHolder)
    {
        _accountHolder = accountHolder;
    }

    public void Deposit(double amount)
    {
        _amount += amount;
        LogTransaction("Deposit successful.");
    }

    private void LogTransaction(string message)
    {
        Console.WriteLine(message);
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {_accountHolder}");
        Console.WriteLine($"Amount: {_amount}");
    }
}