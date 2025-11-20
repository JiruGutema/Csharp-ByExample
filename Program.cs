using System;
using OOP;
using StringBuilderExamples;

namespace Program
{
    class Program
    {
        Program()
        {
            Console.WriteLine("Program Oject is created");
        }
        ~Program()
        {
            Console.WriteLine("Program Object is destroyed");
        }

        static void RunProgram()
        {
            // creating the object of Identifiers class
            Identifiers identifiers = new Identifiers();
            identifiers.IdentifiersMethod();
            // creating the object of Variables class
            Variables variables = new Variables();


            // creating the object of DataTypes class
            DataTypes dataTypes = new DataTypes();
            dataTypes.DataTypesMethod();

            // creating the object of Literals class
            Literals literals = new Literals();
            literals.LiteralsMethod();

            // creating the object of Scope class
            Scope scope = new Scope();
            scope.ScopeMethod();

            // creating the object of params
            Params paramsObj = new Params();
            paramsObj.ParamsMethod();

            // creating the object of typescasting
            TypeCasting typeCasting = new TypeCasting();
            typeCasting.TypeCastingMethod();

            // creating the object of operators
            Operators operators = new Operators();
            operators.OperatorsMethod();

            // createing the object of StringBuilder
            StringBuilderExample stringBuilderExample = new StringBuilderExample();
            stringBuilderExample.StringBuilderMethod();

            // creating the object of Person class in the OOP folder
            OOP.Person person = new OOP.Person();
            OOP.Dog dog = new OOP.Dog("Tuffy", "German Shepherd", 3, "Black and Tan");
            person.PublicMethod();

            // creating the Methods class object
            Methods methods = new Methods();
            methods.MethodsExample();

            // creating the Student class object of contructor example

            Student s1 = new Student();                  // default constructor
            Student s2 = new Student("Jiren");           // one-parameter constructor
            Student s3 = new Student("Mike", 123);       // two-parameter constructor

            s1.DisplayInfo();
            s2.DisplayInfo();
            s3.DisplayInfo();

            // creating the Destructors class object
            Destructors destructors = new Destructors();
            destructors.DisplayMessage();

            // creating the properties class object
            Properties properties = new Properties();
            properties.GetInfo();

            // creating the abstract class object
            Abstraction abstraction = new Abstraction();
            abstraction.AbstractionExample();


            // creating the interface class object
            InterfaceExample interfaceExample = new InterfaceExample();
            interfaceExample.RunInterfaceExample();

            // creating the generics class object
            Generic generic = new Generic();
            generic.GenericMain();

            // creating the exceptions class object
            Exceptions.Exceptions exceptions = new Exceptions.Exceptions();
            exceptions.ExceptionsMethod();

            // creating the threads class Object
            ThreadsExample.Threads threads = new ThreadsExample.Threads();
            threads.ThreadsExampleMethod();

            // collections Example
            CollectionsFramework.CollectionsExample collectionsExample = new CollectionsFramework.CollectionsExample();
            collectionsExample.CollectionsExampleMethod();
            

            // creating Linq class object
            
            LinqExample.Linq linq = new LinqExample.Linq();
            linq.LingMethod();
            


        }
        static void Main(string[] args)

        {
            if (args.Length > 0)
            {
                Console.WriteLine("Aegument is passed");
                foreach (string arg in args)
                {
                    Console.WriteLine("Args", arg);
                }
            }
            else
            {
                Console.WriteLine("No Argument is passed");
            }
            Program program = new Program();
            RunProgram();
        }
    }
}
