using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGusser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int Answer = 0;
                Console.WriteLine("Guess a number between 1 & 10");

                while (Answer != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out Answer))
                    {
                        ColoredMessage(ConsoleColor.Red, "You can only insert real number");
                        continue;
                    }
                    Answer = Int32.Parse(input);

                    if (Answer != correctNumber)
                    {
                        ColoredMessage(ConsoleColor.Red, "Wrong number, Try Again");
                    }
                }
                ColoredMessage(ConsoleColor.Green, "You Win");
                Console.WriteLine("Do You want to play again ? [Y or N]");
                string repeat= Console.ReadLine().ToUpper();

                if (repeat != "Y")
                {
                    ColoredMessage(ConsoleColor.Yellow, "GoodBye");
                    return;
                }
                else
                {
                    continue;
                }

            }

        }

        static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to our game, What is you name ?");
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, Let's see how good your luck with numbers...", name);
        }

        static void ColoredMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
