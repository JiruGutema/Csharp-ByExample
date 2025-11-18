using System;
// In C#, an exception is an unexpected event that occurs during the execution of a program, which disrupts the normal flow of the program.
// Exceptions can occur due to various reasons such as invalid input, division by zero, file not found or network issues.
// there are two type of exceptions, 
// 1. Application Level - Error that occurs on application specific exception.
// 2. System Level - Error that raised during the execution of the program.
// exception handling is the process of responding to the occurrence of exceptions in a controlled manner. 

namespace Exceptions
{
    class Exceptions
    {
        // we handle exception using try, catch, finally and throu keywords.
        public void ExceptionsMethod()
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.", ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter numeric values.", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution of the try-catch block is complete.");

            }

        }
    }

}
