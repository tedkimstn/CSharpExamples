// source: https://github.com/panditakshay/Magic-8-ball/blob/master/Magic-8-Ball/Program.cs
// author: Pandit Akshay
// summary: c# magic 8 ball game
// modifications: eliminated foul-mouthed insults and words; eliminated comments;
//     condensed braces; changed predictions switch for a simple array lookup;
//     minor code modifications; reworked program exit logic; reworkded getQuestion
//     method; 
// student: Dan Bahrt
// capture date: 3 Apr 2019


using System;
using System.Threading;

namespace Magic_8_Ball
{

    //==========
    class Program
    {

        static string[] predictions = {
        "YES!",
        "NO!",
        "HELL NO!",
        "HELL YES!",
        "It is certain",
        "It is decidedly so",
        "Without a doubt",
        "You may rely on it",
        "Most likely!",
        "Outlook good!",
        "Reply hazy try again!",
        "Ask again later",
        "Better not tell you now!",
        "Cannot predict now",
        "Concentrate and ask again",
        "Don't count on it",
        "My sources say no",
        "Outlook not so good",
        "Very doubtful",
    };

        static Random randomObject = new Random();

        static ConsoleColor oldColor = Console.ForegroundColor;

        static string[] ynresponses = { "y", "n" };

        //----------
        static void Main(string[] args)
        {

            programInfo();

            while (true)
            {
                string questionString = getQuestion("Ask a question?: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nThinking...");
                int numberOfSecondsToSleep = ((randomObject.Next(5) + 1) * 1000);
                Thread.Sleep(numberOfSecondsToSleep);
                Console.Write("\r           \r");

                definedBallReplies();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                if (getValidResponse("Again (Y|N)? ", ynresponses) == "n")
                {
                    break;
                }
            }

            Console.ForegroundColor = oldColor;
        } // end function Main()

        //----------
        static void programInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Magic ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("8 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ball ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("(By: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Pandit ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Akshay ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(")");
            Console.WriteLine();
        } // end function programInfo()

        //----------
        static string getQuestion(string prompt)
        {
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write(prompt);

                Console.ForegroundColor = ConsoleColor.Gray;
                String userinput = Console.ReadLine().Trim().ToLower();

                if ((userinput.Length >= 2) && (userinput[userinput.Length - 1] == '?'))
                {
                    return userinput;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                if (userinput.Length < 2)
                {
                    Console.Write("Input is too short! ");
                    Console.WriteLine("Try again...");
                    continue;
                }
                if (userinput[userinput.Length - 1] != '?')
                {
                    Console.Write("A valid question ends with a \"?\" mark! ");
                    Console.WriteLine("Try again...");
                    continue;
                }
            }
        } // end function getQuestion()[p

        //----------
        static string getValidResponse(string prompt, string[] valid)
        {
            for (; ; )
            {
                Console.Write(prompt);
                string result = Console.ReadLine().Trim().ToLower();
                for (int ii = 0; ii < valid.Length; ii++)
                {
                    if (result == valid[ii])
                    {
                        return result;
                    }
                }
                Console.WriteLine("Invalid input! Try again...");
                Console.WriteLine();
            }
        } // end function getValidResponse()

        //----------
        static void definedBallReplies()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            int randomNumber = randomObject.Next(19);
            Console.WriteLine(predictions[randomNumber]);
            Console.WriteLine();
        } // end function definedBallReplies()
    } // end class Program

} // end namespace Magic_8_Ball