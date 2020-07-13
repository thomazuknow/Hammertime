using System.Collections.Generic;
using Hammertime.Core;

namespace Hammertime.Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //var rando = new Randomizer();
            //var rando2 = new Randomizer();
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine($"Part 1: "+ rando.GetRandom(1));
            //    Console.WriteLine($"Part 2: " + rando2.GetRandom(6));
            //}


            var nav = new Navigator(new Randomizer());

            for (int i = 0; i < 100; i++)
            {
                var d = nav.GetDirections(new List<Direction> { Direction.North, Direction.South, Direction.East }, 6);
                Console.WriteLine($"Dir: [{d.Direction}]");
                Console.WriteLine($"Steps: [{d.Steps}]");
                Console.WriteLine($"");
            }


            //var file = new FileHandler();

            //file.Write();




        }
    }
}
