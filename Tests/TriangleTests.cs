using AreaCalculator.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace UnitTests
{
    
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.AreEqual(6, triangle.GetArea(), 1e-10);
        }

        [Test]
        public void TestIsRightTriangle_True()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.IsTrue(triangle.CheckTriangleRight());
        }

        [Test]
        public void TestIsRightTriangle_False()
        {
            var triangle = new Triangle(2, 3, 4);
            ClassicAssert.IsFalse(triangle.CheckTriangleRight());
        }
    }

}
