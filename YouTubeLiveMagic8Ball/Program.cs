using System;
using System.Runtime.InteropServices.ComTypes;

namespace YouTubeLiveMagic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Max's Magic 8 Ball!");
            Console.Title = "Magic 8 Ball by Max Playle - Live on YouTube";

            while (true)
            {
                GetInput();

                RandomizeColor();

                PrintResponse(Response);

                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        static string UserQuestion = string.Empty;

        static Random random = new Random();

        static string Response  {
            get
            {
                return PotentialResponses[random.Next(0, PotentialResponses.Length - 1)];
            }
        }

        static string[] PotentialResponses =
        {
            "As I see it, yes",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "It is certain",
            "It is decidedly so",
            "Most likely",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Outlook good",
            "Reply hazy, try again",
            "Signs point to yes",
            "Very doubtful",
            "Wthout a doubt",
            "Yes.",
            "Yes - definitely.",
            "You may rely on it"
        }; 

        static void GetInput()
        {
            Console.WriteLine("Ask the Magic 8 Ball a question: ");
            UserQuestion = Console.ReadLine();

            if (UserQuestion.ToLower().Contains("exit"))
            {
                Environment.Exit(0);
            }
        }

        static void RandomizeColor()
        {
            // 15 values. Black is 0, White is 15.

            Random rnd = new Random();

            int currentBackColor = (int)Console.BackgroundColor;

            SELECT_RANDOM_NUMBER:

            int selected = rnd.Next(0, 15);

            if (selected == currentBackColor)
            {
                goto SELECT_RANDOM_NUMBER;
            }

            Console.ForegroundColor = (ConsoleColor)selected;
        }

        static void PrintResponse(string responseIn)
        {
            Console.WriteLine(responseIn);
        }
    }

}
