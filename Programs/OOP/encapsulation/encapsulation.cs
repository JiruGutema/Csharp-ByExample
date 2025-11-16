using System;
// Encapsulation is one of the four fundamental OOP concepts. It is the mechanism of restricting access to some of an object's components and protecting the object's internal state from unintended interference and misuse. In C#, encapsulation is achieved using access modifiers (public, private, protected, internal) to control the visibility of class members.

// In this example, we will create a class `BankAccount` that encapsulates the account balance and provides methods to deposit and withdraw money while ensuring that the balance cannot be directly accessed or modified from outside the class.

class BankAccount
{
    // Private field to store the account balance
    private decimal balance;

    // Public method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Public method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Public method to get the current balance
    public decimal GetBalance()
    {
        return balance;
    }

    private int accountNumber; // private field
    public int AccountNumber   // property

    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
    // getter and setter methods are used to access the private field accountNumber. 
    // This is another example of encapsulation.

    private string? accountHolderName; // private field

    public string? getAccountHolderName() // getter method
    {
        return accountHolderName;
    }

    public void setAccountHolderName(string? name) // setter method
    {
        accountHolderName = name;
    }

// in C#, we can use properties to encapsulate the fields of a class. properties provide a way to read, write, or compute the values of private fields in a controlled manner.
    

}