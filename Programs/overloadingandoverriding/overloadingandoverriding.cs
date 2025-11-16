using System;

// Overloading and Overriding in C# are two important concepts in object-oriented programming that allow developers to define methods with the same name but different behaviors.
//Overloading - It is a compile-time polymorphism where multiple methods can have the same name but differ in the type or number of parameters. The correct method is chosen at compile time based on the arguments passed during the method call.
//Overriding - It is a runtime polymorphism where a derived class provides a specific implementation

namespace OverloadingandOverriding
{
    class OverloadingandOverriding
    {
        // Method Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method Overriding
        public virtual void Display()
        {
            Console.WriteLine("Base class Display method");
        }
    }

    class Derived : OverloadingandOverriding
    {
        public override void Display()
        {
            Console.WriteLine("Derived class Display method");
        }
    }

    // Polymorphism - is the ability of a method to do different things based on the object that it is acting upon. It allows methods to be used in different ways depending on the context in which they are called.
    // overloading and overriding are two ways to achieve polymorphism in C#.
}