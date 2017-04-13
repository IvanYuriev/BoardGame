using System;
using System.Linq;
using WalkGame;
using Core;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the BoardGamer!");

            var quit = false;
            do
            {
                try
                {
                    var listLevels = string.Empty;
                    listLevels = Enum.GetValues(typeof (Levels)).Cast<Levels>().Aggregate(listLevels, (current, val) => current + $"{(int)val} ").TrimEnd();

                    Console.WriteLine($"Enter level ({listLevels})");
                    int level = int.TryParse(Console.ReadLine(), out level) ? level : -1;

                    var exist = Enum.IsDefined(typeof (Levels), level);
                    if (!exist)
                    {
                        Console.WriteLine("There is no such level!");
                        continue;
                    }

                    var game = new Game((Levels)level);
                    Console.WriteLine(game.PrintBoard());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                Console.WriteLine("Quit(y/n)?");
                var readLine = Console.ReadLine();
                if (readLine != null)
                    quit = readLine.ToLower() == "y";

            } while (!quit);
        }
    }
}
