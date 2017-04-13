using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    Console.WriteLine("Enter level (0 to 2)");
                    var level = Int32.Parse(Console.ReadLine());
                    //TODO: unsafe! need to more predictable way to convert int to Levels enum
                    var game = new Game((Levels)level);
                    Console.WriteLine(game.PrintBoard());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                Console.WriteLine("Quit?(y/n)");
                quit = Console.ReadLine().ToLower() == "y";
            } while (!quit);
        }
    }
}
