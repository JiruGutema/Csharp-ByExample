using System;

// Inheritance in C# is a fundamental object-oriented programming concept that allows a class (derived class or child class) to inherit properties and methods from another class (base class or parent class). This promotes code reusability and establishes a hierarchical relationship between classes.
// In this example, we will create a base class `Animal` and a derived class `Dog` that inherits from the `Animal` class.
//! in C#, we are not allowed to have multiple inheritence directly. but we can achieve multiple inheritence using interfaces.
namespace InheretenceExample
{
    // Base class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }

    class Inheritence
    {
        public void InheritenceExample()
        {
            Dog dog = new Dog();
            dog.Eat();   // Inherited method from Animal class
            dog.Sleep(); // Inherited method from Animal class  

            dog.Bark();  // Method from Dog class
        }
    }
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    class Organism
    {
        public void Respire()
        {
            Console.WriteLine("The organism is respiring.");
        }
    }


}
