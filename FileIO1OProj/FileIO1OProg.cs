using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleUI
{

    //=========
    class Program
    {

        //----------
        static void Main(string[] args)
        {
            string filePath = "./tc_fileio.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Sue,Storm,www.stormy.com");

            File.WriteAllLines(filePath, lines);

            Console.ReadLine();
        }
    }
}