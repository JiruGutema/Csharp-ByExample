// In C#, a thread is a lightweight process that represents a separate path of execution within a program.
// Threads allow multiple tasks to run concurrently, enabling better utilization of system resources and improving the responsiveness of applications.
// Threads can be created and managed using the System.Threading namespace, which provides classes and methods for working with threads.

namespace ThreadsExample
{
    class Threads
    {
        public void ThreadsExampleMethod()
        {
            Threads threads = new Threads();
            Thread thread1 = new Thread(threads.Function1);
            Thread thread2 = new Thread(threads.Function2);
            Thread thread3 = new Thread(threads.Function3);
            Console.WriteLine("This is an example of Threads in C#.");
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        public void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 - Count: " + i);
                Thread.Sleep(100);
            }
        }

        public void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 - Count: " + i);
                Thread.Sleep(100);
            }
        }

        public void Function3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 3 count: ", i);
                Thread.Sleep(100);
            }
        }
    }
}
