using System;
// Casting is the process of converting a variable from one data type to another. In C#, there are two types of casting: implicit and explicit.
// there are two types of type casting in C#:
// 1. Implicit Type Casting: In this type of casting, the conversion is done
// automatically by the compiler when there is no risk of data loss. For example, converting an int to a double.
// 2. Explicit Type Casting: In this type of casting, the conversion is done manually by the programmer using a cast operator. This is required when there is a risk of data loss, such as converting a double to an int.
// there are only some allowed casting between compatible data types.
class TypeCasting
{
    public void TypeCastingMethod()
    {
        Console.WriteLine("Inside TypeCasting Class");

        // Implicit casting (automatically done)
        // newdatatype variable = olddatatype_variable;
        int num = 10;
        double d = num; // int to double
        Console.WriteLine("Implicitly casted int to double: " + d);

        // Explicit casting (manually done)
        // newdatatype variable = (newdatatype) olddatatype_variable;
        double d2 = 9.78;
        int num2 = (int)d2; // double to int
        Console.WriteLine("Explicitly casted double to int: " + num2);
        TypeCasting typecasting = new TypeCasting();
        typecasting.UsingConvertClass();
        

    }

    public void UsingConvertClass()
    {
        // Using Convert class for type casting, which provides methods to convert between different data types.
        string strNum = "123";
        int intNum = Convert.ToInt32(strNum); // string to int
        Console.WriteLine("Converted string to int using Convert class: " + intNum); 
    }
 
}