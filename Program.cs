using System;

namespace Program 
{
    class Program
    {
        static void Main(string[] args)

        { // creating the object of Identifiers class
            Identifiers identifiers = new Identifiers();
            identifiers.IdentifiersMethod();
            // creating the object of Variables class
            Variables variables = new Variables();
            variables.VariablesMethod();

            // creating the object of DataTypes class
            DataTypes dataTypes = new DataTypes();
            dataTypes.DataTypesMethod();

            // creating the object of Literals class
            Literals literals = new Literals();
            literals.LiteralsMethod();
        }
    }
}