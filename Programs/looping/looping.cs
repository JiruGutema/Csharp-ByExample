using System;
// Looping in programming refers to the process of executing a block of code repeatedly for a certain number of times or until a specific condition is met. Loops are used to automate repetitive tasks and can help reduce code redundancy.
// There are several types of loops commonly used in programming:
// 1. For Loop: Used when the number of iterations is known beforehand.
// 2. While Loop: Used when the number of iterations is not known and depends on a condition.
// 3. Do-While Loop: Similar to the while loop, but guarantees that the code block is executed at least once.
// 4. Foreach Loop: Used to iterate over elements in a collection or array.

// we can use jump statements like break and continue in loops
class Looping
{
    public void LoopingMethod()
    {
        Console.WriteLine("Inside Looping Class");

        // For Loop
        Console.WriteLine("For Loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }

        // While Loop
        Console.WriteLine("While Loop:");
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine("Count: " + count);
            count++;
        }

        // Do-While Loop
        Console.WriteLine("Do-While Loop:");
        int num = 0;
        do
        {
            Console.WriteLine("Number: " + num);
            num++;
        } while (num < 5);

        // Foreach Loop
        Console.WriteLine("Foreach Loop:");
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}