using System;
using Reiteration.Interfaces;

namespace Reiteration.Models
{
    public class Car : ICar
    {
        public double Weight { get; set; }
        public double LiftingCapacity { get; set; }
        public virtual void Go()
        {
            Console.WriteLine("Car is moving");
        }

        public virtual void BreakDown()
        {
            Console.WriteLine("Car the broke down");
        }
    }
}