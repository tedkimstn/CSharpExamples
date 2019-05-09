using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1
        // New SortedDictionary
        SortedDictionary<string, int> sort =
            new SortedDictionary<string, int>();

        // 2
        // Add strings and int keys
        sort.Add("zebra", 5);
        sort.Add("cat", 2);
        sort.Add("dog", 9);
        sort.Add("mouse", 4);
        sort.Add("programmer", 100);

        // 3
        // Example: see if it doesn't contain "dog"
        if (sort.ContainsKey("dog"))
        {
            Console.WriteLine(true);
        }

        // 4
        // Example: see if it contains "zebra"
        if (sort.ContainsKey("zebra"))
        {
            Console.WriteLine(true);
        }

        // 5
        // Example: see if it contains "ape"
        Console.WriteLine(sort.ContainsKey("ape"));

        // 6
        // Example: see if it contains "programmer",
        // and if so get the value for "programmer"
        int v;
        if (sort.TryGetValue("programmer", out v))
        {
            Console.WriteLine(v);
        }

        // 7
        // Example: print SortedDictionary in alphabetic order
        foreach (KeyValuePair<string, int> p in sort)
        {
            Console.WriteLine("{0} = {1}",
                p.Key,
                p.Value);
        }
    }
}