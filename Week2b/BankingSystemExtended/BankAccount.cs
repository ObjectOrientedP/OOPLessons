using System;

public class BankAccount {
    // Private fields for encapsulation
    protected string accountNumber;
    protected string accountHolderName;
    protected decimal balance;

        // Constructor to initialize the account details
    public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = initialBalance;
    }
        
    public virtual void Deposit(decimal amount)
    {
        if (IsValidAmount(amount))  // Using private method for validation
        {
            balance += amount;
            Console.WriteLine($"Deposit successful. Current balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }

        // Public method to withdraw money
    public virtual void Withdraw(decimal amount)
    {
        if (IsValidAmount(amount))  // Using private method for validation
        {
            if (HasSufficientBalance(amount))  // Using private method to check balance
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
            }
        else
        {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
        }
    }

        // Public method to get the current balance
    public decimal GetBalance()
    {
        return balance;
    }

        // Public method to print account details
    public virtual void GetAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolderName}");
        Console.WriteLine($"Current Balance: {Math.Round(balance, 2)}");
    }

        // Private method to validate the amount (amount > 0)
    private bool IsValidAmount(decimal amount)
    {
        return amount > 0;
    }

        // Private method to check if the account has sufficient balance for a withdrawal
    private bool HasSufficientBalance(decimal amount)
    {
        return balance >= amount;
    }
}

    