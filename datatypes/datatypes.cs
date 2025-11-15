using System;
// C# is strongly typed language, which means that every variable and constant must have a data type defined at the time of declaration.
// Data types specify the type of data that a variable can hold, such as integers, floating-point numbers, characters, and more.
// Here are some commonly used data types in C#:

class DataTypes
{
    public void DataTypesMethod()
    {
        Console.WriteLine("Inside DataTypes Class");
        //! Value data types
        // Integer data type
        int intVar = 42;
        Console.WriteLine("Integer: " + intVar);

        // Floating-point data type
        float floatVar = 3.14f;
        Console.WriteLine("Float: " + floatVar);

        // Double data type
        double doubleVar = 3.14159;
        Console.WriteLine("Double: " + doubleVar);

        // Character data type
        char charVar = 'A';
        Console.WriteLine("Character: " + charVar);

        // String data type
        string stringVar = "Hello, C#!";
        Console.WriteLine("String: " + stringVar);

        // Boolean data type
        bool boolVar = true;
        Console.WriteLine("Boolean: " + boolVar);

        // we have double and float in the C# for the decimals
        // float is for 32 bits
        // double is for 64 bits

        float floatValue = 5.75f; // if there is not f at the end, it will be considered as double by default
        double doubleValue = 19.99;
        Console.WriteLine("Float Value: " + floatValue);
        Console.WriteLine("Double Value: " + doubleValue);

        // we do have also a decimal in C# which is used for high precision calculations like financial calculations
        decimal decimalValue = 99.99m; // m at the end indicates that it's a decimal type
        Console.WriteLine("Decimal Value: " + decimalValue);

        // we can have also a byte data type which is used to store small integer values from 0 to 255
        byte byteValue = 255;
        Console.WriteLine("Byte Value: " + byteValue);

        //! Reference data types -  these types store references to the actual data
        // String

        string referenceString = "This is a reference type string.";
        String anotherString = referenceString; // both variables point to the same string object in memory
        Console.WriteLine("Reference String: " + referenceString);
        Console.WriteLine("Another String: " + anotherString);

        // object - the base type from which all other types derive. all types in C# ultimately inherit from object. so we can assign any data type to an object variable.
        // to get the value on the object variable, we need to unbox it to the original data type.
        // 

        object objVar = "This is an object type variable.";
        Console.WriteLine("Object Variable: " + objVar);
        Console.WriteLine("Data type of the object variable: " + objVar.GetType());

        // unboxing
        string unboxedString = (string)objVar;
        Console.WriteLine("Unboxed String: " + unboxedString);
        Console.WriteLine("Data type of the unboxed variable: " + unboxedString.GetType());

        //! Nullable data types
        // Nullable types allow variables to hold null values in addition to their normal range of values.
        // the syntax is the data type followed by a question mark (?)
        int? nullableInt = null; // nullable integer
        string? name = null; // nullable string
        Console.WriteLine("Nullable Integer: " + nullableInt);
        nullableInt = 100;
        Console.WriteLine("Nullable Integer after assignment: " + nullableInt);
        Console.WriteLine("Nullable String: " + name);
        name = "Nullable String Example";
        Console.WriteLine("Nullable String after assignment: " + name);

        //! Dynamic data types
        // Dynamic types are resolved at runtime rather than compile time. we can assign any type of value to a dynamic variable, and its type can change during the program execution.
        dynamic dynamicVar = 10; // initially an integer
        Console.WriteLine("Dynamic Variable (int): " + dynamicVar);
        dynamicVar = "Now I'm a string"; // now a string
        Console.WriteLine("Dynamic Variable (string): " + dynamicVar);

        //! var data type
        // The var keyword allows the compiler to infer the data type of a variable based on the assigned value at compile time.
        var inferredInt = 50; // inferred as int
        var inferredString = "Inferred as string"; // inferred as string
        Console.WriteLine("Inferred Integer: " + inferredInt);
        Console.WriteLine("Inferred String: " + inferredString);    

        //! Pointer data types
        // Pointers are used in unsafe code to store the memory address of a variable. they are primarily used for low-level programming and interop scenarios.
        // the syntax for declaring  a pointer is the data type followed by an asterisk (*)
        // Note: To use pointers, you need to enable unsafe code in your project settings.
        // you can also access the value at the memory address using the dereference operator (*)
        unsafe 
        { 
            int number = 42;
            int* pointer = &number; // pointer to the memory address of number
            
            Console.WriteLine("Value of number: " + number);
            Console.WriteLine("Address of number: " + (int)pointer);
            Console.WriteLine("Value at pointer address: " + *pointer); 
        }
    }
}