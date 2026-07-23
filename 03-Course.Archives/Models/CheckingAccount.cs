namespace Course.Archives.Models;

internal class CheckingAccount
{
    public int Number { get; }
    public int Branch { get; }
    public double Balance { get; private set; }
    public Client Holder { get; set; }

    public CheckingAccount(int branch, int number, Client holder)
    {
        Branch = branch;
        Number = number;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.", nameof(amount));
        }

        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.", nameof(amount));
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
    }
}
