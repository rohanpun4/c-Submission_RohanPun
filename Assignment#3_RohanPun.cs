using System;

class Account
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string Type { get; }

    // Default constructor for checking account
    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        Type = "Checking";
    }

    // Creating a Constructor for specifying the account type
    public Account(string accountNumber, string type)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        Type = type;
    }

    // Creating a Constructor for specifying the account type and the initial balance
    public Account(string accountNumber, string type, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    // Using Method to deposit money into the account
    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("The amount you are trying to deposit is not valid.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Amount is Successfully deposited {amount} into account {AccountNumber}. New balance: {Balance}");
    }

    // Using Method to withdraw money from the account
    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("The amount you are trying to withdraw is not valid.");
            return;
        }
        if (Balance < amount)
        {
            Console.WriteLine("You have Insufficient balance in your account.");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"The amount was Successfully withdrawed {amount} from account {AccountNumber}. New balance: {Balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a checking account with default constructor
        Account checkingAccount = new Account("04511229");

        // Creating a saving account with specified type and initial balance
        Account savingAccount = new Account("02312789", "Savings", 50000);

        // Deposited and withdrawed money from the  accounts
        checkingAccount.Deposit(500);
        savingAccount.Withdraw(200);

        // Output current balance of accounts
        Console.WriteLine($"Checking Account Balance: {checkingAccount.Balance}");
        Console.WriteLine($"Saving Account Balance: {savingAccount.Balance}");
    }
}
