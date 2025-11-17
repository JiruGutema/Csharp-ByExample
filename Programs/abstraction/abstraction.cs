using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

// in programming abstraction is the concept of hiding the complex implementation details and showing only the essential features of the object. it helps to reduce complexity and increase efficiency by allowing the programmer to focus on interactions at a higher level rather than dealing with low-level details.

// 1. Using Abstract Classes

// An abstract class is declared with the help of an abstract keyword. In C# not allowed to create objects of abstract class. We create a derived class take properties of the abstract class and use them to achieve abstraction. Furthermore, we can access it from the Instance of the derived class object. There are some important points to remember regarding abstract classes mentioned below:

//     We are not allowed to declare the abstract methods outside the abstract class.
//     We can not define properties directly to the abstract method.
//     The actual task or behaviour of the abstract method is implemented in the derived class.
//     We are not allowed to declare an abstract class as a Sealed Class
//     We can not declare an abstract class as Static Class.

abstract class Animal
{
    public abstract void MakeSound(); // abstract method
    public void Eat()
    {
        Console.WriteLine("All animals are eating.");
    }
    public abstract void Sleep(); // another abstract method
    public abstract int Age { get; set; } // abstract property
}


class Human : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Human says: Hello!");
    }

    public override void Sleep()
    {
        Console.WriteLine("Human is sleeping for 8 hours.");
    }
    public override int Age { get => Age; set => Console.WriteLine("Setting age to: " + value); }

}

class Abstraction
{
    public void AbstractionExample()
    {
        // Animal animal = new Animal(); // This will give an error because we cannot instantiate an abstract class
        Human human = new Human();
        human.MakeSound(); // Output: Human says: Hello!
        human.Eat();       // Output: All animals are eating.
        human.Sleep();     // Output: Human is sleeping for 8 hours.
    }
}


// Using Interfaces
// An interface is a contract that defines a set of methods and properties that a class must implement. It provides a way to achieve abstraction by specifying what a class should do without dictating how it should do it. A class can implement multiple interfaces, allowing for more flexible and modular designs.


//! The real difference between Abstract class and Interface is that an abstract class can have both abstract and non-abstract methods, while an interface can only have abstract methods (until C# 8.0, which introduced default implementations in interfaces). Additionally, a class can inherit from only one abstract class but can implement multiple interfaces.
interface IVehicle
{
    void Start();
    void Stop();
    int Speed { get; set; }
}

class Car : IVehicle
{
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopping.");
    }
}

class InterfaceExample
{
    public void RunInterfaceExample()
    {
        IVehicle myCar = new Car();
        myCar.Start(); // Output: Car is starting.
        myCar.Speed = 60;
        Console.WriteLine("Car speed: " + myCar.Speed + " km/h"); // Output: Car speed: 60 km/h
        myCar.Stop(); // Output: Car is stopping.
    }
}
