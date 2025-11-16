using System;

// in C#, classes are the building block OOP. and classes let's us define real world objects by defining the behaviour and properties of the object oriented application
// classes give use the model or the blueprint while the objects are the actual objects in the real world

/*
    class ClassName{

        // Fields

        // Properties

        // Methods

    }

    */
// the difference between the Fields and Properties are that fields are variables that hold data while properties are members that provide a flexible mechanism to read, write, or compute the values of private fields. Properties can have logic in their getters and setters, allowing for validation or transformation of data when accessing or modifying the underlying field.
namespace OOP
{
    
class Person
{
    private double Heigth; // this the field
    private int Age;  

    // property - they have a way to manipulate the private fields. 

    private string? name; // private field
    public string? Name   // property
    {
        get { return name; }
        set { name = value; }
    }

    public void CanSpeak()
    {
        Console.WriteLine("Yes, People can Speak");
    }

    public void CanFly()
    {
        Console.WriteLine("No, People can't fly like birds");
    }
     public void SetAge(int age)
    {
        this.Age = age;
    }
    public void SetName(string name)
    {
        this.name = name;
    }

    public void PublicMethod()

    {
        Console.WriteLine("This is a public method");
        // instantiating the object of the class inside the class
        // syntax: ClassName objectName = new ClassName(); each object the class behaviors and properties and then the memory is allocated to the object
        Person personObj = new Person();
        personObj.CanSpeak();
        personObj.Name = "John Doe"; // using the property to set the name
        Console.WriteLine("Person Name: " + personObj.Name); // using the property to
        personObj.CanFly();
        personObj.SetAge(30); // accessing the field directly since it's within the same class
        personObj.SetName("Jiru Gutema");
        Console.WriteLine("Person Age: " + personObj.Age);

                
    }

}

public class Dog{

	// Instance Variables
	String name;
	String breed;
	int age;
	String color;

	// Constructor Declaration of Class same name as class
	public Dog(String name, String breed, int age, String color){
		this.name = name;
		this.breed = breed;
		this.age = age;
		this.color = color;
	}

	public String GetName()
	{
		return name;
	}

	public String GetBreed()
	{
		return breed;
	}

	public int GetAge()
	{
		return age;
	}

	public String GetColor()
	{
		return color;
	}

	public override String ToString()
	{
		return "my name is: " + name +
			   "\nmy breed is: " + breed +
			   "\nmy age is: " + age;
	}

}
}