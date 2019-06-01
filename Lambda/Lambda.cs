using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> elements = new List<int>() { 10, 20, 31, 40 };
        // ... Find index of first odd element.
        int oddIndex = elements.FindIndex(x => x % 2 != 0);
        Console.WriteLine(oddIndex);
    }
}
