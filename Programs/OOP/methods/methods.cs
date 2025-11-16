using System;

// Methods are the blocks of code that perform a specific task. They are used to organize code into reusable sections, making it easier to read, maintain, and debug. Methods can take parameters, perform operations, and return values. In C#, methods are defined within classes and are invoked using the method name followed by parentheses.

class Methods
{
    // Method without parameters and without return type
    public void Greet()
    {
        Console.WriteLine("Hello, welcome to C# methods!");
    }

    // Method with parameters and without return type
    public void PrintSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum: " + sum);
    }

    // Method with parameters and with return type
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method with default parameter value
    public void DisplayMessage(string message = "Default Message")
    {
        Console.WriteLine(message);
    }

    public void MethodsExample()
    {
        Greet(); // Calling method without parameters
        PrintSum(5, 10); // Calling method with parameters
        int product = Multiply(4, 6); // Calling method with return type
        Console.WriteLine("Product: " + product);
        DisplayMessage(); // Calling method with default parameter
        DisplayMessage("Custom Message"); // Calling method with custom parameter
    }
}