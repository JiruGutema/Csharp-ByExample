using System;

// access modifiers in C# are keywords used to specify the accessibility of classes, methods, and other members. they determine whether other code can access a particular member or class. the main access modifiers in C# are public, private, protected, internal, and protected internal.
// there are six access modifiers. 

class AccessorModifiers
{
    // public - accessible from any other code
    public string publicField = "I am a public field";
    // private - accessible only within the same class
    private string privateField = "I am a private field";
    // protected - accessible within the same class and derived
    protected string protectedField = "I am a protected field";
    // internal - accessible within the same assembly
    internal string internalField = "I am an internal field";
    // protected internal - accessible within the same assembly or from derived classes
    protected internal string protectedInternalField = "I am a protected internal field"; 
    // private protected - accessible within the same class or derived classes in the same assembly
    private protected string privateProtectedField = "I am a private protected field";  
    



}