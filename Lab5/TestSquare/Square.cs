using NUnit.Framework;
using System;

namespace TestSquare
{
    public class Tests
    {
        
        [Test]
        public void TestArea([Range (1,20,1)] double a)
        {
            var area = GeometricFigures.Square.GetArea(a);
            Assert.AreEqual(a * a, area, $"Ожидается {a * a}, получили {area}");
        }

        [Test]
        public void TestPerimetr([Range(1, 20, 1)] double x)
        {
            var perimetr = GeometricFigures.Square.GetLength(x);
            Assert.AreEqual(x * 4 , perimetr, $"Ожидается {x * 4}, получили {perimetr}");
        }

        
    }
}