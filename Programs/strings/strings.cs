using System;
// In C#, Strings are a sequence of unicode characters used to represent text. They are immutable, meaning once created, their values cannot be changed. Strings are represented by the `string` keyword or the `String` class in the .NET framework.
// they are immutable, which means that once a string is created, it cannot be changed. Any operation that appears to modify a string actually creates a new string.

class Strings
{
    public void StringsMethod()
    {
        Console.WriteLine("Inside Strings Class");

        // declaring and initializing a string
        string greeting = "Hello, World!";
        Console.WriteLine("Greeting: " + greeting);

        // concatenation of strings
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);

        // string interpolation
        int age = 30;
        string info = $"Name: {fullName}, Age: {age}";
        Console.WriteLine("Info: " + info);

        // accessing characters in a string
        char firstChar = greeting[0];
        Console.WriteLine("First Character of Greeting: " + firstChar);

        // getting the length of a string
        int length = greeting.Length;
        Console.WriteLine("Length of Greeting: " + length);

        // Verbatim string literal - useful for file paths and multi-line strings. it ignores escape sequences.
        string filePath = @"C:\Users\JohnDoe\Documents\file.txt";
        Console.WriteLine("File Path: " + filePath);
    }
}