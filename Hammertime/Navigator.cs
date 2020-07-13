using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hammertime.Core
{
    public class Navigator
    {
        private readonly Randomizer Randomizer;

        public Navigator(Randomizer randomizer)
        {
            this.Randomizer = randomizer;
        }

        public Directions GetDirections(List<Direction> possibleDirections, int maxSteps)
        {
            if(possibleDirections == null || !possibleDirections.Any())
                throw new ArgumentException($"Need to send in directions");

            var direction = this.GetRandomDirection(possibleDirections);

            return new Directions
            {
                Steps = this.Randomizer.GetRandom(maxSteps),
                Direction = direction
            };
        }

        private Direction GetRandomDirection(IEnumerable<Direction> possibleDirections)
        {
            var dir = possibleDirections.Distinct().ToList();
            if (dir.Count == 1)
                return dir.Single();
            
            var i = this.Randomizer.GetRandom(dir.Count() * this.Randomizer.GetRandom(dir.Count));
            var modulusPick = i % (dir.Count());
            var direction = dir.ToArray()[modulusPick];
            return direction;
        }
    }

    public class Directions
    {
        public Direction Direction { get; set; }
        public int Steps { get; set; }
    }

    public enum Direction
    {
        North,
        South,
        East,
        West
    }
}
