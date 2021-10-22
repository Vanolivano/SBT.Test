using System;

namespace RST.Command
{
    public class Tank : IUnit
    {
        public void Move()
        {
            Console.WriteLine($"The tank is moving.");
        }

        public void Fire()
        {
            Console.WriteLine($"The tank is firing.");
        }
    }
}