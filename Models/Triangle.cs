using AreaCalculator.Interfaces;
using System.Security.Policy;
using System;

namespace AreaCalculator.Models
{
    public class Triangle : ISquare
    {
        public double PartyA {  get; set; }
        public double PartyB {  get; set; }
        public double PartyC {  get; set; }

        public Triangle(double a, double b, double c) 
        { 
            this.PartyA = a;
            this.PartyB = b;
            this.PartyC = c;
        }

        public double CalculateArea()
        {
            double mid = (PartyA + PartyB + PartyC) / 2;
            double dobl = (mid - PartyA) * (mid - PartyB) * (mid - PartyC);
            return Math.Sqrt(mid * dobl);
        }

        public bool CheckTriangleRight()
        {
            double[] parties = { PartyA, PartyB, PartyC };
            Array.Sort(parties);
            return Math.Abs(parties[2] * parties[2] - (parties[0] * parties[0] + parties[1] * parties[1])) < 1e-10;
        }
    }
}
