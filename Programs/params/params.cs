using System;
using System.Numerics;
// we use params in c# to specify a method parameter that takes a variable number of arguments.
// notice that it's different from the method overloading. with method overloading, we define multiple methods with the same name but different parameter lists.
// with params, we define a single method that can accept a variable number of arguments of a specific type.
class Params
{
    public void Add(params int[] nums)
    {
        int n = nums.Length;
        Console.WriteLine("Number of arguments passed: " + n);
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
        }

        Console.WriteLine("Sum of all arguments: " + sum);
    }

    // we can have also other parameters along with params parameter but params parameter must be the last parameter in the method signature.
    public void DisplayInfo(string name, params int[] scores)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Scores: ");
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
    }
    public void ParamsMethod()
    {
        Console.WriteLine("Inside Params Class");

        // calling Add method with different number of arguments
        Add(10, 20);
        Add(5, 15, 25, 35);
        Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        // calling DisplayInfo method
        DisplayInfo("Alice", 85, 90, 95);
        DisplayInfo("Bob", 70, 75);
    }
}