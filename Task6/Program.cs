using System;

class BankAccount
{
    // Private Properties
    private string accountNumber;
    private string accountHolderName;
    private double balance;
    private string accountType;
    private string branchName;

    // Constructor
    public BankAccount(string accNumber, string holderName, double initialBalance,
                       string accType, string branch)
    {
        accountNumber = accNumber;
        accountHolderName = holderName;
        accountType = accType;
        branchName = branch;

        // Balance check
        if (initialBalance < 0)
        {
            Console.WriteLine("Error: Balance cannot be negative. Setting balance to 0.");
            balance = 0;
        }
        else
        {
            balance = initialBalance;
        }
    }

    // Destructor
    ~BankAccount()
    {
        Console.WriteLine($"BankAccount object for {accountHolderName} is destroyed.");
    }

    // Getters and Setters
    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public void SetAccountNumber(string value)
    {
        accountNumber = value;
    }

    public string GetAccountHolderName()
    {
        return accountHolderName;
    }

    public void SetAccountHolderName(string value)
    {
        accountHolderName = value;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void SetBalance(double value)
    {
        if (value < 0)
        {
            Console.WriteLine("Error: Balance cannot be negative.");
        }
        else
        {
            balance = value;
        }
    }

    public string GetAccountType()
    {
        return accountType;
    }

    public void SetAccountType(string value)
    {
        accountType = value;
    }

    public string GetBranchName()
    {
        return branchName;
    }

    public void SetBranchName(string value)
    {
        branchName = value;
    }

    // Methods
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Error: Deposit amount must be positive.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Error: Withdrawal amount must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Error: Insufficient balance.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrawn {amount}. Remaining balance: {balance}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\n    Account Information    ");
        Console.WriteLine($"Account Number     : {accountNumber}");
        Console.WriteLine($"Account Holder     : {accountHolderName}");
        Console.WriteLine($"Account Type       : {accountType}");
        Console.WriteLine($"Branch Name        : {branchName}");
        Console.WriteLine($"Balance            : {balance}");
    }
}

class Program
{
    static void Main()
    {
        // Create Objects
        BankAccount account1 = new BankAccount(
            "001",
            "Raghad Alshare",
            1000,
            "Savings",
            "Amman Branch"
        );

        BankAccount account2 = new BankAccount(
            "002",
            "Sara Ali",
            -200,   // Invalid balance (handled by constructor and set to 0)
            "Normal",
            "Irbid Branch"
        );

        // Perform Operations (Methods)
        account1.Deposit(500);
        account1.Withdraw(300);
        account1.Withdraw(2000); // Invalid withdrawal
        account1.DisplayInfo();

        account2.Deposit(800);
        account2.Withdraw(100);
        account2.DisplayInfo();
    }
}
