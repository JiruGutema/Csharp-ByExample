using System;
using System.Numerics;
// delegate in C# is a type that represents references to methods with a specific parameter list and return type. Delegates are used to pass methods as arguments to other methods. They are similar to function pointers in C and C++, but are type-safe and secure.
namespace Delegate
{
    class DelegateClass
    {
        public int CalcTotal(int a, int b)
        {
            int tot = a + b;
            return tot;
        }

        public int CalcProduct(int a, int b)
        {
            int prod = a * b;
            return prod;
        }

        public delegate int MyDelegate(int a, int b); // declaring a delegate   

        public void DelegateMethod()
        {
            MyDelegate myDelegate = new MyDelegate(CalcTotal); // instantiating the delegate
            int result = myDelegate(10, 20); // calling the method using delegate

            // we can also do the following

            MyDelegate d = CalcProduct;
            int product = d(3, 5);
            Console.WriteLine("Product from the my delegate", Convert.ToString(product));

            Console.WriteLine("The total is: " + result);


            // here we used two methods two invoke both of them at the same time. the methods are called send email and send sms
            Notify notify = SendEmail;
            notify += SendSms;
            notify("Hello this is the message from the future");
            // the methods are called in the fifo order. first send email and then send sms. 

            Console.WriteLine("After removing the send sms notification");
            notify -= SendSms;



        }

        // we can also multicast the delegate letting us to call the multiple arguments

        public delegate void Notify(string message);
        public static void SendEmail(string message)
        {
            Console.WriteLine($"Hello This is email notification from the notify class: {message}");
        }

        public static void SendSms(string message)
        {
            Console.WriteLine($"This is sms notification from the Notify: {message} ");
        }

        // predicate delegate
        // a predicate delegate is a special type of delegate that takes one input parameter and returns a boolean value (true or false).
        public static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        // this is the example of predicate delegate. it takes an integer as input and returns true if the number is even, otherwise false.
        public void PredicateDelegateExample()

        {
            //! for predicate delegate, we use Predicate<T> where T is the type of input parameter. the return type is always bool.
            Predicate<int> isEven = IsEvenNumber;
            bool result = isEven(4);
            Console.WriteLine("Is 4 even? " + result);

        }

        //! action delegate - we use action delegate when we want to pass a method that does not return any value. it can take multiple input parameters but does not return anything.
        public static void PrintMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public void ActionDelegateExample()
        {
            //! action doesn't return any value. it takes a string as input parameter.
            Action<string> print = PrintMessage;
            print("Hello from Action Delegate!");
        }

        //! func delegate - func delegate is used when we want to pass a method that returns a value. it can take multiple input parameters and returns a value.
        public static int Square(int number)
        {
            return number * number;
        }

        public void FuncDelegateExample()
        {
            //! <int, int> - the first int is the input parameter type and the second int is the return type.
            Func<int, int> squareFunc = Square;
            int result = squareFunc(5);
            Console.WriteLine("Square of 5 is: " + result);
        }



    }
}
