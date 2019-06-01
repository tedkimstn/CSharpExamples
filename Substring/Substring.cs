using System;
using System.Diagnostics;

class Program
{
    const int _max = 1000000;
    static void Main()
    {

        const string value = "jounce";
        // Version 1: get 1-character substring.
        var s1 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            string firstLetter = value.Substring(0, 1);
            if (firstLetter != "j")
            {
                return;
            }
        }
        s1.Stop();
        // Version 2: access char directly.
        var s2 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            char firstLetter = value[0];
            if (firstLetter != 'j')
            {
                return;
            }
        }
        s2.Stop();
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
    }
}