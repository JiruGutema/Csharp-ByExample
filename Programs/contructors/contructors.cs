using System;

// in C#, contructors are special methods that are automatically called when an object of a class is created. They are used to initialize the object's properties and allocate resources. A constructor has the same name as the class and does not have a return type, not even void. Constructors can be overloaded, meaning a class can have multiple constructors with different parameters.

// contructors in C# are just the methods that has the same name as the class name. it can take an argument or not take any argument. it is used to initialize the object of the class when it is created.
public class Student
{
    private string? name;
    private int? id;

    public Student(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    // we can have also default constructor that does not take any argument
   public Student()
    {
        this.name = "Default Name";
        this.id = 0;
    }
    // another contructors with different parameters
    public Student(string name)   
    {
        this.name = name;
        this.id = 0;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetId(int id)
    {
        this.id = id;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Inside the Constructor of Student Class");
        Console.WriteLine("Student Name: " + this.name);
        Console.WriteLine("Student ID: " + this.id);
    }
}