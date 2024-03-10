using System;

public class BankAccount
{
    // Auto-implemented properties for encapsulation
    public string AccountHolder { get; set; }
    public double Balance { get; private set; }

    // Public methods to operate on the data
    public void Deposit(double amount)
    {
        // Additional validation can be added
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposit of {amount:C} successful. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(double amount)
    {
        // Additional validation can be added
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal of {amount:C} successful. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of BankAccount
        BankAccount account = new BankAccount();

        // Use encapsulation to set the account holder and deposit money
        account.AccountHolder = "John Doe";
        account.Deposit(1000);

        // Attempt to set invalid values using encapsulation
        account.AccountHolder = ""; // This will print an error message
        account.Deposit(-500);      // This will print an error message

        // Withdraw money using encapsulation
        account.Withdraw(200);

        // Attempt an invalid withdrawal
        account.Withdraw(10000);    // This will print an error message
    }
}
