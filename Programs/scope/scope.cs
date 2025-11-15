using System;
// Scope in programming refers to the visibility and lifetime of variables and constants within different parts of the code. It determines where a variable can be accessed and modified.
// There are mainly two types of scope:
// 1. Local Scope: Variables declared within a function or block are only accessible within that function or block.
// 2. Global Scope: Variables declared outside of any function or block are accessible from anywhere in the program.

// In C#, we also have class scope, method scope, and block scope.

class Scope
{
    public void ScopeMethod()
    {
        Console.WriteLine("Inside Scope Class");

        // Global Scope
        int globalVar = 10; // accessible throughout the class

        void LocalScopeExample()
        {
            // Local Scope
            int localVar = 20; // accessible only within this method
            Console.WriteLine("Local Variable: " + localVar);
            Console.WriteLine("Global Variable from Local Scope: " + globalVar);
        }

        int count = 10;
        while (count > 0)
        {
            // Block Scope
            int blockVar = count * 2; // accessible only within this block
            Console.WriteLine("Block Variable: " + blockVar);
            count--;
        }


        LocalScopeExample();

        // Uncommenting the next line will cause an error because localVar is not accessible here
        // Console.WriteLine("Local Variable: " + localVar);

        // Uncommenting the next line will cause an error because blockVar is not accessible here
        // Console.WriteLine("Block Variable: " + blockVar);
    }
}