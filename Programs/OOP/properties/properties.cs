using System;

// properties in C# are members that provide a flexible mechanism to read, write, or compute the values of private fields. They are special methods called accessors that are used to access and modify the values of private fields in a controlled manner. Properties can have logic in their getters and setters, allowing for validation or transformation of data when accessing or modifying the underlying field.

// There are two main reasons to use properties:

//     To access private data members of the class from another class through accessors.
//     To protect members of the class so another class may not misuse those members.

// Accessors
// The block of “set” and “get” is known as Accessors. It is very essential to restrict the accessibility of the property. There are two types of accessors: get accessors and set accessors. 
class Properties
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0) age = value;
            else Console.WriteLine("Age cannot be negative!");
        }
    }
    public string GetInfo()
    {
        return "I am a person and my age is: " + age;
    }
}
