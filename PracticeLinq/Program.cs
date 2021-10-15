using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesList = new List<string>()
            {
                "Breath of the Wild",
                "Doom Evermore",
                "Rust",
                "Hollow Knight",
                "Genshin Impact",
                "Fifa 2077",
                "Star Citizen - lmao never gonna happen"
            };

            var gamesByLength = gamesList.OrderBy(game => game.Length);

            Console.WriteLine("Original List:\n*************************************");

            gamesList.ForEach(game => Console.WriteLine($"{game.Length}:    {game}"));

            Console.WriteLine("\n\nOrdered List:\n*************************************");

            foreach (var game in gamesByLength)
                Console.WriteLine($"{game.Length}:    {game}");
        }
    }
}
