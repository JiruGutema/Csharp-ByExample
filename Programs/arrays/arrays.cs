using System;
// Arrays are used to store multiple values of the same type in a single variable. They provide a way to group related data together and access them using an index.
// in C#, we store arrays in the heap memory, and we access them using a reference variable.
// Arrays are of fixed size, which means that once an array is created, its size cannot be changed. If you need a dynamic collection, you can use other data structures like List<T>.
// the types of data should be same in an array. which means we can have an array of integers, or an array of strings, but we cannot have an array that contains both integers and strings.
class Arrays
{
    public void ArraysMethod()
    {
        Console.WriteLine("Inside Arrays Class");

        // declaring and initializing an array of integers
        // syntax: dataType[] arrayName = new dataType[size];
        int[] numbers = new int[5]; // array of size 5
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // printing the elements of the array
        Console.WriteLine("Array of Integers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }

        // declaring and initializing an array of strings
        // syntax: dataType[] arrayName = { value1, value2, value3, ... };
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // printing the elements of the array
        Console.WriteLine("Array of Strings:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + fruits[i]);
        }
        // jagged arrays - an array of arrays, where each element is itself an array. Jagged arrays allow you to create multi-dimensional structures with varying lengths for each dimension.
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        Console.WriteLine("Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }}

}
