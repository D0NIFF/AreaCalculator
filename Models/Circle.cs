using AreaCalculator.Interfaces;
using System;

namespace AreaCalculator.Models
{
    public class Circle : ISquare
    {
        public double Radius { get; set; }

        public Circle(float radius)
            { this.Radius = radius; }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius); 
        }
    }
}
