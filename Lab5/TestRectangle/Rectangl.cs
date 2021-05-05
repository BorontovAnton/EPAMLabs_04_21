using NUnit.Framework;

namespace TestRectangle
{
    public class Tests
    {

        [Test]
        public void TestArea([Range(1, 20, 1)] double a, [Range (1,20,1)] double b)
        {
            var area = GeometricFigures.Rectangle.GetArea(a, b);
            Assert.AreEqual(a * b, area, $"��������� {a * b}, �������� {area}");
        }

        [Test]
        public void TestPerimetr([Range(1, 20, 1)] double a, [Range(1, 20, 1)] double b)
        {
            var perimetr = GeometricFigures.Rectangle.GetLength(a, b);
            Assert.AreEqual(( a + b ) * 2, perimetr, $"��������� {(a + b) * 2}, �������� {perimetr}");
        }


    }
}