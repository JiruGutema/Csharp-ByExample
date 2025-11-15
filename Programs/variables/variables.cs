using System;
// In programming, variables are used to store data that can be manipulated and accessed throughout the program
// they are actually a alias name given to a memory location where data is stored. 
// variables must follow certain rules like identifiers.
class Variables
{
    public void VariablesMethod()
    
    {
        Console.WriteLine("Inside Variables Class");

        // variable declaration and initialization
        int number = 10; // integer variable
        string message = "Hello, World!"; // string variable
        double pi = 3.14; // double variable


        // printing the values of variables
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Pi: " + pi);

        // Declaring the variables
        // while declaring the variables, we need to specify the data types and the variable name. we can also initialize the variable at the time of declaration.
        int age;
        string name;

        // Initializing the variables
        age = 25;
        name = "Alice";

        // declare and initialize in a single line

        float height = 5.9f;
        bool isStudent = true;


        // printing the values of variables
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Is Student: " + isStudent);


        // There two ways we can initialize the variables
        // 1. Explicit Initialization: In this method, we explicitly specify the data type of
        // the variable at the time of declaration.
        int explicitVar = 100; // explicitly declared as int
        Console.WriteLine("Explicitly Initialized Variable: " + explicitVar);

        // 2. Implicit Initialization: In this method, we use the 'var' keyword to let the compiler
        // infer the data type based on the assigned value.
        var implicitVar = "This is an implicitly typed variable"; // compiler infers it as string
        Console.WriteLine("Implicitly Initialized Variable: " + implicitVar);

        // also there two types of initialization, compile time initialization and runtime initialization.
        // Compile Time Initialization: In this method, the variable is initialized with a value
        // that is known at compile time.
        const double gravity = 9.81; // compile time initialization
        Console.WriteLine("Gravity: " + gravity);

        // Runtime Initialization: In this method, the variable is initialized with a value
        // that is determined at runtime.
        Random random = new Random();
        int randomNumber = random.Next(1, 100); // runtime initialization
        Console.WriteLine("Random Number: " + randomNumber);

        // or asking for the console input from the user
        // Console.Write("Enter your favorite color: ");
        // string favoriteColor = Console.ReadLine() ?? "";
        // Console.WriteLine("Your favorite color is: " + favoriteColor);



    }
}