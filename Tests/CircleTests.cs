using AreaCalculator.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;

namespace UnitTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(1);
            ClassicAssert.AreEqual(Math.PI, circle.GetArea(), 1e-10);
        }
    }
}
