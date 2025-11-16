using System;
using System.Text;
using System.Collections;

// In C#, StringBuilder is a mutable sequence of characters used for creating and manipulating strings more efficiently, especially when performing multiple modifications. It is part of the System.Text namespace and is represented by the `StringBuilder` class.
namespace StringBuilderExamples
{
    class StringBuilderExample
    {
        public void StringBuilderMethod()
        {
            StringBuilderExample stringBuilderExample = new StringBuilderExample();
            Console.WriteLine(stringBuilderExample.concat("This is the string format for the string type"));
            StringBuilder stringBuilder = new StringBuilder("This is the string format for the StringBuilder type");
            Console.WriteLine(stringBuilderExample.usingStrinnBuilder(stringBuilder));
        }

        private string concat(String s1)
        {
            return s1 + " from concatenate method "; 
        }

        public string usingStrinnBuilder(StringBuilder s1)
        {
            s1.Append("Hello ");
            s1.Append("from ");
            s1.Append("StringBuilder ");
            s1.Append("class.");
            return s1.ToString();
        }
        
    }
}