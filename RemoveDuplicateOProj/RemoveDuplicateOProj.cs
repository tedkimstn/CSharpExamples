using System;
using System.Diagnostics;

class Program
{
    const int _max = 1000000;
    static void Main()
    {
        var s1 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            string value = RemoveDuplicateChars("datagridviewtips");
            if (value == null)
            {
                return;
            }
        }
        s1.Stop();
        var s2 = Stopwatch.StartNew();
        for (int i = 0; i < _max; i++)
        {
            string value = RemoveDuplicateCharsFast("datagridviewtips");
            if (value == null)
            {
                return;
            }
        }
        s2.Stop();
        Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
            _max).ToString("0.00 ns"));
        Console.Read();
    }

    static string RemoveDuplicateChars(string key)
    {
        // See comments in first example.
        string result = "";

        foreach (char value in key)
        {
            if (result.IndexOf(value) == -1)
            {
                result += value;
            }
        }
        return result;
    }

    static string RemoveDuplicateCharsFast(string key)
    {
        // Remove duplicate chars using char arrays.
        int keyLength = key.Length;

        // Store encountered letters in this array.
        char[] table = new char[keyLength];
        int tableLength = 0;

        // Store the result in this array.
        char[] result = new char[keyLength];
        int resultLength = 0;

        foreach (char value in key)
        {
            // Scan the table to see if the letter is in it.
            bool exists = false;
            for (int i = 0; i < tableLength; i++)
            {
                if (value == table[i])
                {
                    exists = true;
                    break;
                }
            }
            // If the letter is new, add to the table and the result.
            if (!exists)
            {
                table[tableLength] = value;
                tableLength++;

                result[resultLength] = value;
                resultLength++;
            }
        }
        // Return the string at this range.
        return new string(result, 0, resultLength);
    }
}