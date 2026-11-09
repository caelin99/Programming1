namespace Assignment8;

public class BankAccount
{
    public string AccountNumber { get; }
    private double _balance;

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        _balance = balance;
    }

    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Deposit amount cannot be negative");
        }
        else
        {
            Balance += amount;
            Console.WriteLine("Deposit successful.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Withdrawal amount cannot be negative");
        }
        else if (amount > Balance)
        {
            Console.WriteLine($"Withdrawal amount is higher than current balance.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
    }
}