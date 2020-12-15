using System;

namespace Reiteration.Models
{
    public class Tractor : Car
    {
        public override void Go()
        {
            Console.WriteLine("Tractor is moving");
        }

        public override void BreakDown()
        {
            Console.WriteLine("Tractor the broke down");
        }
    }
}