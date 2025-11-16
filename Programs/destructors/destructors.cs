using System;

// in C#, destructors are special methods that are automatically called when an object of a class is destroyed or goes out of scope. They are used to release resources that the object may have acquired during its lifetime, such as memory, file handles, or network connections. A destructor has the same name as the class, preceded by a tilde (~), and does not take any parameters or have a return type. Destructors cannot be overloaded, meaning a class can have only one destructor.

// the syntax of destructor is similar to constructor but it is preceded by a tilde (~) symbol. it does not take any parameter and it does not have any return type.
// Constructor is called when the new object is created, after which all the operations are performed. At the end, before Main method is exited all the object elements are destroyed.
class Destructors 
{
    // Constructor
    public Destructors() 
    {
        Console.WriteLine("Object Created.");
    }

    // Destructor
    ~Destructors() 
    {
        Console.WriteLine("Object Destroyed.");
    }

    public void DisplayMessage() 
    {
        Console.WriteLine("Message Printed.");
    }


}