using NUnit.Framework;
using System;

namespace TestTreangle
{
    public class Tests
    {
        [Test]
        public void TestArea([Range(1, 20, 1)] double a, [Range(1, 20, 1)] double b, [Range(1, 20, 1)] double c)
        {

            var s = (a + b + c) / 2;
            var testArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            var area = GeometricFigures.Triangle.GetArea(a, b, c); 
            Assert.AreEqual(testArea , area, $"Ожидается {testArea}, получили {area}");
        }

        [Test]
        public void TestPerimetr([Range(1, 20, 1)] double a, [Range(1, 20, 1)] double b, [Range(1, 20, 1)] double c)
        {
            var perimetr = GeometricFigures.Triangle.GetLength(a, b, c);
            Assert.AreEqual((a + b + c), perimetr, $"Ожидается { a + b + c}, получили {perimetr}");
        }
        


     }
}
