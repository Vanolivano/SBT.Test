using RST.Command;
using System;

namespace SBT.Test
{
    public class Chopper : IUnit
    {
        public void Move()
        {
            Console.WriteLine($"The chopper is moving.");
        }

        public void Rotate()
        {
            Console.WriteLine($"The chopper is rotating.");
        }
    }
}
