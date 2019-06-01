// C# program to 
// define Sealed Class 
using System; 

class Printer { 

    // Display Function for 
    // Dimension printing 
    public virtual void show() 
    { 
        Console.WriteLine("display dimension : 6*6"); 
    } 

    // Display Function 
    public virtual void print() 
    { 
        Console.WriteLine("printer printing....\n"); 
    } 
} 

// inherting class 
class LaserJet : Printer { 

    // Sealed Display Function 
    // for Dimension printing 
    sealed override public void show() 
    { 
        Console.WriteLine("display dimension : 12*12"); 
    } 

    // Function to override 
    // Print() function 
    override public void print() 
    { 
        Console.WriteLine("Laserjet printer printing....\n"); 
    } 
} 

// Officejet class cannot override show 
// function as it is sealed in LaserJet class. 
class Officejet : LaserJet { 

    // can not override show function or else 
    // compiler error : 'Officejet.show()' : 
    // cannot override inherited member 
    // 'LaserJet.show()' because it is sealed. 
    override public void print() 
    { 
        Console.WriteLine("Officejet printer printing...."); 
    } 
} 

// Driver Class 
class Program { 

    // Driver Code 
    static void Main(string[] args) 
    { 
        Printer p = new Printer(); 
        p.show(); 
        p.print(); 

        Printer ls = new LaserJet(); 
        ls.show(); 
        ls.print(); 

        Printer of = new Officejet(); 
        of.show(); 
        of.print(); 
    } 
} 

