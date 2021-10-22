using System;

namespace RST.Command
{
    public class Car: IUnit
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
}
