// C# program to illustrate the 
// concept inheritance 
using System;

// Outer class 
public class Outer_class
{

    // Method of outer class 
    public void method1()
    {
        Console.WriteLine("Outer class method");
    }

    // Inner class 
    public class Inner_class
    {
    }
}

// Derived class 
public class Exclass : Outer_class
{

    // Method of derived class 
    public void func()
    {
        Console.WriteLine("Method of derived class");
    }
}

// Driver Class  
public class GFG
{

    // Main method 
    static public void Main()
    {

        // Creating object of  
        // the derived class 
        Exclass obj = new Exclass();
        obj.func();
        obj.method1();
    }
}