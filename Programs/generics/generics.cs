using System;
// In C#, Generics allow developers to design classes that can work with any data type without compromising type safety. A generic class is a class that defines one or more type parameters, which can be specified when creating an object of that class.

// the syntax is the class takes the parameter at <T> in which T is the type which represents the type. 
// this will remove the necessity of declaring different classes just for different data type

class GenericClass<T>
{
    private T data;
    public GenericClass(T data)
    {
        this.data = data;
    }

    public T GetData()
    {
        return this.data;
    }

}

// A generic method is a method that has one or more type parameters defined within angle brackets (< >) after the method name. These parameters are specified when the method is called.
class GenericMethod
{
    // Generic method to display any type of data
    static void Display<T>(T value)
    {
        Console.WriteLine("Value: " + value);
    }

    public void GenericMethodMethod()
    {
        Display<int>(100);              // Works with int
        Display<string>("Jiru Gutema"); // Works with string
        Display<double>(99.99);         // Works with double
    }
}

class Generic
{
    public void GenericMain()
    {
        GenericClass<int> General_One = new GenericClass<int>(100);
        int data = General_One.GetData();
        Console.WriteLine("Data from the general class one ", Convert.ToString(data));


        GenericClass<string> General_Two = new GenericClass<string>("Jiru Gutema");
        string name = General_Two.GetData();
        Console.WriteLine("Data from the general class one ", Convert.ToString(data));

        // Generic Method Class
        GenericMethod genericmethod = new GenericMethod();
        genericmethod.GenericMethodMethod();


    }
}



