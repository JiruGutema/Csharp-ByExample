using System;

// Events in C# are a way for a class to provide notifications to clients of that class when something of interest occurs. Events are based on delegates and follow the publisher-subscriber model. A class that raises an event is called the publisher, and a class that listens for the event is called the subscriber.
// They are based on the publisher-subscriber model, where one class (publisher) notifies other classes (subscribers) when something of interest occurs. Events are built on top of delegates and form a key part of event-driven programming.
// they will be declared using the event keyword followed by the delegate type.
// It's also the way to send the notificaton from one object to the another. 
// The event keys word restricts the delegate access. We only subscribe using the += or unsubscripe using the -=. 
public delegate void Notify(); //The delegate function that only takes nothing as argument. just sends the message. 
namespace Events
{
    class Process
    {

        // Events are the mechanism to send the notification from one object to the another
        // EventHandler are the methods that responds to the notification. It has the code that runs when the event raised. 
        // The Syntax as follows. 
        // public delegate EventHandler(object Sender, EventArgs e).
        public event Notify ProcessCompleted;

        public void Started()
        {
            Console.WriteLine("The process has been started!");
            OnProcessCompleted();

        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }

    }

    public class Program
    {
        public void ProgramMethod()
        {
            Process process = new Process();
            process.ProcessCompleted += ProcessCompletedHanlder;
            process.Started();

        }

        static void ProcessCompletedHanlder()
        {
            Console.WriteLine("Process is Completed");
        }
    }
}
