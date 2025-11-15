using System;
// In programming, variables are used to store data that can be manipulated and accessed throughout the program
// they are actually a alias name given to a memory location where data is stored. 
// variables must follow certain rules like identifiers.
class Decisions
{
    public void DecisionsMethod()
    {
        Console.WriteLine("Inside Decisions Class");

        // if - else statememt
        // syntax
        /*
        if (condition)
        {
            // code to be executed if condition is true
        }  else
        {
            // code to be executed if condition is false
        }
        */

        int number = 10;
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is an even number.");
        }
        else
        {
            Console.WriteLine(number + " is an odd number.");
        }

        // nested if - else statement
        /*
        if (condition1)
        {
            // code to be executed if condition1 is true
        }  else if (condition2)
        {
            // code to be executed if condition2 is true
        } else
        {
            // code to be executed if both conditions are false
        }
        */
        int marks = 85;
        if (marks >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else
        {
            Console.WriteLine("Grade: C");
        }

        // switch statement
        /*
        switch (expression)
        {
            case value1:
                // code to be executed if expression == value1
                break;
            case value2:
                // code to be executed if expression == value2
                break;
            ...
            default:
                // code to be executed if expression doesn't match any case
                break;
            finally
            {
                // code to be executed after the switch statement
            }
        */
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}