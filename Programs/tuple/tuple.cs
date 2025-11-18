using System;
// tuples is a collection that let's us to store a collection of the data that has a multiple data types. 
// it can also store the duplicate datas
// in C# tuples must be at most eight members without nested tuples. 
// they are also what we call them the reference type datatypes in c#. 

namespace Tuples
{
    public class Tuples
    {
        public void TuplesMethod()
        {
            Console.WriteLine("This is inside the Tuple Class");

            // declaration of the tuples
            // 1. the standard way 
            // (type, type, type) name = (data, data, data )
            var myTuple = (20, "Jiru", 2.0);
            // or 
            (int, string, double) myOtherTuple = (30, "Gutema", 4.0);
            Console.WriteLine(myTuple);

            Console.WriteLine(myOtherTuple);

            // Tuples in C# only contains max of 8 members. uncommenting the following line will rise error
            // var moreThanEight = (1,2,3,4,5,5,6,6);
            //
            // we can also access the times like this;
            //
            Console.WriteLine("First Element: ", myOtherTuple.Item1);
            Console.WriteLine("Second Element: ", myOtherTuple.Item2);
            Console.WriteLine("Third Element: ", myOtherTuple.Item3);

            // we can also have nested tuples as follows. 



            var myOtherNestedTuple = (30, "Gutema", 4.0, (1, 2, 3, 4));
            Console.WriteLine(myOtherNestedTuple.Item1);
            Console.WriteLine(myOtherNestedTuple.Item4.Item3);


        }

    }
}
