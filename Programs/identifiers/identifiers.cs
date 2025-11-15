using System;
// in programming language we use the identifiers to name variables, classes, methods, etc.
// Identifiers are the names given to various programming elements such as variables, functions, classes, and objects. They are used to uniquely identify these elements within the code.
// Identifiers must follow certain rules:
// 1. An identifier must begin with a letter (A-Z or a-z) or an underscore (_).
// 2. Subsequent characters can be letters, digits (0-9), or underscores.
// 3. Identifiers cannot be the same as reserved keywords in the programming language.
// 4. Identifiers are case-sensitive in most programming languages.
// 5. Identifiers should not contain spaces or special characters (except for underscores). 

class Identifiers
{
    public void IdentifiersMethod()
    {
        // variable name

        const string name  = "John"; // valid identifier
        const int age = 30;
        const double salary = 50000.50;
        // printing the values
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);

        Console.WriteLine("This is Identifiers class method.");
        Console.WriteLine("Identifiers are names used to identify variables, classes, methods, etc. in programming.");
        Console.WriteLine("They must follow specific rules regarding their formation.");
        Console.WriteLine("For example, an identifier must start with a letter or underscore and cannot be a reserved keyword.");

    }
}