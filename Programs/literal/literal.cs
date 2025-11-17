using System;
// in a programming language, literals are the fixed values that are directly represented in the source code. it is the actual value assigned to a variable or constant. 
// it is not sth returned by a computation or expression. literals can be of different data types like integer, floating-point, character, string, boolean, etc.

class Literals
{
    public void LiteralsMethod()
    {
        Console.WriteLine("Inside Literals Class");

        // Integer literal
        int intLiteral = 100;
        Console.WriteLine("Integer Literal: " + intLiteral);

        // Floating-point literal
        double floatLiteral = 99.99;
        Console.WriteLine("Floating-point Literal: " + floatLiteral);

        // Character literal
        char charLiteral = 'A';
        Console.WriteLine("Character Literal: " + charLiteral);

        // String literal
        string stringLiteral = "Hello, World!";
        Console.WriteLine("String Literal: " + stringLiteral);

        // Boolean literal
        bool boolLiteral = true;
        Console.WriteLine("Boolean Literal: " + boolLiteral);
    }
}
