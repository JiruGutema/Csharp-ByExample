using System;
// Operators are special symbols or keywords in programming languages that perform specific operations on one or more operands (variables, constants, or values). They are used to manipulate data and perform calculations. In C#, operators can be categorized into several types:
// 1. Arithmetic Operators: Used for mathematical calculations (e.g., +, -, *, /, %).
// 2. Comparison Operators: Used to compare two values (e.g., ==, !=, >, <, >=, <=).
// 3. Logical Operators: Used to combine or invert boolean expressions (e.g., &&, ||, !).
// 4. Assignment Operators: Used to assign values to variables (e.g., =, +=, -=, *=, /=).
// 5. Bitwise Operators: Used to perform operations on individual bits of integer types (e.g., &, |, ^, ~, <<, >>).
// 6. Other Operators: This includes operators like the ternary operator (?:), null-coalescing operator (??), and others.
class Operators
{
    public void OperatorsMethod()
    {
        Console.WriteLine("Inside Operators Class");

        // Arithmetic Operators
        int a = 10;
        int b = 5;
        Console.WriteLine("Addition: " + (a + b)); // 15
        Console.WriteLine("Subtraction: " + (a - b)); // 5
        Console.WriteLine("Multiplication: " + (a * b)); // 50
        Console.WriteLine("Division: " + (a / b)); // 2
        Console.WriteLine("Modulus: " + (a % b)); // 0

        // Comparison Operators
        Console.WriteLine("Equal: " + (a == b)); // False
        Console.WriteLine("Not Equal: " + (a != b)); // True
        Console.WriteLine("Greater Than: " + (a > b)); // True
        Console.WriteLine("Less Than: " + (a < b)); // False

        // Logical Operators
        bool x = true;
        bool y = false;
        Console.WriteLine("Logical AND: " + (x && y)); // False
        Console.WriteLine("Logical OR: " + (x || y)); // True
        Console.WriteLine("Logical NOT: " + (!x)); // False

        // Assignment Operators
        int c = 20;
        c += 5; // c = c + 5
        Console.WriteLine("Assignment += : " + c); // 25

        // Bitwise Operators
        int bitA = 6; // 110 in binary
        int bitB = 3; // 011 in binary
        Console.WriteLine("Bitwise AND: " + (bitA & bitB)); // 2 (010 in binary)
        Console.WriteLine("Bitwise OR: " + (bitA | bitB)); // 7 (111 in binary)

        // Ternary Operator
        int max = (a > b) ? a : b;
        Console.WriteLine("Ternary Operator (max): " + max); // 10

        // Null-Coalescing Operator
        string? str = null;
        string result = str ?? "Default Value";
        Console.WriteLine("Null-Coalescing Operator: " + result); // Default Value
        
    }
}