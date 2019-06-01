using System;

class Program
{
    static void Main()
    {
        // The directory from Windows.
        const string dir = @"C:\Users\Sam\Documents\Perls\Main";
        // Split on directory separator.
        string[] parts = dir.Split('\\');
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}