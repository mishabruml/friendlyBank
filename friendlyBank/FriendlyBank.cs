using System;
// FriendlyBank banking program
// Little program playing around with some simple C# concepts
// From Rob Miles' C# Yellow Book

enum AccountState // Enumerated type
{
    New,
    Active,
    UnderAudit,
    Frozen,
    Closed
};

struct Account // Data structure
{
    public AccountState State;
    public string Name;
    public string Address;
    public int AccountNumber;
    public int Balance;
    public int Overdraft;
};

class BankProgram
{
    static void printAccount(Account account) // Method to print all the account info
    {
        
        Console.WriteLine("Account State: " + account.State);
        Console.WriteLine("Account Name: " + account.Name);
        Console.WriteLine("Account Address: " + account.Address);
        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Account Balance: " + account.Balance);
        Console.WriteLine("Account Overdraft: " + account.Overdraft);

    }

    public static void Main()
    {
        // Create a new account and assign info
        Account MishasAccount;
        MishasAccount.State = AccountState.UnderAudit;
        MishasAccount.Name = "Misha Bruml";
        MishasAccount.Address = "5 Fake St.";
        MishasAccount.AccountNumber = 22222;
        MishasAccount.Balance = 10000;
        MishasAccount.Overdraft = 1000;

        printAccount(MishasAccount); // Call print method!

    }


}

