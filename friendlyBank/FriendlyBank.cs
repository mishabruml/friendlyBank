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
        // Create array of empty accounts
        const int MAX_CUST = 50;
        Account[] Bank = new Account[MAX_CUST];

        // Assign info to first account in bank
        Bank[0].State = AccountState.Active;
        Bank[0].Name = "Misha Bruml";
        Bank[0].Address = "5 Fake St.";
        Bank[0].AccountNumber = 12345;
        Bank[0].Balance = 10000;
        Bank[0].Overdraft = 1000;

        printAccount(Bank[0]); // Call print method
    }
}

